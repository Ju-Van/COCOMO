using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COCOMO_v_1._0
{

    public partial class COCOMO : Form
    {
        double pm = 0.00, tm = 0.00, size = 0.00, EAF= 1.00;
        double a = 0.00, a1 = 0.00, b = 0.00, b1 = 0.00, c = 0.00, d = 0.00;
        EAF eaf = new EAF();       

        public COCOMO()
        {
            InitializeComponent();
            label21.Text = "4. Ограничение быстродействия \n при выполнении программы";
            string[] countries = { "Распространенный", "Полунезависимый", "Встроенный"};
           
            listBox1.Items.AddRange(countries);
            listBox2.Items.AddRange(countries);
        
            checkedListBox1.SetItemCheckState(2,CheckState.Checked);
            checkedListBox2.SetItemCheckState(1, CheckState.Checked);
            checkedListBox3.SetItemCheckState(2, CheckState.Checked);
            checkedListBox4.SetItemCheckState(0, CheckState.Checked);
            checkedListBox5.SetItemCheckState(0, CheckState.Checked);
            checkedListBox6.SetItemCheckState(1, CheckState.Checked);
            checkedListBox7.SetItemCheckState(1, CheckState.Checked);
            
            checkedListBox8.SetItemCheckState(2, CheckState.Checked);
            checkedListBox9.SetItemCheckState(2, CheckState.Checked);
            checkedListBox10.SetItemCheckState(2, CheckState.Checked);
            checkedListBox11.SetItemCheckState(2, CheckState.Checked);
            checkedListBox12.SetItemCheckState(2, CheckState.Checked);
            checkedListBox13.SetItemCheckState(2, CheckState.Checked);
            checkedListBox14.SetItemCheckState(2, CheckState.Checked);
            checkedListBox15.SetItemCheckState(2, CheckState.Checked);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EAF = 1.0;
            int index1 = listBox2.SelectedIndex;
            switch (index1)
            {
                case 0:
                    a1 = 3.2;
                    b1 = 1.05;
                    break;
                case 1:
                    a1 = 3.0;
                    b1 = 1.12;
                    break;
                case 2:
                    a1 = 2.8;
                    b1 = 1.20;
                    break;
            }
            textBox5.Text = "A = " + Convert.ToString(a1) + System.Environment.NewLine + "\nB = " + Convert.ToString(b1);
            int index = checkedListBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a1= 0.75;
                    break;
                case 1:
                    eaf.a1 = 0.88;
                    break;
                case 2:
                    eaf.a1 = 1.00;
                    break;
                case 3:
                    eaf.a1 = 1.15;
                    break;
                case 4:
                    eaf.a1 = 1.40;
                    break;
            }
            index = checkedListBox2.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a2 = 0.94;
                    break;
                case 1:
                    eaf.a2 = 1.00;
                    break;
                case 2:
                    eaf.a2 = 1.08;
                    break;
                case 3:
                    eaf.a2 = 1.16;
                    break;
            }
            index = checkedListBox3.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a3 = 0.70;
                    break;
                case 1:
                    eaf.a3 = 0.85;
                    break;
                case 2:
                    eaf.a3 = 1.00;
                    break;
                case 3:
                    eaf.a3 = 1.15;
                    break;
                case 4:
                    eaf.a3 = 1.30;
                    break;
                case 5:
                    eaf.a3 = 1.65;
                    break;
            }
            index = checkedListBox4.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a4 = 1.00;
                    break;
                case 1:
                    eaf.a4 = 1.11;
                    break;
                case 2:
                    eaf.a4 = 1.30;
                    break;
                case 3:
                    eaf.a4 = 1.66;
                    break;
            }
            index = checkedListBox5.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a5 = 1.00;
                    break;
                case 1:
                    eaf.a5 = 1.06;
                    break;
                case 2:
                    eaf.a5 = 1.21;
                    break;
                case 3:
                    eaf.a5 = 1.56;
                    break;
            }
            index = checkedListBox6.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a6 = 0.87;
                    break;
                case 1:
                    eaf.a6 = 1.00;
                    break;
                case 2:
                    eaf.a6 = 1.15;
                    break;
                case 3:
                    eaf.a6 = 1.30;
                    break;
            }
            index = checkedListBox7.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a7 = 0.87;
                    break;
                case 1:
                    eaf.a7 = 1.00;
                    break;
                case 2:
                    eaf.a7 = 1.07;
                    break;
                case 3:
                    eaf.a7 = 1.15;
                    break;
            }
            index = checkedListBox8.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a8 = 1.46;
                    break;
                case 1:
                    eaf.a8 = 1.19;
                    break;
                case 2:
                    eaf.a8 = 1.00;
                    break;
                case 3:
                    eaf.a8 = 0.86;
                    break;
                case 4:
                    eaf.a8 = 0.71;
                    break;
            }
            index = checkedListBox9.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a9 = 1.29;
                    break;
                case 1:
                    eaf.a9 = 1.13;
                    break;
                case 2:
                    eaf.a9 = 1.00;
                    break;
                case 3:
                    eaf.a9 = 0.91;
                    break;
                case 4:
                    eaf.a9 = 0.82;
                    break;
            }
            index = checkedListBox10.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a10 = 1.42;
                    break;
                case 1:
                    eaf.a10 = 1.17;
                    break;
                case 2:
                    eaf.a10 = 1.00;
                    break;
                case 3:
                    eaf.a10 = 0.86;
                    break;
                case 4:
                    eaf.a10 = 0.70;
                    break;
            }
            index = checkedListBox11.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a11 = 1.21;
                    break;
                case 1:
                    eaf.a11 = 1.10;
                    break;
                case 2:
                    eaf.a11 = 1.00;
                    break;
                case 3:
                    eaf.a11 = 0.9;
                    break;
            }
            index = checkedListBox12.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a12 = 1.14;
                    break;
                case 1:
                    eaf.a12 = 1.07;
                    break;
                case 2:
                    eaf.a12 = 1.00;
                    break;
                case 3:
                    eaf.a12 = 0.95;
                    break;
            }
            index = checkedListBox13.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a13 = 1.24;
                    break;
                case 1:
                    eaf.a13 = 1.10;
                    break;
                case 2:
                    eaf.a13 = 1.00;
                    break;
                case 3:
                    eaf.a13 = 0.91;
                    break;
                case 4:
                    eaf.a13 = 0.82;
                    break;
            }
            index = checkedListBox14.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a14 = 1.24;
                    break;
                case 1:
                    eaf.a14 = 1.10;
                    break;
                case 2:
                    eaf.a14 = 1.00;
                    break;
                case 3:
                    eaf.a14 = 0.91;
                    break;
                case 4:
                    eaf.a14 = 0.83;
                    break;
            }
            index = checkedListBox15.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a15 = 1.23;
                    break;
                case 1:
                    eaf.a15 = 1.08;
                    break;
                case 2:
                    eaf.a15 = 1.00;
                    break;
                case 3:
                    eaf.a15 = 1.04;
                    break;
                case 4:
                    eaf.a15 = 1.10;
                    break;
            }
            
             size = Convert.ToDouble(textBox6.Text.ToString());
           int e12 = Convert.ToInt32(size);
            double e11 = Math.Abs(size - e12);
            
            double PM = eaf.CalcEAF() * a1 * Math.Pow(size, b1);
            PM = Math.Round(PM, 2);
            string z, z1;
            tm = 2.5 * (Math.Pow(PM, d));
            tm = Math.Round(tm, 2);
            z = String.Format("{0:0.00}", PM);
            z1 = String.Format("{0:0.00}", tm);
            textBox7.Text = "Трудоёмкость (чел.× мес.) = " + z; // трудоемкость
          
            textBox8.Text = "Время разработки в календарных месяцах - " + z1;

            double pro;
            pro = eaf.a1 * eaf.a2 * eaf.a3 * eaf.a4 * eaf.a5 * eaf.a6 * eaf.a7 * eaf.a8 * eaf.a9 * eaf.a10 * eaf.a11 * eaf.a11 * eaf.a12 * eaf.a13 * eaf.a14 * eaf.a15;
            textBox9.Text = "Произведение показателей = " + Convert.ToString(pro);
            double sum;
            sum = eaf.a1 + eaf.a2 + eaf.a3 + eaf.a4 + eaf.a5 + eaf.a6 + eaf.a7 + eaf.a8 + eaf.a9 + eaf.a10 + eaf.a11 + eaf.a11 + eaf.a12 + eaf.a13 + eaf.a14 + eaf.a15;
            textBox10.Text = "Сумма показателей = " + Convert.ToString(sum);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {             
        }

        private void checkedListBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            COCOMO_2 newForm = new COCOMO_2();
            newForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    a = 2.4;
                    b = 1.05;
                    c = 2.5;
                    d = 0.38;
                    break;
                case 1:
                    a = 3.0;
                    b = 1.12;
                    c = 2.5;
                    d = 0.35;
                    break;
                case 2:
                    a = 3.6;
                    b = 1.20;
                    c = 2.5;
                    d = 0.32;
                    break;
            }
            textBox1.Text = "A = " + Convert.ToString(a) + System.Environment.NewLine + "B = " + Convert.ToString(b) + System.Environment.NewLine + "C = " + Convert.ToString(c) + System.Environment.NewLine + "D = " + Convert.ToString(d);
        
        size = Convert.ToDouble(textBox2.Text.ToString());
            int e12 = Convert.ToInt32(size);
            double e11 = Math.Abs(size - e12);
          
            pm = a * Math.Pow(size, b);
            pm = Math.Round(pm, 2, MidpointRounding.AwayFromZero);
            tm = c * pm;
            tm = Math.Round(tm, 2, MidpointRounding.AwayFromZero);
            string x, x1;
            x = String.Format("{0:0.00}", pm);
            x1 = String.Format("{0:0.00}", tm);
            
            
            textBox3.Text = "Трудоемкость (чел.× мес.) = " + Convert.ToString(pm) + "\n ";// + "Bремя разработки в календарных месяцах" + Convert.ToString(b);
            textBox4.Text = "Bремя разработки в календарных месяцах  = " + Convert.ToString(tm);
        }
    }
}
