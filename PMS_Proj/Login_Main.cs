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
            //Test ID = root / PW = root
            string ID = "root";
            string PW = "root";

            if (Id_Field.Text != ID)
            {
                MessageBox.Show("아이디가 틀렸습니다.");
            }
            else if (Id_Field.Text == ID && Pw_Field.Text != PW)
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
            }
            else if(Id_Field.Text ==ID && Pw_Field.Text == PW)
            {
                MessageBox.Show("로그인성공");
                this.Visible = false;
                Main_UI main_UI = new Main_UI();
                main_UI.ShowDialog();
            }

        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignUp signup = new SignUp();
            signup.ShowDialog();

        }
    }
}