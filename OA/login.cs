using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OA
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string user = this.UserBox.Text.Trim();
            string pass = this.PassBox.Text.Trim();
            if ((user == "root") && (pass == "123456"))
            {
                M_Form F2 = new M_Form();
                this.Hide();
                F2.Show();
            }
            else {
                MessageBox.Show("你的帐号密码不正确！");
            }
        }
    }
}
