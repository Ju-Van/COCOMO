using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COCOMO_v_1._0
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COCOMO newForm = new COCOMO();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            COCOMO_2 newForm = new COCOMO_2();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("COCOMO.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проект выполнен Лебедевым Иваном, студентом группы 448-2 кафедры АСУ ТУСУР, в рамках выполнения Лабораторной работы №1(5) по дисциплине Программная инженерия @Ju-Van");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Лицензия.docx");
        }
    }

   
}
