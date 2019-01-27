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
        private BindingSource _questionsBindingSource = new BindingSource();

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
            pitanja = _triviaRepository.GetQuestions();

            var odgovori = new List<Question>();
            odgovori = _triviaRepository.GetTriviaQA();

            int nbroj = 1;
            for (int i = 0; i < pitanja.Count; i++)
            {                
                Label pitanjeLabel = new Label();
                pitanjeLabel.Top = (i + 1) * 30;
                pitanjeLabel.AutoSize = true;
                pitanjeLabel.Text = nbroj++ +".  "+ pitanja[i].ToString();
                panelPitanja.Controls.Add(pitanjeLabel);

               
                RadioButton odgvoriButton = new RadioButton();
                odgvoriButton.Location = new Point(0, 25);
                odgvoriButton.Left = 600;
                odgvoriButton.Top = (i + 1) * 30;
                odgvoriButton.AutoSize = true;
                panelPitanja.Controls.Add(odgvoriButton);

                RadioButton odgvoriButton1 = new RadioButton();
                odgvoriButton1.Location = new Point(0, 25);
                odgvoriButton1.Left = 720;
                odgvoriButton1.Top = (i + 1) * 30;
                odgvoriButton1.AutoSize = true;
                panelPitanja.Controls.Add(odgvoriButton1);

                RadioButton odgvoriButton2 = new RadioButton();
                odgvoriButton2.Location = new Point(0, 25);
                odgvoriButton2.Left = 840;
                odgvoriButton2.Top = (i + 1) * 30;
                odgvoriButton2.AutoSize = true;
                panelPitanja.Controls.Add(odgvoriButton2);

                RadioButton odgvoriButton3 = new RadioButton();
                odgvoriButton3.Location = new Point(0,25);
                odgvoriButton3.Left = 960;
                odgvoriButton3.Top = (i + 1) * 30;
                odgvoriButton3.AutoSize = true;
                panelPitanja.Controls.Add(odgvoriButton3);

                //for (int j = 15; j < odgovori.Count; j++)
                //{
                //    Label odgovoriLabel = new Label();
                //    odgovoriLabel.Top = (j + 1) * 30;
                //    odgovoriLabel.Text = odgovori[j].Answers.ToString();
                //    odgovoriLabel.AutoSize = true;
                //    panelPitanja.Controls.Add(odgovoriLabel);
                //}
            }
            
        }

        private void panelPitanja_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
