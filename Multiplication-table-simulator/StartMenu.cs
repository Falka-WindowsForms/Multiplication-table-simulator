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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (Name_text_box.Text == "")
                MessageBox.Show("Wrong input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                this.Hide();
                DifficultySelect df = new DifficultySelect(Name_text_box.Text);
                df.Closed += (obj, args) => this.Close();
            }
        }
    }
}
