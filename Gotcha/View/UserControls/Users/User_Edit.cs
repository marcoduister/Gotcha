using Gotcha.BUS;
using Gotcha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotcha.View.UserControls.Users
{
    public partial class User_Edit : UserControl
    {
        UserController userController = new UserController();
        Guid User_Id;
        public User_Edit(Guid Id)
        {
            User_Id = Id;

            InitializeComponent();

            if (Properties.Settings.Default.UserRol != 2)
            {
                UserRol.Visible = false;
                label6.Visible = false;
            }

            UserRol.DataSource = Enum.GetValues(typeof(Enums.Rolen));
            FillTextBox();
        }

        private void FillTextBox()
        {
            User user = userController.GetUser(User_Id);

            FirstName.Text = user.FirstName;
            LastName.Text = user.LastName;
            Email.Text = user.Email;
            Birthdate.Value = user.Birthdate;
            if (user.ProfileImage !=null)
            {
                pictureBox_profileImage.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox_profileImage.Image = new Bitmap(userController.ByteArrayToImage(user.ProfileImage));
            }

            if (user.Rol == Enums.Rolen.Player)
            {
                UserRol.SelectedIndex = 0;
            }
            else if (user.Rol == Enums.Rolen.Gamemaster)
            {
                UserRol.SelectedIndex = 1;
            }
            else
            {
                UserRol.SelectedIndex = 2;
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userController.EditUser(FirstName.Text, LastName.Text, Email.Text, Birthdate.Value, UserRol.SelectedIndex, User_Id));
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
                if (userController.ImageToByteArray(new Bitmap(open.FileName), User_Id))
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
            User_Overview uc = new User_Overview();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
