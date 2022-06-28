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
    public partial class Main_UI : Form
    {
        public Main_UI()
        {
            InitializeComponent();
        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 하였습니다.");
            this.Close();
            Login_Main login_Main = new Login_Main();
            login_Main.Show();
        }
    }
}
