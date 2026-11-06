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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validate empty fields
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            // Check login credentials
            if (username == "Admin" && password == "1234")
            {
                MessageBox.Show("Login successful!");

                // Open the next page
                Form_choose nextForm = new Form_choose();
                nextForm.Show();

                // Hide the login page
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
    }

    
    

