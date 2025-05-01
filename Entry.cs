using tinder_1.DataBase;

namespace tinder_1
{
    /// <summary>
    /// ����� ����� �����
    /// </summary>
    public partial class Entry : Form
    {
        private readonly ApplicationDbContext _dbContext;
        /// <summary>
        /// ����������� ����� �����
        /// </summary>
        public Entry()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            this.CenterToScreen();

            _dbContext = new ApplicationDbContext();        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void CheckLogin()
        {
            var login = textBoxLogin.Text;
            var pass = textBoxPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                textBoxLogin.BackColor = Color.LightPink;
                textBoxPassword.BackColor = Color.LightPink;

                return;
            }

            if (UserExists(login, pass))
            {

                MessageBox.Show("���� �������� �������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);


                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("�������� ����� ��� ������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UserExists(string login, string password)
        {
           
            foreach (var user in _dbContext.Users)
            {
                if (user.Login == login && user.Password == password)
                    { return true; }
               
            }
            return false;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Registration Form = new Registration();
            Form.Show();
            this.Hide();
        }

    }
}