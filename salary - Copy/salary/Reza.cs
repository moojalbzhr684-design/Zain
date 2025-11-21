using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salary
{
    public partial class Reza : Form
    {
        decimal Edu;
        public Reza()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                Edu = 100;
                TEdu.Text = "100";
                label9.Text = "";


            }
            else
            {
                Edu = 0;
                TEdu.Text = "0";
                checkBox3.Enabled = true;
                checkBox2.Enabled = true;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                Edu = 75;
                TEdu.Text = "75";
                label9.Text = "";

            }
            else
            {
                Edu = 0;
                TEdu.Text = "0";
                checkBox3.Enabled = true;
                checkBox1.Enabled = true;
                label9.Text = "";

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                Edu = 45;
                TEdu.Text = "45";
                label9.Text = "";

            }
            else
            {
                Edu = 0;
                TEdu.Text = "0";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ts, tr, Bo;


            if (decimal.TryParse(TBSalary.Text, out ts) &&
                decimal.TryParse(TTrAllowance.Text, out tr) &&
                decimal.TryParse(TBonuses.Text, out Bo))
            {
                label9.Text = (ts + tr + Bo + (Edu * ts) / 100).ToString();

            }
            else
            {
                MessageBox.Show(" ﻳﺮﺟﻰ إدﺧﺎل ﻗﻴﻢ ﺻﺤﻴﺤﺔ في ﺣﻘﻞ ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBSalary.Text = "";
            TTrAllowance.Text = "";
            TBonuses.Text = "";
            TEdu.Text = "";
            label9.Text = "";
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
