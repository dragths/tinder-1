using System.Data;
using tinder_1.DataBase;
using tinder_1.Models;

namespace tinder_1
{
    /// <summary>
    /// класс формы анкета1
    /// </summary>
    public partial class Questionnary : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly int _userId;
        private string photoPath = "";
        /// <summary>
        /// конструктор формы анкета1
        /// </summary>
        public Questionnary(int userId)
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            dateTimePicker1.Value = DateTime.Now.AddYears(-18);

            LoadGenders();
            LoadCities();
            this.CenterToScreen();

            _userId = userId;
        }
       
        
        private void LoadGenders()
        {
            var gengers = _dbContext.Genders.
                     Select(e => e.Name).
                     Distinct().
                     OrderBy(g => g).
                     ToArray();


            cmbSex.Items.AddRange(gengers);
        }
        private void LoadCities()
        {
            var cities = _dbContext.Cities.
                     Select(e => e.Name).
                     Distinct().
                     OrderBy(g => g).
                     ToArray();

            cmbCity.Items.AddRange(cities);
        }

        private bool CheckName(string name)
        { 
            if (string.IsNullOrEmpty(name) || !char.IsUpper(name[0]))
                return false;

            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {

            if (!CheckForm())
                return;

            try
            {
                
                SaveProfile();

                Questionnary2 nextForm = new Questionnary2(_userId);
                nextForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckForm()
        {
            
            string name = txtName.Text;
            DateTime minDate = DateTime.Now.AddYears(-18);
            bool isValid = true;
            if (cmbCity.Text==""||cmbSex.Text=="")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            if (name == "")
            {
                txtName.BackColor = Color.LightPink;
                isValid = false;
            }
            if (name != "")
            {
                if (!CheckName(name))
                {
                    MessageBox.Show("Имя должно начинаться с большой буквы и содержать только буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isValid = false;
                }
            }
            if (dateTimePicker1.Value > minDate)
            {
                MessageBox.Show("Вам должно быть не менее 18 лет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (picbPhoto.Image == null)
            {
                picbPhoto.BackColor = Color.LightPink;
                isValid = false;
            }


            return isValid;
        }


        private void SaveProfile()
        {
            int? genderId = null;
            foreach (var gender in _dbContext.Genders)
            {
                if (gender.Name == cmbSex.Text)
                {
                    genderId = gender?.Id;
                    break;
                }
            }


            int? cityId = null;
            foreach (var city in _dbContext.Cities)
            {
                if (city.Name == cmbCity.Text)
                {
                    cityId = city?.Id;
                    break;
                }
            }
            var user1 = new UserProfile
            {
                UserId = _userId,
                Name = txtName.Text,
                GenderId = genderId,
                BirthDate = dateTimePicker1.Value.ToUniversalTime(),
                CityId = cityId,
                PhotoPath = photoPath
            };

            _dbContext.UserProfiles.Add(user1);
            _dbContext.SaveChanges();



        }

        private void btnDownloadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = dialog.FileName;

                picbPhoto.Image = Image.FromFile(dialog.FileName);
                picbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}