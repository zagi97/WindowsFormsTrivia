using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Entities;

namespace PresentationLayer
{
    public partial class Form2 : Form
    {
        User _user = new User();
        Category _category = new Category();
        Difficulty _difficulty = new Difficulty();
        Question _question = new Question();

        private UserRepository _userRepository = new UserRepository();
        private TriviaRepostitory _triviaRepository = new TriviaRepostitory();

        private BindingSource _categoriesBindingSource = new BindingSource();
        private BindingSource _difficultyBindingSource = new BindingSource();

        public Form2()
        {
            InitializeComponent();
            _categoriesBindingSource.DataSource = _triviaRepository.GetCategories();
            _difficultyBindingSource.DataSource = _triviaRepository.GetDifficulty();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {           
            ////////////////////////////////////////////////////////
            _user.UserName = textBoxName.Text;
            _category.CategoryName = comboBoxCategory.Text;
            _difficulty.DifficultyLevel = comboBoxDifficulty.Text;
            _userRepository.SaveUser(_user, _category, _difficulty);
            ////////////////////////////////////////////////////////

            var user = new User
            {
                UserName = _user.UserName,          
            };
            var category = new Category
            {
                CategoryName = _category.CategoryName,
            };
            var difficulty = new Difficulty
            {
                DifficultyLevel = _difficulty.DifficultyLevel,
            };

            this.Hide();
            Form3 form3 = new Form3(user, category, difficulty);
            form3.Closed += (s, args) => this.Close();
            form3.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = _categoriesBindingSource;
            comboBoxDifficulty.DataSource = _difficultyBindingSource;
        }



    }
}
