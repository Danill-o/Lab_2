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
    public partial class Form_choose : Form
    {
        public Form_choose()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Mushroom_Identification mushroomForm = new Mushroom_Identification();

            mushroomForm.Show();
            this.Hide();
        }

        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBiycle_Click(object sender, EventArgs e)
        { 

            Form_biycle bicycleForm = new Form_biycle();

            bicycleForm.Show();
            this.Hide();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {


       
            Form_login loginForm = new Form_login();
            loginForm.Show();
            this.Close();
        }
    }
    }
    

