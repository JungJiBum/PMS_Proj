namespace PMS_Proj
{
    public partial class Login_Main : Form
    {
        public Login_Main()
        {
            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�α��ι�ư");
            this.Visible = false;
            Main_UI main_UI = new Main_UI();
            main_UI.ShowDialog();
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignUp signup = new SignUp();
            signup.ShowDialog();
            
        }
    }
}