using tinder_1.DataBase;
using tinder_1.Models;

namespace tinder_1
{
    /// <summary>
    /// класс формы регистрации
    /// </summary>
    public partial class Registration : Form
    {
        private readonly ApplicationDbContext _dbContext;
        /// <summary>
        /// конструктор формы регистрации
        /// </summary>
        public Registration()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            this.CenterToScreen();

            _dbContext = new ApplicationDbContext();
        }

        private void btnRegistration2_Click(object sender, EventArgs e)
        {

            string login = textBoxLogin.Text;
            string pass = textBoxPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (LoginIsTaken(login))
            {
                MessageBox.Show("Такой логин уже занят!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = RegisterNewUser(login, pass);
            MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Questionnary questForm = new Questionnary(userId);
            questForm.Show();
            this.Hide();
        }

        private bool LoginIsTaken(string login)
        {
            foreach (var user in _dbContext.Users)
            {
                if (user.Login == login)
                { return true; }

            }
            return false;
        }

        private int RegisterNewUser(string login, string password)
        {
            var newUser = new User
            {
                Login = login,
                Password = password, 
            };

            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();

            return newUser.Id;
        }

    }
}