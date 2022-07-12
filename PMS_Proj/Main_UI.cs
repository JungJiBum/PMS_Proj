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

        private void Work_Order_Click(object sender, EventArgs e)
        {
            MessageBox.Show("작업지시 조회 버튼");



        }

        private void Main_UI_Load(object sender, EventArgs e)
        {
            Login_User_Field.Text = "root";
            RegisterWorkOrder.Dock = DockStyle.Fill;
            WorkOrderInquiry.Dock = DockStyle.Fill;

            
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("작업 지시등록");
            RegisterWorkOrder.Show();
            WorkOrderInquiry.Hide();



        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("작업 지시조회");
            WorkOrderInquiry.Show();
            RegisterWorkOrder.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("창고 조회");
        }
    }
}
