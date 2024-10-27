using QuanLyQuanCAFE.DAO;
using QuanLyQuanCAFE.DTO;

namespace QuanLyQuanCAFE
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private bool Login(string userName, String password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }
        private void ButLogin_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = texPassWord.Text;
            if (Login(userName,password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                tableManagercs f = new tableManagercs(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
            }

        }


          private void butExit_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        }
       private void fLogin_FormClosing(object sender, FormClosingEventArgs e) {


            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
