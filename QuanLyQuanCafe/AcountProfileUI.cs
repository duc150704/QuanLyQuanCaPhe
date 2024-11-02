using QuanLyQuanCAFE.DAO;
using QuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCAFE
{
    public partial class AcountProfileUI : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; ChangeAccount(); } }

        public AcountProfileUI(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void UpdateAccount()
        {
            string userName = txtUserName.Text;
            string displayName = txbDisPlayName.Text;
            string password = texPassWord.Text;
            string newPass = txbNewPassword.Text;
            string reEnterPass = txbCfNewPassWord.Text;

            if (!newPass.Equals(reEnterPass))
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng nhau!");
            } else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newPass))
                {
                    MessageBox.Show("Cập nhật thành công!");
                } else
                {
                    MessageBox.Show("Bạn chưa nhập hoặc nhập sai mật khẩu!");
                }
            }

        }

        void ChangeAccount()
        {
            txtUserName.Text = LoginAccount.UserName;
            txbDisPlayName.Text = LoginAccount.DisplayName;
        }

        private event EventHandler updateAccount;
        public event EventHandler UpdateAccountEv 
        {
            add { updateAccount += value; } 
            remove { updateAccount -= value; }
        }
    }
}
