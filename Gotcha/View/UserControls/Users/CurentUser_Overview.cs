using Gotcha.BUS;
using Gotcha.Models;
using Gotcha.View.UserControls.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotcha.View.UserControls.Users
{
    public partial class CurentUser_Overview : UserControl
    {
        Guid CurentUser = Guid.Parse(Properties.Settings.Default.UserId);
        UserController userController = new UserController();
        public CurentUser_Overview()
        {
            InitializeComponent();
            FillTextBox();
        }
        private void FillTextBox()
        {
            User user = userController.GetUser(CurentUser);

            FirstName.Text = user.FirstName;
            LastName.Text = user.LastName;
            Email.Text = user.Email;
            Birthdate.Value = user.Birthdate;
            if (user.ProfileImage != null)
            {
                pictureBox_profileImage.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox_profileImage.Image = new Bitmap(userController.ByteArrayToImage(user.ProfileImage));
            }
        }

        private void UpdateCurentUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userController.EditCurentUser(FirstName.Text, LastName.Text, Email.Text, Birthdate.Value, CurentUser));
            Btn_Cancel_Click(null, null);
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (userController.ImageToByteArray(new Bitmap(open.FileName), new Guid(Properties.Settings.Default.UserId)))
                {
                    // display image in picture box  
                    pictureBox_profileImage.Image = new Bitmap(open.FileName);
                    // image file path  
                    textBox_imagePath.Text = open.FileName;
                    MessageBox.Show("you have uploaded a Profile image ");
                }
                else
                {
                    MessageBox.Show("somthing when wrong please trye again!! ");
                }
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Game_Overview uc = new Game_Overview();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
