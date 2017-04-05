namespace RetroGamingCloudDotNet.Example
{
    partial class GameControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picMediaImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.txtCreated = new System.Windows.Forms.TextBox();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMediaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picMediaImage
            // 
            this.picMediaImage.Location = new System.Drawing.Point(3, 3);
            this.picMediaImage.Name = "picMediaImage";
            this.picMediaImage.Size = new System.Drawing.Size(348, 203);
            this.picMediaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMediaImage.TabIndex = 0;
            this.picMediaImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Platform:";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Location = new System.Drawing.Point(422, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 13);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(425, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 13);
            this.txtName.TabIndex = 3;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedBy.Location = new System.Drawing.Point(425, 51);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(112, 13);
            this.txtCreatedBy.TabIndex = 3;
            // 
            // txtCreated
            // 
            this.txtCreated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreated.Location = new System.Drawing.Point(425, 76);
            this.txtCreated.Name = "txtCreated";
            this.txtCreated.Size = new System.Drawing.Size(112, 13);
            this.txtCreated.TabIndex = 3;
            // 
            // txtPlatform
            // 
            this.txtPlatform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlatform.Location = new System.Drawing.Point(425, 106);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.Size = new System.Drawing.Size(112, 13);
            this.txtPlatform.TabIndex = 3;
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPlatform);
            this.Controls.Add(this.txtCreated);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picMediaImage);
            this.DoubleBuffered = true;
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(537, 209);
            ((System.ComponentModel.ISupportInitialize)(this.picMediaImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMediaImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.TextBox txtCreated;
        private System.Windows.Forms.TextBox txtPlatform;
    }
}
