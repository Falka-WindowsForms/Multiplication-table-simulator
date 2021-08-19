using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication_table_simulator
{
    public enum Difficulties
    {
        single_nums,
        double_nums,
        insane_nums
    }
    public partial class DifficultySelect : Form
    {
        //DifficultySelect difficultySelect;
        public DifficultySelect(string name)
        {
            InitializeComponent();
            this.Name = name;
            this.Show();
        }
        private void CallNewForm(Difficulties difficulties)
        {
            Quiz quiz = new Quiz(difficulties);
            quiz.Show();
            quiz.Closed += (obj, args) => this.Close();
            this.Hide();
        }
        private void DifficultySelect_Load(object sender, EventArgs e)
        {
            label_name.Text = Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallNewForm(Difficulties.single_nums);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void double_button_Click(object sender, EventArgs e)
        {
            CallNewForm(Difficulties.double_nums);
        }


        private void insane_button_Click(object sender, EventArgs e)
        {
            CallNewForm(Difficulties.insane_nums);
        }
    }
}
