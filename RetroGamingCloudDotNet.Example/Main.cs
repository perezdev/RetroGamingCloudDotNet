using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroGamingCloudDotNet.Example
{
    public partial class Main : Form
    {
        public List<Game> Games { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void txtSearch_GameName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch_GameName.Text))
                MessageBox.Show("You must enter a name!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                vwGames.Items.Clear();
                tcGames.TabPages.Clear();

                Games = Game.Search(txtSearch_GameName.Text);

                foreach (var game in Games)
                {
                    ListViewItem item = new ListViewItem() { Text = game.Id.ToString() };
                    item.SubItems.Add(game.Name);
                    item.SubItems.Add(game.Platform.Name);

                    vwGames.Items.Add(item);
                }
            }
        }

        private void vwGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vwGames.SelectedItems.Count > 0)
            {
                var game = Games.SingleOrDefault(x => x.Id == Convert.ToInt32(vwGames.SelectedItems[0].Text));

                TabPage page = new TabPage() { Text = game.Name };
                page.Controls.Add(new GameControl(game) { Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right });
                tcGames.TabPages.Add(page);
            }
        }

        private void tcGames_MouseClick(object sender, MouseEventArgs e)
        {
            var tabControl = sender as TabControl;
            var tabs = tabControl.TabPages;

            if (e.Button == MouseButtons.Middle)
            {
                tabs.Remove(tabs.Cast<TabPage>()
                        .Where((t, i) => tabControl.GetTabRect(i).Contains(e.Location))
                        .First());
            }
        }
    }
}
