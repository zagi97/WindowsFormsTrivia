using DataAccessLayer;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form3 : Form
    {
        User _user = new User();
        Category _category = new Category();
        Difficulty _difficulty = new Difficulty();
        Question _question = new Question();
        private TriviaRepostitory _triviaRepository = new TriviaRepostitory();

        public Form3(User user, Category category, Difficulty difficulty)
        {
            _user = user;
            _category = category;
            _difficulty = difficulty;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(_question.Description);
            lblEditUserName.Text = _user.UserName;
            lblEditCategory.Text = _category.CategoryName;
            lblEditDifficulty.Text = _difficulty.DifficultyLevel;

            var pitanja = new List<string>();

            pitanja.Add("1. pitanje");
            pitanja.Add("2. pitanje");

            foreach(var pitanje in pitanja)
            {
                Label pitanjeLabel = new Label();
                pitanjeLabel.Text = pitanje;
                panelPitanja.Controls.Add(pitanjeLabel);
            }
            
        }

    }
}
