namespace salary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            TBSalary = new TextBox();
            TTrAllowance = new TextBox();
            TBonuses = new TextBox();
            TEdu = new TextBox();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(152, 35);
            label2.TabIndex = 1;
            label2.Text = "B.Salary";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 215);
            label3.Name = "label3";
            label3.Size = new Size(152, 35);
            label3.TabIndex = 2;
            label3.Text = "Tr. Allowance";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 265);
            label4.Name = "label4";
            label4.Size = new Size(152, 35);
            label4.TabIndex = 3;
            label4.Text = "Bonuses";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(409, 59);
            label5.TabIndex = 4;
            label5.Text = "Employee Name: Fahad Firas";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 66);
            label6.Name = "label6";
            label6.Size = new Size(273, 43);
            label6.TabIndex = 5;
            label6.Text = "Employee ID :193748";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(639, 168);
            label7.Name = "label7";
            label7.Size = new Size(160, 35);
            label7.TabIndex = 6;
            label7.Text = "Edu Allowance";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(-22, 475);
            label8.Name = "label8";
            label8.Size = new Size(344, 72);
            label8.TabIndex = 7;
            label8.Text = "Net Salary is :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(289, 472);
            label9.Name = "label9";
            label9.Size = new Size(278, 72);
            label9.TabIndex = 8;
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._965bf0ffaa83d1a76d7bcaf9c30c9436;
            pictureBox1.Location = new Point(637, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // TBSalary
            // 
            TBSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBSalary.Location = new Point(142, 168);
            TBSalary.Multiline = true;
            TBSalary.Name = "TBSalary";
            TBSalary.Size = new Size(143, 34);
            TBSalary.TabIndex = 10;
            TBSalary.Text = "0";
            TBSalary.TextAlign = HorizontalAlignment.Center;
            TBSalary.TextChanged += TBSalary_TextChanged;
            // 
            // TTrAllowance
            // 
            TTrAllowance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TTrAllowance.Location = new Point(142, 216);
            TTrAllowance.Multiline = true;
            TTrAllowance.Name = "TTrAllowance";
            TTrAllowance.Size = new Size(143, 34);
            TTrAllowance.TabIndex = 11;
            TTrAllowance.Text = "0";
            TTrAllowance.TextAlign = HorizontalAlignment.Center;
            // 
            // TBonuses
            // 
            TBonuses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBonuses.Location = new Point(142, 266);
            TBonuses.Multiline = true;
            TBonuses.Name = "TBonuses";
            TBonuses.Size = new Size(143, 34);
            TBonuses.TabIndex = 12;
            TBonuses.Text = "0";
            TBonuses.TextAlign = HorizontalAlignment.Center;
            TBonuses.TextChanged += TBonuses_TextChanged;
            // 
            // TEdu
            // 
            TEdu.BackColor = Color.PeachPuff;
            TEdu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TEdu.ForeColor = SystemColors.Window;
            TEdu.Location = new Point(639, 204);
            TEdu.Multiline = true;
            TEdu.Name = "TEdu";
            TEdu.Size = new Size(143, 34);
            TEdu.TabIndex = 13;
            TEdu.TextAlign = HorizontalAlignment.Center;
            TEdu.TextChanged += TEdu_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(659, 407);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 14;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(659, 475);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 15;
            button2.Text = "Restart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(675, 244);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "PhD";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = SystemColors.ControlLightLight;
            checkBox2.Location = new Point(675, 269);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 19);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Master's";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox3.ForeColor = SystemColors.ControlLightLight;
            checkBox3.Location = new Point(675, 293);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 18;
            checkBox3.Text = "Bachelor's";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(659, 341);
            button3.Name = "button3";
            button3.Size = new Size(123, 40);
            button3.TabIndex = 19;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.صورة_واتFF;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 552);
            Controls.Add(button3);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TEdu);
            Controls.Add(TBonuses);
            Controls.Add(TTrAllowance);
            Controls.Add(TBSalary);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private TextBox TBSalary;
        private TextBox TTrAllowance;
        private TextBox TBonuses;
        private TextBox TEdu;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button3;
    }
}
