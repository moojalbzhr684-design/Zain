using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace salary
{
    public partial class Face : Form
    {

        public Face()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }

            string selectedName = comboBox1.SelectedItem.ToString();

            switch (selectedName)
            {
                case "Fahad Firas":
                    this.Hide(); // إخفاء الفورمة الرئيسية
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                    this.Show(); // يرجع للـ Face بعد ما يغلق Form1
                    break;

                case "Reza Hasaneen":
                    this.Hide();
                    Reza f2 = new Reza();
                    f2.ShowDialog();
                    this.Show();
                    break;

                case "Zain Alabideen Ayoub":
                    this.Hide();
                    Zain f3 = new Zain();
                    f3.ShowDialog();
                    this.Show();
                    break;

                default:
                    MessageBox.Show("لم يتم التعرف على الاختيار");
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


