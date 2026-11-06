namespace Lab_2_Ass
{
    partial class Form_choose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBiycle = new System.Windows.Forms.Button();
            this.btnMushroom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMushroom);
            this.panel1.Controls.Add(this.btnBiycle);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.panel1.Location = new System.Drawing.Point(31, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 383);
            this.panel1.TabIndex = 0;
            // 
            // btnBiycle
            // 
            this.btnBiycle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBiycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnBiycle.Location = new System.Drawing.Point(98, 163);
            this.btnBiycle.Name = "btnBiycle";
            this.btnBiycle.Size = new System.Drawing.Size(159, 61);
            this.btnBiycle.TabIndex = 0;
            this.btnBiycle.Text = "Biycle Rental";
            this.btnBiycle.UseVisualStyleBackColor = false;
            this.btnBiycle.Click += new System.EventHandler(this.btnBiycle_Click);
            // 
            // btnMushroom
            // 
            this.btnMushroom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMushroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnMushroom.Location = new System.Drawing.Point(325, 163);
            this.btnMushroom.Name = "btnMushroom";
            this.btnMushroom.Size = new System.Drawing.Size(177, 61);
            this.btnMushroom.TabIndex = 1;
            this.btnMushroom.Text = "Mushroom Identification";
            this.btnMushroom.UseVisualStyleBackColor = false;
            this.btnMushroom.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(156, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Your Activity ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogout.Location = new System.Drawing.Point(237, 263);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form_choose
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(684, 447);
            this.Controls.Add(this.panel1);
            this.Name = "Form_choose";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMushroom;
        private System.Windows.Forms.Button btnBiycle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}