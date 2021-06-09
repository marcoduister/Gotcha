using Gotcha.BUS;
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
    public partial class User_Overview : UserControl
    {
        private UserController _UserController = new UserController();
        public User_Overview()
        {
            InitializeComponent();
        }

        private void User_Overview_Load(object sender, EventArgs e)
        {

            List<Models.User> userList = _UserController.GetAllUsers();

            foreach (var User in userList)
            {
                if (User.Id != new Guid(Properties.Settings.Default.UserId))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView_Users);
                    row.Cells[0].Value = User.Id;
                    row.Cells[1].Value = User.FirstName;
                    row.Cells[2].Value = User.LastName;
                    row.Cells[3].Value = User.Email;
                    row.Cells[4].Value = User.Birthdate;
                    DataGridViewButtonCell btn_Edit = new DataGridViewButtonCell() { Value = "Edit" };
                    row.Cells[5] = btn_Edit;
                    DataGridViewButtonCell btn_Delete = new DataGridViewButtonCell() { Value = "Delete" };
                    row.Cells[6] = btn_Delete;
                    //DataGridViewButtonCell btn_Read = new DataGridViewButtonCell() { Value = "Read" };
                    //row.Cells[7] = btn_Read;

                    dataGridView_Users.Rows.Add(row);
                }

            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            User_Add uc = new User_Add();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void dataGridView_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid User_id = Guid.Parse(dataGridView_Users.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_Users.Columns[e.ColumnIndex].Name == "btn_Edit")
            {
                this.Controls.Clear();
                User_Edit uc = new User_Edit(User_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (dataGridView_Users.Columns[e.ColumnIndex].Name == "btn_Delete")
            {
                if (_UserController.DeleteUser(User_id))
                {
                    MessageBox.Show("you have deleted a user");
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }
    }
}
