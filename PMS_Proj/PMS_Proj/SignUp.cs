using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS_Proj
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Sign_Up_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Main login_Main = new Login_Main();
            MessageBox.Show("회원가입완료");
            login_Main.Show();
        }
    }
}
