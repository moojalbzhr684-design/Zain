namespace salary
{
    partial class Zain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zain));
            button3 = new Button();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            TEdu = new TextBox();
            TBonuses = new TextBox();
            TTrAllowance = new TextBox();
            TBSalary = new TextBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(659, 319);
            button3.Name = "button3";
            button3.Size = new Size(123, 40);
            button3.TabIndex = 38;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = SystemColors.ActiveCaptionText;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox3.ForeColor = SystemColors.ControlLightLight;
            checkBox3.Location = new Point(675, 294);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 37;
            checkBox3.Text = "Bachelor's";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = SystemColors.ActiveCaptionText;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = SystemColors.ControlLightLight;
            checkBox2.Location = new Point(675, 270);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 19);
            checkBox2.TabIndex = 36;
            checkBox2.Text = "Master's";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveCaptionText;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(675, 245);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 19);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "PhD";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(659, 405);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 34;
            button2.Text = "Restart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(659, 365);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 33;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TEdu
            // 
            TEdu.BackColor = SystemColors.MenuText;
            TEdu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TEdu.ForeColor = SystemColors.Window;
            TEdu.Location = new Point(639, 205);
            TEdu.Multiline = true;
            TEdu.Name = "TEdu";
            TEdu.Size = new Size(143, 34);
            TEdu.TabIndex = 32;
            TEdu.TextAlign = HorizontalAlignment.Center;
            TEdu.TextChanged += TEdu_TextChanged;
            // 
            // TBonuses
            // 
            TBonuses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBonuses.Location = new Point(181, 267);
            TBonuses.Multiline = true;
            TBonuses.Name = "TBonuses";
            TBonuses.Size = new Size(143, 34);
            TBonuses.TabIndex = 31;
            TBonuses.Text = "0";
            TBonuses.TextAlign = HorizontalAlignment.Center;
            // 
            // TTrAllowance
            // 
            TTrAllowance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TTrAllowance.Location = new Point(181, 216);
            TTrAllowance.Multiline = true;
            TTrAllowance.Name = "TTrAllowance";
            TTrAllowance.Size = new Size(143, 34);
            TTrAllowance.TabIndex = 30;
            TTrAllowance.Text = "0";
            TTrAllowance.TextAlign = HorizontalAlignment.Center;
            // 
            // TBSalary
            // 
            TBSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TBSalary.Location = new Point(181, 167);
            TBSalary.Multiline = true;
            TBSalary.Name = "TBSalary";
            TBSalary.Size = new Size(143, 34);
            TBSalary.TabIndex = 29;
            TBSalary.Text = "0";
            TBSalary.TextAlign = HorizontalAlignment.Center;
            TBSalary.TextChanged += TBSalary_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(637, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(340, 370);
            label9.Name = "label9";
            label9.Size = new Size(278, 72);
            label9.TabIndex = 27;
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(2, 370);
            label8.Name = "label8";
            label8.Size = new Size(344, 72);
            label8.TabIndex = 26;
            label8.Text = "Net Salary is :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(639, 169);
            label7.Name = "label7";
            label7.Size = new Size(160, 35);
            label7.TabIndex = 25;
            label7.Text = "Edu Allowance";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 67);
            label6.Name = "label6";
            label6.Size = new Size(273, 43);
            label6.TabIndex = 24;
            label6.Text = "Employee ID :274859";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(12, 10);
            label5.Name = "label5";
            label5.Size = new Size(409, 59);
            label5.TabIndex = 23;
            label5.Text = "Employee Name: Zain Alanideen";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 266);
            label4.Name = "label4";
            label4.Size = new Size(152, 35);
            label4.TabIndex = 22;
            label4.Text = "Bonuses";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(152, 35);
            label3.TabIndex = 21;
            label3.Text = "Tr. Allowance";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(152, 35);
            label2.TabIndex = 20;
            label2.Text = "B.Salary";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Zain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.b0f2acb61b9a6546287fe63b1405e9d62;
            ClientSize = new Size(800, 450);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Zain";
            Text = "Zain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button2;
        private Button button1;
        private TextBox TEdu;
        private TextBox TBonuses;
        private TextBox TTrAllowance;
        private TextBox TBSalary;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}