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
    public partial class COCOMO_2 : Form
    {
        double SF = 1, c = 3.67, d = 0.28, pm = 1, b = 0.91, TM = 1, size = 1, EAF = 1, sced = 1, ee = 1, a1 = 2.94, a2 = 2.45;
        EAF eaf = new EAF();
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox2.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox2.SetItemChecked(ix, false);
        }
        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox3.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox3.SetItemChecked(ix, false);
        }
        private void checkedListBox4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox4.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox4.SetItemChecked(ix, false);
        }
        private void checkedListBox5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox5.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox5.SetItemChecked(ix, false);
        }
        private void checkedListBox6_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox6.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox6.SetItemChecked(ix, false);
        }
        private void checkedListBox7_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox7.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox7.SetItemChecked(ix, false);
        }
        private void checkedListBox8_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox8.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox8.SetItemChecked(ix, false);
        }
        private void checkedListBox9_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox9.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox9.SetItemChecked(ix, false);
        }
        private void checkedListBox10_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox10.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox10.SetItemChecked(ix, false);
        }
        private void checkedListBox11_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox11.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox11.SetItemChecked(ix, false);
        }
        private void checkedListBox12_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox12.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox12.SetItemChecked(ix, false);
        }
        private void checkedListBox13_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox13.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox13.SetItemChecked(ix, false);
        }
        private void checkedListBox14_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox14.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox14.SetItemChecked(ix, false);
        }
        private void checkedListBox15_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox15.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox15.SetItemChecked(ix, false);
        }
        private void checkedListBox16_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox16.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox16.SetItemChecked(ix, false);
        }
        private void checkedListBox17_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox17.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox17.SetItemChecked(ix, false);
        }
        private void checkedListBox18_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox18.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox18.SetItemChecked(ix, false);
        }
        private void checkedListBox19_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox19.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox19.SetItemChecked(ix, false);
        }
        private void checkedListBox20_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox20.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox20.SetItemChecked(ix, false);
        }
        private void checkedListBox21_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox21.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox21.SetItemChecked(ix, false);
        }
        private void checkedListBox22_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox22.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox22.SetItemChecked(ix, false);
        }
        private void checkedListBox23_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox23.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox23.SetItemChecked(ix, false);
        }
        private void checkedListBox24_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox24.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox24.SetItemChecked(ix, false);
        }
        private void checkedListBox25_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox25.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox25.SetItemChecked(ix, false);
        }
        private void checkedListBox26_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox26.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox26.SetItemChecked(ix, false);
        }
        private void checkedListBox27_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox27.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox27.SetItemChecked(ix, false);
        }
        private void checkedListBox28_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox28.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox28.SetItemChecked(ix, false);
        }
        private void checkedListBox29_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox29.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox29.SetItemChecked(ix, false);
        }
        private void checkedListBox30_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox30.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox30.SetItemChecked(ix, false);
        }
        private void checkedListBox31_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox31.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox31.SetItemChecked(ix, false);
        }
        private void checkedListBox32_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox32.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox32.SetItemChecked(ix, false);
        }
        private void checkedListBox33_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox33.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox33.SetItemChecked(ix, false);
        }
        private void checkedListBox34_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox34.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox34.SetItemChecked(ix, false);
        }
        private void button1_Click(object sender, EventArgs e) // предварительная
        {
            // используем первые 5 переменных
            int index = checkedListBox4.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a1 = 6.2;
                    break;
                case 1:
                    eaf.a1 =4.96;
                    break;
                case 2:
                    eaf.a1 = 3.72;
                    break;
                case 3:
                    eaf.a1 = 2.48;
                    break;
                case 4:
                    eaf.a1 = 1.24;
                    break;
                case 5:
                    eaf.a1 = 0;
                    break;
            }
            index = checkedListBox5.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a2 = 5.07;
                    break;
                case 1:
                    eaf.a2 = 4.05;
                    break;
                case 2:
                    eaf.a2 = 3.04;
                    break;
                case 3:
                    eaf.a2 = 2.03;
                    break;
                case 4:
                    eaf.a2 = 1.01;
                    break;
                case 5:
                    eaf.a2 = 0;
                    break;
            }
            index = checkedListBox6.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a3 = 7.07;
                    break;
                case 1:
                    eaf.a3 =5.65;
                    break;
                case 2:
                    eaf.a3 = 4.24;
                    break;
                case 3:
                    eaf.a3 = 2.83;
                    break;
                case 4:
                    eaf.a3 = 1.41;
                    break;
                case 5:
                    eaf.a3 = 0;
                    break;
            }
            index = checkedListBox7.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a4 = 5.48;
                    break;
                case 1:
                    eaf.a4 = 4.38;
                    break;
                case 2:
                    eaf.a4 = 3.29;
                    break;
                case 3:
                    eaf.a4 = 2.19;
                    break;
                case 4:
                    eaf.a4 = 1.1;
                    break;
                case 5:
                    eaf.a4 = 0;
                    break;
            }
            index = checkedListBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a5 = 7.8;
                    break;
                case 1:
                    eaf.a5 = 6.24;
                    break;
                case 2:
                    eaf.a5 = 4.68;
                    break;
                case 3:
                    eaf.a5 = 3.12;
                    break;
                case 4:
                    eaf.a5 = 1.56;
                    break;
                case 5:
                    eaf.a5 = 0;
                    break;
            }
            double ec, ec1;
            ec = 0.91 + 0.1 * eaf.a1 + eaf.a2 * 0.1 + eaf.a3 * 0.1 + eaf.a4 * 0.1 + eaf.a5 * 01;
            ec1 = eaf.a1 + eaf.a2 + eaf.a3 + eaf.a4 + eaf.a5;

            int index1 = checkedListBox8.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a1 = 2.12;
                    break;
                case 1:
                    eaf.a1 = 1.62;
                    break;
                case 2:
                    eaf.a1 = 1.26;
                    break;
                case 3:
                    eaf.a1 = 1;
                    break;
                case 4:
                    eaf.a1 = 0.83;
                    break;
                case 5:
                    eaf.a1 = 0.63;
                    break;
                case 6:
                    eaf.a1 = 0.5;
                    break;
            }
            index1 = checkedListBox2.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a2 = 1.59;
                    break;
                case 1:
                    eaf.a2 = 1.33;
                    break;
                case 2:
                    eaf.a2 = 1.22;
                    break;
                case 3:
                    eaf.a2 = 1;
                    break;
                case 4:
                    eaf.a2 = 0.87;
                    break;
                case 5:
                    eaf.a2 = 0.74;
                    break;
                case 6:
                    eaf.a2 = 0.62;
                    break;
            }
            index1 = checkedListBox3.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a3 = 0.49;
                    break;
                case 1:
                    eaf.a3 = 0.6;
                    break;
                case 2:
                    eaf.a3 = 0.83;
                    break;
                case 3:
                    eaf.a3 = 1;
                    break;
                case 4:
                    eaf.a3 = 1.33;
                    break;
                case 5:
                    eaf.a3 = 1.91;
                    break;
                case 6:
                    eaf.a3 = 2.72;
                    break;
            }
            index1 = checkedListBox19.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a4 = 0.95;
                    break;
                case 1:
                    eaf.a4 = 1;
                    break;
                case 2:
                    eaf.a4 = 1.07;
                    break;
                case 3:
                    eaf.a4 = 1.15;
                    break;
                case 4:
                    eaf.a4 = 1.24;
                    break;
                
            }
            index1 = checkedListBox18.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a5 =0.87;
                    break;
                case 1:
                    eaf.a5 = 1;
                    break;
                case 2:
                    eaf.a5 = 1.29;
                    break;
                case 3:
                    eaf.a5 = 1.81;
                    break;
                case 4:
                    eaf.a5 = 2.61;
                    break;
                
            }
            index1 = checkedListBox17.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a6 = 1.43;
                    break;
                case 1:
                    eaf.a6 = 1.3;
                    break;
                case 2:
                    eaf.a6 = 1.1;
                    break;
                case 3:
                    eaf.a6 = 1;
                    break;
                case 4:
                    eaf.a6 = 0.87;
                    break;
                case 5:
                    eaf.a6 = 0.73;
                    break;
                case 6:
                    eaf.a6 = 0.62;
                    break;
            }
            index1 = checkedListBox16.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a7 = 1.43;
                    break;
                case 1:
                    eaf.a7 = 1.14;
                    break;
                case 2:
                    eaf.a7 = 1;
                    break;
                case 3:
                    eaf.a7 = 1;
                    break;
                
            }
            double ef = eaf.a1 * eaf.a2 * eaf.a3 * eaf.a4 * eaf.a5 * eaf.a6 * eaf.a7;
            double efns = eaf.a1 * eaf.a2 * eaf.a3 * eaf.a4 * eaf.a5 * eaf.a6;
            sced = eaf.a7;
            size = Convert.ToDouble(textBox1.Text.ToString());
            pm = ef * a1 * Math.Pow(size, ec);
            pm = Math.Round(pm, 2, MidpointRounding.AwayFromZero);
            double r = d + 0.2 * (ee - b);
            textBox8.Text = "Трудоемкость (чел.×мес.) = " + Convert.ToString(pm);
            double pmns = efns * a1 * Math.Pow(size, ec);
            pmns = Math.Round(pmns, 2, MidpointRounding.AwayFromZero);
            TM = sced * c * Math.Pow(pmns, r);
            TM = Math.Round(TM, 2, MidpointRounding.AwayFromZero);
            textBox9.Text = "Bремя разработки в календарных месяцах  = " + Convert.ToString(TM);

            double pro;
            pro = ef;
            textBox2.Text = "Произведение множителей трудоемкости = " + Convert.ToString(pro);

            double sum;
            sum = ec1;
            textBox3.Text = "Сумма факторов масштаба = " + Convert.ToString(sum);
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e) // детальная 
        {
            
            size = Convert.ToDouble(textBox4.Text.ToString());
            int index = checkedListBox34.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a1 = 6.2;
                    break;
                case 1:
                    eaf.a1 = 4.96;
                    break;
                case 2:
                    eaf.a1 = 3.72;
                    break;
                case 3:
                    eaf.a1 = 2.48;
                    break;
                case 4:
                    eaf.a1 = 1.24;
                    break;
                case 5:
                    eaf.a1 = 0;
                    break;
            }
            index = checkedListBox33.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a2 = 5.07;
                    break;
                case 1:
                    eaf.a2 = 4.05;
                    break;
                case 2:
                    eaf.a2 = 3.04;
                    break;
                case 3:
                    eaf.a2 = 2.03;
                    break;
                case 4:
                    eaf.a2 = 1.01;
                    break;
                case 5:
                    eaf.a2 = 0;
                    break;
            }
            index = checkedListBox32.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a3 = 7.07;
                    break;
                case 1:
                    eaf.a3 = 5.65;
                    break;
                case 2:
                    eaf.a3 = 4.24;
                    break;
                case 3:
                    eaf.a3 = 2.83;
                    break;
                case 4:
                    eaf.a3 = 1.41;
                    break;
                case 5:
                    eaf.a3 = 0;
                    break;
            }
            index = checkedListBox31.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a4 = 5.48;
                    break;
                case 1:
                    eaf.a4 = 4.38;
                    break;
                case 2:
                    eaf.a4 = 3.29;
                    break;
                case 3:
                    eaf.a4 = 2.19;
                    break;
                case 4:
                    eaf.a4 = 1.1;
                    break;
                case 5:
                    eaf.a4 = 0;
                    break;
            }
            index = checkedListBox30.SelectedIndex;
            switch (index)
            {
                case 0:
                    eaf.a5 = 7.8;
                    break;
                case 1:
                    eaf.a5 = 6.24;
                    break;
                case 2:
                    eaf.a5 = 4.68;
                    break;
                case 3:
                    eaf.a5 = 3.12;
                    break;
                case 4:
                    eaf.a5 = 1.56;
                    break;
                case 5:
                    eaf.a5 = 0;
                    break;
            }
            double ec, ec1;
            ec = 0.91 + 0.1 * eaf.a1 + eaf.a2 * 0.1 + eaf.a3 * 0.1 + eaf.a4 * 0.1 + eaf.a5 * 01;
            ec1 = eaf.a1 + eaf.a2 + eaf.a3 + eaf.a4 + eaf.a5;

            int index1 = checkedListBox11.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a1 = 1.42;
                    break;
                case 1:
                    eaf.a1 = 1.29;
                    break;
                case 2:
                    eaf.a1 = 1;
                    break;
                case 3:
                    eaf.a1 = 0.85;
                    break;
                case 4:
                    eaf.a1 = 0.71;
                    break;
                
            }
            index1 = checkedListBox10.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a2 = 1.22;
                    break;
                case 1:
                    eaf.a2 = 1.1;
                    break;
                case 2:
                    eaf.a2 = 1;
                    break;
                case 3:
                    eaf.a2 = 0.88;
                    break;
                case 4:
                    eaf.a2 = 0.81;
                    break;
                
            }
            index1 = checkedListBox9.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a3 = 1.34;
                    break;
                case 1:
                    eaf.a3 = 1.15;
                    break;
                case 2:
                    eaf.a3 = 1;
                    break;
                case 3:
                    eaf.a3 = 0.88;
                    break;
                case 4:
                    eaf.a3 = 0.76;
                    break;
                
            }
            index1 = checkedListBox27.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a4 = 1.29;
                    break;
                case 1:
                    eaf.a4 = 1.12;
                    break;
                case 2:
                    eaf.a4 = 1;
                    break;
                case 3:
                    eaf.a4 = 0.9;
                    break;
                case 4:
                    eaf.a4 = 0.81;
                    break;

            }
            index1 = checkedListBox26.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a5 = 1.19;
                    break;
                case 1:
                    eaf.a5 = 1.09;
                    break;
                case 2:
                    eaf.a5 = 1;
                    break;
                case 3:
                    eaf.a5 = 0.91;
                    break;
                case 4:
                    eaf.a5 = 0.85;
                    break;

            }
            index1 = checkedListBox25.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a6 = 1.2;
                    break;
                case 1:
                    eaf.a6 = 1.09;
                    break;
                case 2:
                    eaf.a6 = 1;
                    break;
                case 3:
                    eaf.a6 = 0.91;
                    break;
                case 4:
                    eaf.a6 = 0.84;
                    break;
               
            }
            index1 = checkedListBox23.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a7 = 0.84;
                    break;
                case 1:
                    eaf.a7 = 0.92;
                    break;
                case 2:
                    eaf.a7 = 1;
                    break;
                case 3:
                    eaf.a7 = 1.1;
                    break;
                case 4:
                    eaf.a7 = 1.26;
                    break;
                

            }
            index1 = checkedListBox22.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a8 = 0.23;
                    break;
                case 1:
                    eaf.a8 = 1;
                    break;
                case 2:
                    eaf.a8 = 1.14;
                    break;
                case 3:
                    eaf.a8 = 1.28;
                    break;
                

            }
            index1 = checkedListBox21.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a9 = 0.73;
                    break;
                case 1:
                    eaf.a9 = 0.87;
                    break;
                case 2:
                    eaf.a9 = 1;
                    break;
                case 3:
                    eaf.a9 = 1.17;
                    break;
                case 4:
                    eaf.a9 = 1.34;
                    break;
                case 5:
                    eaf.a9 = 1.74;
                    break;
               

            }
            index1 = checkedListBox20.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a10 = 0.95;
                    break;
                case 1:
                    eaf.a10 = 1;
                    break;
                case 2:
                    eaf.a10 = 1.07;
                    break;
                case 3:
                    eaf.a10 = 1.15;
                    break;
                case 4:
                    eaf.a10 = 1.24;
                    break;
                

            }
            index1 = checkedListBox12.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a11 = 0.81;
                    break;
                case 1:
                    eaf.a11 = 0.91;
                    break;
                case 2:
                    eaf.a11 = 1;
                    break;
                case 3:
                    eaf.a11 = 1.11;
                    break;
                case 4:
                    eaf.a11 = 1.23;
                    break;
                

            }
            index1 = checkedListBox24.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a12 = 1;
                    break;
                case 1:
                    eaf.a12 = 1.11;
                    break;
                case 2:
                    eaf.a12 = 1.29;
                    break;
                case 3:
                    eaf.a12 = 1.63;
                    break;
               
            }
            index1 = checkedListBox28.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a13 = 1;
                    break;
                case 1:
                    eaf.a13 = 1.05;
                    break;
                case 2:
                    eaf.a13 = 1.17;
                    break;
                case 3:
                    eaf.a13 = 1.46;
                    break;
                
            }
            index1 = checkedListBox29.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a14 = 0.87;
                    break;
                case 1:
                    eaf.a14 = 1;
                    break;
                case 2:
                    eaf.a14 = 1.15;
                    break;
                case 3:
                    eaf.a14 = 1.3;
                    break;
                
            }
            index1 = checkedListBox13.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a15 = 1.17;
                    break;
                case 1:
                    eaf.a15 = 1.09;
                    break;
                case 2:
                    eaf.a15 = 1;
                    break;
                case 3:
                    eaf.a15 = 0.9;
                    break;
                case 4:
                    eaf.a15 = 0.78;
                    break;
               
            }
            index1 = checkedListBox14.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a16 = 1.22;
                    break;
                case 1:
                    eaf.a16 = 1.09;
                    break;
                case 2:
                    eaf.a16 = 1;
                    break;
                case 3:
                    eaf.a16 = 0.93;
                    break;
                case 4:
                    eaf.a16 = 0.86;
                    break;
                case 5:
                    eaf.a16 = 0.8;
                    break;
                
            }
            index1 = checkedListBox15.SelectedIndex;
            switch (index1)
            {
                case 0:
                    eaf.a17 = 1.43;
                    break;
                case 1:
                    eaf.a17 = 1.14;
                    break;
                case 2:
                    eaf.a17 = 1;
                    break;
                case 3:
                    eaf.a17 = 1;
                    break;
                case 4:
                    eaf.a17 =1;
                    break;
                
            }
            sced = eaf.a17;
            double ef = eaf.a1 * eaf.a2 * eaf.a3 * eaf.a4 * eaf.a5 * eaf.a6 * eaf.a7 * eaf.a8 * eaf.a9 * eaf.a10 * eaf.a11 * eaf.a11 * eaf.a12 * eaf.a13 * eaf.a14 * eaf.a15 * eaf.a16 * eaf.a17;
            double efns = eaf.a1 * eaf.a2 * eaf.a3 * eaf.a4 * eaf.a5 * eaf.a6 * eaf.a7 * eaf.a8 * eaf.a9 * eaf.a10 * eaf.a11 * eaf.a11 * eaf.a12 * eaf.a13 * eaf.a14 * eaf.a15 * eaf.a16;

            pm = ef * a2 * Math.Pow(size, ec);
            pm = Math.Round(pm, 2, MidpointRounding.AwayFromZero);
            textBox11.Text = "Трудоемкость (чел.× мес.) = " + Convert.ToString(pm);

            double r = d + 0.2 * (ee - b);
            double pmns = efns * a1 * Math.Pow(size, ec);
            TM = sced * c * Math.Pow(pmns, r);
            TM = Math.Round(TM, 2, MidpointRounding.AwayFromZero);
            textBox12.Text = "Bремя разработки в календарных месяцах  = " + Convert.ToString(TM);

            textBox5.Text = "Произведение множителей трудоемкости = " + Convert.ToString(ef);

            double sum;
            sum = ec1;
            textBox6.Text = "Сумма факторов масштаба = " + Convert.ToString(sum);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double pro;
            pro = 1 * 1 * 1 * 1 * 1 * 1 * 1;
            textBox2.Text = "Произведение множителей трудоемкости = " + Convert.ToString(pro);
           
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            COCOMO newForm = new COCOMO();
            newForm.Show();
            this.Close();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public COCOMO_2()
        {
            InitializeComponent();
            string[] countries = { "Очень низкий", "Низкий", "Средний", "Высокий", "Очень высокий", "Критический"};
            //listBox2.Items.AddRange(countries);
            //listBox4.Items.AddRange(countries);
            string[] rr = { "Экстремально низкий", "Очень низкий", "Низкий", "Средний", "Высокий", "Очень высокий", "Критический" };
            //listBox3.Items.AddRange(countries);
            string[] rrr = { "Экстремально низкий", "Очень низкий", "Низкий", "Средний", "Высокий", "Очень высокий", "Критический" };
            //listBox1.Items.AddRange(countries);

            checkedListBox1.SetItemCheckState(2, CheckState.Checked);
            checkedListBox2.SetItemCheckState(3, CheckState.Checked);
            checkedListBox3.SetItemCheckState(3, CheckState.Checked);
            checkedListBox4.SetItemCheckState(2, CheckState.Checked);
            checkedListBox5.SetItemCheckState(2, CheckState.Checked);
            checkedListBox6.SetItemCheckState(2, CheckState.Checked);
            checkedListBox7.SetItemCheckState(2, CheckState.Checked);
            
            checkedListBox8.SetItemCheckState(3, CheckState.Checked);
            checkedListBox9.SetItemCheckState(2, CheckState.Checked);
            checkedListBox10.SetItemCheckState(1, CheckState.Checked);
            checkedListBox11.SetItemCheckState(4, CheckState.Checked);
            checkedListBox12.SetItemCheckState(2, CheckState.Checked);
            checkedListBox13.SetItemCheckState(2, CheckState.Checked);
            checkedListBox14.SetItemCheckState(2, CheckState.Checked);
            checkedListBox15.SetItemCheckState(2, CheckState.Checked);
            checkedListBox16.SetItemCheckState(2, CheckState.Checked);
            checkedListBox17.SetItemCheckState(3, CheckState.Checked);
            checkedListBox18.SetItemCheckState(1, CheckState.Checked);
            checkedListBox19.SetItemCheckState(1, CheckState.Checked);
            checkedListBox20.SetItemCheckState(2, CheckState.Checked);
            checkedListBox21.SetItemCheckState(2, CheckState.Checked);
            checkedListBox22.SetItemCheckState(2, CheckState.Checked);
            checkedListBox23.SetItemCheckState(2, CheckState.Checked);
            checkedListBox24.SetItemCheckState(1, CheckState.Checked);
            checkedListBox25.SetItemCheckState(1, CheckState.Checked);
            checkedListBox26.SetItemCheckState(0, CheckState.Checked);
            checkedListBox27.SetItemCheckState(0, CheckState.Checked);
            checkedListBox28.SetItemCheckState(1, CheckState.Checked);
            checkedListBox29.SetItemCheckState(1, CheckState.Checked);
            checkedListBox30.SetItemCheckState(2, CheckState.Checked);
            
            checkedListBox31.SetItemCheckState(2, CheckState.Checked);
            checkedListBox32.SetItemCheckState(2, CheckState.Checked);
            checkedListBox33.SetItemCheckState(2, CheckState.Checked);
            checkedListBox34.SetItemCheckState(2, CheckState.Checked);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = Convert.ToDouble(textBox1.Text.ToString());
            pm = EAF * a2 * Math.Pow(size, ee);
            pm = Math.Round(pm, 2, MidpointRounding.AwayFromZero);
            textBox11.Text = "Трудоемкость (чел.× мес.) = " + Convert.ToString(pm);
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ee = b + 0.01 * SF;
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ee = b + 0.01 * SF;
        }

        
    }
}
