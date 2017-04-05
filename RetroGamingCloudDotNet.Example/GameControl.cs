using System.Windows.Forms;

namespace RetroGamingCloudDotNet.Example
{
    public partial class GameControl : UserControl
    {
        public GameControl()
        {
            InitializeComponent();
        }
        public GameControl(Game game)
        {
            InitializeComponent();

            txtId.Text = game.Id.ToString();
            txtName.Text = game.Name;
            txtCreatedBy.Text = game.CreatedBy;
            txtCreated.Text = game.Created.ToString();
            txtPlatform.Text = game.Platform.Name;
            picMediaImage.Image = game.Media?[0].MediaBitmap;
        }
    }
}
