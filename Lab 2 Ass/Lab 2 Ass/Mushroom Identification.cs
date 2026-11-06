using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_Ass
{
    public partial class Mushroom_Identification : Form
    {
        public Mushroom_Identification()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            string result;

            // Question 1
            answer = MessageBox.Show(
                "Does your mushroom have a convex cap?",
                "Mushroom Question 1",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.Yes)
            {
                // Question 2
                answer = MessageBox.Show(
                    "Does your mushroom grow in a forest?",
                    "Mushroom Question 2",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (answer == DialogResult.No)
                {
                    result = "Agaric Jaunissant";
                }
                else
                {
                    // Question 3
                    answer = MessageBox.Show(
                        "Does your mushroom have a ring?",
                        "Mushroom Question 3",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (answer == DialogResult.Yes)
                    {
                        result = "Amanite tue-mouche";
                    }
                    else
                    {
                        result = "Pied bleu";
                    }
                }
            }
            else
            {
                // Question 2
                answer = MessageBox.Show(
                    "Does your mushroom have gills?",
                    "Mushroom Question 2",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (answer == DialogResult.No)
                {
                    result = "Cepe de Bordeaux";
                }
                else
                {
                    // Question 3
                    answer = MessageBox.Show(
                        "Does your mushroom grow in a forest?",
                        "Mushroom Question 3",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (answer == DialogResult.No)
                    {
                        result = "Coprin chevelu";
                    }
                    else
                    {
                        result = "Girolle";
                    }
                }
            }

            // Display the final result
            lblResult.Text = "Identified Mushroom: " + result;

            MessageBox.Show(
                "Your mushroom is: " + result,
                "Identification Result",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form_choose chooseForm = new Form_choose();
            chooseForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            Form_login loginForm = new Form_login();
            loginForm.Show();
            this.Close();
        }
    }
    }
    


