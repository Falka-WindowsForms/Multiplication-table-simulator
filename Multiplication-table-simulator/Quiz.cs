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
    public partial class Quiz : Form
    {
        int points = 0;
        int current_question_num = 1;
        Random rnd = new Random();
        Difficulties current_difficult;
        private string current_question;
        public string Current_question {
            get
            {
                return current_question;
            }
            set
            {
                current_question = value;
                answer_label.Text = value;
            }
        }
        public string Awaiting_answer;
        public string current_answer;
        private string Current_answer
        {
            get
            {
                return current_answer;
            }
            set
            {
                current_answer = value;
                answer_box.Text = value;
            }
        }
        public Quiz(Difficulties difficulties)
        {
            InitializeComponent();
            current_difficult = difficulties;
            int num1 = 0, num2 = 0;
            if (current_difficult == Difficulties.single_nums)
            {
                num1 = rnd.Next(10);
                num2 = rnd.Next(10);
            }
            else if (current_difficult == Difficulties.double_nums)
            {
                num1 = rnd.Next(100);
                num2 = rnd.Next(100);
            }
            else if (current_difficult == Difficulties.insane_nums)
            {
                num1 = rnd.Next(1000);
                num2 = rnd.Next(1000);
            }
            Current_question = $"{num1} * {num2}";
            Awaiting_answer = $"{num1 * num2}";
        }
        private void Next_button_Click(object sender, EventArgs e)
        {
            if (Awaiting_answer == Current_answer)
            {
                points++;
                MessageBox.Show("Correct answer", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Answer", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Current_answer = "";
            current_question_num++;
            int num1=0,num2=0;
            if(current_difficult == Difficulties.single_nums)
            {
                num1 = rnd.Next(10);
                num2 = rnd.Next(10);
            }else if(current_difficult == Difficulties.double_nums)
            {
                num1 = rnd.Next(100);
                num2 = rnd.Next(100);
            }else if(current_difficult == Difficulties.insane_nums)
            {
                num1 = rnd.Next(1000);
                num2 = rnd.Next(1000);
            }
            Current_question = $"{num1} * {num2}";
            Awaiting_answer = $"{num1 * num2}";
        }
        private void End_button_Click(object sender, EventArgs e)
        {
            if (Awaiting_answer == Current_answer)
            {
                points++;
                MessageBox.Show("Correct answer", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Answer", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show($"{points}/{current_question_num}. Your rate: {Math.Round(((double)points / current_question_num) * 12,2)}","Results",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Current_answer += "1";
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            answer_box.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Current_answer += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Current_answer += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Current_answer += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Current_answer += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Current_answer += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Current_answer += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Current_answer += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Current_answer += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Current_answer += "0";
        }

        private void Backscape_button_Click(object sender, EventArgs e)
        {
            string temp="";
            for(int i = 0; i < Current_answer.Length-1; i++)
            {
                temp += Current_answer[i];
            }
            Current_answer = temp;
        }

        
    }
}
