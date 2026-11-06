namespace Lab_2_Ass
{
    partial class Form_biycle
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
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtEndTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.txtStartTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 426);
            this.panel1.TabIndex = 0;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtEndTime.Location = new System.Drawing.Point(35, 196);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(699, 29);
            this.txtEndTime.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(31, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ending Hour(1-24)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Starting Hour(0-23)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTotal.Location = new System.Drawing.Point(59, 255);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(156, 24);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total Rental Cost:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLogout.Location = new System.Drawing.Point(633, 363);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(17, 363);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 51);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCalculate.Location = new System.Drawing.Point(238, 291);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(260, 58);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtStartTime.Location = new System.Drawing.Point(35, 113);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(699, 29);
            this.txtStartTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rental Hours";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lbltitle.Location = new System.Drawing.Point(127, -3);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(315, 58);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "                    Bicycle Rental\r\n\r\n";
            // 
            // Form_biycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form_biycle";
            this.Text = "Form_bicycle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndTime;
    }
}