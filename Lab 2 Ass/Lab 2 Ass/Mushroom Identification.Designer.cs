namespace Lab_2_Ass
{
    partial class Mushroom_Identification
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGills = new System.Windows.Forms.Label();
            this.lblForest = new System.Windows.Forms.Label();
            this.lblRing = new System.Windows.Forms.Label();
            this.lblConvex = new System.Windows.Forms.Label();
            this.rbGillsYes = new System.Windows.Forms.RadioButton();
            this.rbGillsNo = new System.Windows.Forms.RadioButton();
            this.rbForestYes = new System.Windows.Forms.RadioButton();
            this.rbForestNo = new System.Windows.Forms.RadioButton();
            this.rbRingYes = new System.Windows.Forms.RadioButton();
            this.rbRingNo = new System.Windows.Forms.RadioButton();
            this.rbConvexYes = new System.Windows.Forms.RadioButton();
            this.rbConvexNo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitle.Location = new System.Drawing.Point(216, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mushroom Identification";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGills
            // 
            this.lblGills.AutoSize = true;
            this.lblGills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblGills.Location = new System.Drawing.Point(40, 91);
            this.lblGills.Name = "lblGills";
            this.lblGills.Size = new System.Drawing.Size(180, 24);
            this.lblGills.TabIndex = 1;
            this.lblGills.Text = "1. Does it have gills?";
            // 
            // lblForest
            // 
            this.lblForest.AutoSize = true;
            this.lblForest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblForest.Location = new System.Drawing.Point(40, 123);
            this.lblForest.Name = "lblForest";
            this.lblForest.Size = new System.Drawing.Size(229, 24);
            this.lblForest.TabIndex = 2;
            this.lblForest.Text = "2. Does it grow in a forest?";
            this.lblForest.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRing
            // 
            this.lblRing.AutoSize = true;
            this.lblRing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRing.Location = new System.Drawing.Point(40, 156);
            this.lblRing.Name = "lblRing";
            this.lblRing.Size = new System.Drawing.Size(195, 24);
            this.lblRing.TabIndex = 3;
            this.lblRing.Text = "3. Does it have a ring?";
            // 
            // lblConvex
            // 
            this.lblConvex.AutoSize = true;
            this.lblConvex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConvex.Location = new System.Drawing.Point(40, 190);
            this.lblConvex.Name = "lblConvex";
            this.lblConvex.Size = new System.Drawing.Size(188, 24);
            this.lblConvex.TabIndex = 4;
            this.lblConvex.Text = "4. Is the cup convex?";
            this.lblConvex.Click += new System.EventHandler(this.label5_Click);
            // 
            // rbGillsYes
            // 
            this.rbGillsYes.AutoSize = true;
            this.rbGillsYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbGillsYes.Location = new System.Drawing.Point(283, 86);
            this.rbGillsYes.Name = "rbGillsYes";
            this.rbGillsYes.Size = new System.Drawing.Size(57, 28);
            this.rbGillsYes.TabIndex = 5;
            this.rbGillsYes.TabStop = true;
            this.rbGillsYes.Text = "yes";
            this.rbGillsYes.UseVisualStyleBackColor = true;
            // 
            // rbGillsNo
            // 
            this.rbGillsNo.AutoSize = true;
            this.rbGillsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbGillsNo.Location = new System.Drawing.Point(413, 86);
            this.rbGillsNo.Name = "rbGillsNo";
            this.rbGillsNo.Size = new System.Drawing.Size(50, 28);
            this.rbGillsNo.TabIndex = 6;
            this.rbGillsNo.TabStop = true;
            this.rbGillsNo.Text = "no";
            this.rbGillsNo.UseVisualStyleBackColor = true;
            // 
            // rbForestYes
            // 
            this.rbForestYes.AutoSize = true;
            this.rbForestYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbForestYes.Location = new System.Drawing.Point(283, 121);
            this.rbForestYes.Name = "rbForestYes";
            this.rbForestYes.Size = new System.Drawing.Size(57, 28);
            this.rbForestYes.TabIndex = 7;
            this.rbForestYes.TabStop = true;
            this.rbForestYes.Text = "yes";
            this.rbForestYes.UseVisualStyleBackColor = true;
            // 
            // rbForestNo
            // 
            this.rbForestNo.AutoSize = true;
            this.rbForestNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbForestNo.Location = new System.Drawing.Point(413, 119);
            this.rbForestNo.Name = "rbForestNo";
            this.rbForestNo.Size = new System.Drawing.Size(50, 28);
            this.rbForestNo.TabIndex = 8;
            this.rbForestNo.TabStop = true;
            this.rbForestNo.Text = "no";
            this.rbForestNo.UseVisualStyleBackColor = true;
            // 
            // rbRingYes
            // 
            this.rbRingYes.AutoSize = true;
            this.rbRingYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbRingYes.Location = new System.Drawing.Point(283, 154);
            this.rbRingYes.Name = "rbRingYes";
            this.rbRingYes.Size = new System.Drawing.Size(57, 28);
            this.rbRingYes.TabIndex = 9;
            this.rbRingYes.TabStop = true;
            this.rbRingYes.Text = "yes";
            this.rbRingYes.UseVisualStyleBackColor = true;
            // 
            // rbRingNo
            // 
            this.rbRingNo.AutoSize = true;
            this.rbRingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbRingNo.Location = new System.Drawing.Point(413, 152);
            this.rbRingNo.Name = "rbRingNo";
            this.rbRingNo.Size = new System.Drawing.Size(50, 28);
            this.rbRingNo.TabIndex = 10;
            this.rbRingNo.TabStop = true;
            this.rbRingNo.Text = "no";
            this.rbRingNo.UseVisualStyleBackColor = true;
            // 
            // rbConvexYes
            // 
            this.rbConvexYes.AutoSize = true;
            this.rbConvexYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbConvexYes.Location = new System.Drawing.Point(283, 182);
            this.rbConvexYes.Name = "rbConvexYes";
            this.rbConvexYes.Size = new System.Drawing.Size(57, 28);
            this.rbConvexYes.TabIndex = 11;
            this.rbConvexYes.TabStop = true;
            this.rbConvexYes.Text = "yes";
            this.rbConvexYes.UseVisualStyleBackColor = true;
            // 
            // rbConvexNo
            // 
            this.rbConvexNo.AutoSize = true;
            this.rbConvexNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbConvexNo.Location = new System.Drawing.Point(413, 182);
            this.rbConvexNo.Name = "rbConvexNo";
            this.rbConvexNo.Size = new System.Drawing.Size(50, 28);
            this.rbConvexNo.TabIndex = 12;
            this.rbConvexNo.TabStop = true;
            this.rbConvexNo.Text = "no";
            this.rbConvexNo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(90, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(547, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Identify";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblResult.Location = new System.Drawing.Point(84, 329);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(114, 31);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Results:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Location = new System.Drawing.Point(44, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.Location = new System.Drawing.Point(687, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 41);
            this.button3.TabIndex = 16;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mushroom_Identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(786, 459);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbConvexNo);
            this.Controls.Add(this.rbConvexYes);
            this.Controls.Add(this.rbRingNo);
            this.Controls.Add(this.rbRingYes);
            this.Controls.Add(this.rbForestNo);
            this.Controls.Add(this.rbForestYes);
            this.Controls.Add(this.rbGillsNo);
            this.Controls.Add(this.rbGillsYes);
            this.Controls.Add(this.lblConvex);
            this.Controls.Add(this.lblRing);
            this.Controls.Add(this.lblForest);
            this.Controls.Add(this.lblGills);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Mushroom_Identification";
            this.Text = "Mushroom_Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGills;
        private System.Windows.Forms.Label lblForest;
        private System.Windows.Forms.Label lblRing;
        private System.Windows.Forms.Label lblConvex;
        private System.Windows.Forms.RadioButton rbGillsYes;
        private System.Windows.Forms.RadioButton rbGillsNo;
        private System.Windows.Forms.RadioButton rbForestYes;
        private System.Windows.Forms.RadioButton rbForestNo;
        private System.Windows.Forms.RadioButton rbRingYes;
        private System.Windows.Forms.RadioButton rbRingNo;
        private System.Windows.Forms.RadioButton rbConvexYes;
        private System.Windows.Forms.RadioButton rbConvexNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}