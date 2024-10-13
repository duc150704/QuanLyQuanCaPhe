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
        private void ButLogin_Click(object sender, EventArgs e)
        {
            tableManagercs f = new tableManagercs();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
          private void butExit_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        }
       private void fLogin_FormClosing(object sender, FormClosingEventArgs e) {


            if (MessageBox.Show("Bạn có tật sự muốn thoát chương trình","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
