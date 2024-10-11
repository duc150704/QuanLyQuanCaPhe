namespace CoffeeShopManager;

public partial class Form1 : Form
    {
        // Khai báo các điều khiển
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        public Form1()
        {
            InitializeComponent();

            // Thiết lập các điều khiển
            lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new System.Drawing.Point(30, 30);
            lblUsername.Size = new System.Drawing.Size(80, 20);

            lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Location = new System.Drawing.Point(30, 70);
            lblPassword.Size = new System.Drawing.Size(80, 20);

            txtUsername = new TextBox();
            txtUsername.Location = new System.Drawing.Point(120, 30);
            txtUsername.Size = new System.Drawing.Size(150, 20);

            txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(120, 70);
            txtPassword.Size = new System.Drawing.Size(150, 20);
            txtPassword.UseSystemPasswordChar = true; // Để mật khẩu dạng ẩn

            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(120, 110);
            btnLogin.Click += BtnLogin_Click;

            // Thêm các điều khiển vào form
            this.Controls.Add(lblUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")  // Giả sử thông tin đăng nhập mặc định
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở màn hình chính của ứng dụng, hoặc thực hiện các chức năng khác
            }
            else
            {
                MessageBox.Show("Invalid login. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

