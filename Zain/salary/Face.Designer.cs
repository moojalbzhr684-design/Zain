namespace salary
{
    partial class Face
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Fahad Firas", "Reza Hasaneen", "Zain Alabideen Ayoub" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fahad Firas", "Reza Hasaneen", "Zain Alabideen Ayoub" });
            comboBox1.Location = new Point(510, 704);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PeachPuff;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.SaddleBrown;
            textBox1.Location = new Point(542, 636);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 32);
            textBox1.TabIndex = 1;
            textBox1.Text = "Employees Page";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Face
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.صورة_واتFF;
            ClientSize = new Size(1187, 1011);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Face";
            Text = "Face";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}