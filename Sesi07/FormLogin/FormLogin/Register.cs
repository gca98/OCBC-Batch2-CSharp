using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class Register : Form
    {

        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTRegister_Click(object sender, EventArgs e)
        {

            string nama = TBNama.Text;
            string username = TBUsername.Text;
            string password = TBPassword.Text;

            if (nama.Equals("") || username.Equals("") || password.Equals(""))
            {
                TBNama.Focus();
                MessageBox.Show("Data Kosong !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string message = "Ingin Register Data ?";
            string caption = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                db.ExecuteSelect("SELECT * FROM `user_info` where username='" + TBUsername.Text + "'");
                if (db.Count() == 1)
                {
                    MessageBox.Show("Username sudah ada");
                }
                else
                {
                    db.Execute("INSERT INTO `user_info`(`nama`,`username`,`password`) VALUES ('" + TBNama.Text + "','" + TBUsername.Text + "','" + TBPassword.Text + "')");
                    MessageBox.Show("Berhasil Register Data...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBNama.Text = "";
                    TBUsername.Text = "";
                    TBPassword.Text = "";
                    this.Close();
                }
                
                
            }
            else
            {
                this.Close(); // close the connection setup form
            }
        }

        private void BTToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
