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
    public partial class FormLogin : Form
    {
        Config db = new Config();
        public FormLogin()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void LblRegister_Click(object sender, EventArgs e)
        {

        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `user_info` where username='" + TBUsername.Text + "' AND password = '" + TBPassword.Text + "'");
            if(db.Count() == 1)
            {
                MessageBox.Show("Success You Will Login as " + db.Results(0, "nama"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
