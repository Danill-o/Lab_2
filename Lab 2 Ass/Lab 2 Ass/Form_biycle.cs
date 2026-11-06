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
    public partial class Form_biycle : Form
    {
        public Form_biycle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startTime;
            int endTime;

            // Validate whole-number inputs
            if (!int.TryParse(txtStartTime.Text, out startTime) ||
                !int.TryParse(txtEndTime.Text, out endTime))
            {
                MessageBox.Show("Enter whole numbers only.");
                return;
            }

            // Validate the time range
            if (startTime < 0 || startTime > 23 ||
                endTime < 1 || endTime > 24 ||
                startTime >= endTime)
            {
                MessageBox.Show(
                    "Start time must be 0-23, end time 1-24, " +
                    "and start time must be less than end time."
                );
                return;
            }

            int total = 0;

            // Calculate the cost of each rented hour
            for (int hour = startTime; hour < endTime; hour++)
            {
                int rate;

                if (hour < 7 || hour >= 21)
                {
                    rate = 500;
                }
                else if (hour < 14)
                {
                    rate = 1000;
                }
                else if (hour < 19)
                {
                    rate = 1500;
                }
                else
                {
                    rate = 1000;
                }

                total += rate;
            }

            lblTotal.Text = "Total Cost: " + total + " RWF";
        }




        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form_login loginForm = new Form_login();
            loginForm.Show();
            this.Close();

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_choose chooseForm = new Form_choose();
            chooseForm.Show();
            this.Close();
        }

    }
}
