using System.Data;
using tinder_1.DataBase;
using tinder_1.Models;
using Microsoft.EntityFrameworkCore;

namespace tinder_1
 {   /// <summary>
     /// класс формы анкета1
     /// </summary>
    public partial class Questionnary2 : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly int _userId;
        private UserProfile _userProfile;

        /// <summary>
        /// конструктор формы анкета2
        /// </summary>
        public Questionnary2(int userId)
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _userProfile = _dbContext.UserProfiles.Find(userId);
            _userId = userId;
            LoadUserProfile();
            
            this.CenterToScreen();
 
        }
        private void LoadUserProfile()
        {
            _userProfile = _dbContext.UserProfiles.FirstOrDefault(up => up.UserId == _userId);

            if (_userProfile == null)
            {
                MessageBox.Show("Профиль не найден!"); 
                return;
            }
            LoadHobbies();
            LoadRelationship();
            LoadFilm();
            LoadMusic();

            txtAboutme.Text = _userProfile.AboutMe;
        }

        private void LoadHobbies()
        {
            var hobbies = _dbContext.Hobbies.
                    Select(e => e.Name).
                    Distinct().
                    OrderBy(g => g).
                    ToArray();

            cmbHobbies.Items.AddRange(hobbies);
        }
        private void LoadFilm()
        {
            var films = _dbContext.FilmGenres
                .Select(e => e.Name)
                .Distinct()
                .OrderBy(c => c)
                .ToArray();

            cmbFilm.Items.AddRange(films);
        }
        private void LoadMusic()
        {
            var music = _dbContext.MusicGenres
                   .Select(e => e.Name)
                   .Distinct()
                   .OrderBy(c => c)
                   .ToArray();

            cmbMusic.Items.AddRange(music);
        }
        private void LoadRelationship()
        {
            var relat = _dbContext.BadHabitsAttitudes
                     .Select(e => e.Name)
                     .Distinct()
                     .OrderBy(c => c)
                     .ToArray();

            cmbRelationship.Items.AddRange(relat);
        }


        public bool CheckForm()
        {
            string aboutme = txtAboutme.Text;
            bool isValid = true;

            if (aboutme == "")
            {
                txtAboutme.BackColor = Color.LightPink;
                isValid = false;
            }
            if (cmbHobbies.Text == "" || cmbMusic.Text == "" || cmbFilm.Text == "" || cmbRelationship.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            return isValid;
        }
        private void SaveProfile()
        {
            int? hobbyId = null;
            foreach (var hobby in _dbContext.Hobbies)
            {
                if (hobby.Name == cmbHobbies.Text)
                {
                    hobbyId = hobby?.Id;
                    break;
                }
            }

            int? musicGenreId = null;
            foreach (var music in _dbContext.MusicGenres)
            {
                if (music.Name == cmbMusic.Text)
                {
                    musicGenreId = music?.Id;
                    break;
                }
            }
            int? filmGenreId = null;
            foreach (var film in _dbContext.FilmGenres)
            {
                if (film.Name == cmbFilm.Text)
                {
                    filmGenreId = film?.Id;
                    break;
                }
            }

            int? badHabitsAttitudeId = null;
            foreach (var badHabitsAttitude in _dbContext.BadHabitsAttitudes)
            {
                if (badHabitsAttitude.Name == cmbRelationship.Text)
                {
                    badHabitsAttitudeId = badHabitsAttitude?.Id;
                    break;
                }
            }


            _userProfile.HobbyId = hobbyId;
            _userProfile.BadHabitsAttitudeId = badHabitsAttitudeId;
            _userProfile.MusicGenreId = musicGenreId;
            _userProfile.FilmGenreId = filmGenreId;
            _userProfile.AboutMe = txtAboutme.Text;

            if (_dbContext.Entry(_userProfile).State == EntityState.Modified)
                _dbContext.SaveChanges();
        }

        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
                return;

            try
            {
                
                SaveProfile();

                MainWindow nextForm = new MainWindow();
                nextForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}