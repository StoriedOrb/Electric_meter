using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_meter
{
    public partial class ElectricMeter : Form
    {
        public ElectricMeter()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string BeginElec, EndElec;
            int BeginElecint, EndElecint;
            bool Right1, Right2;
            BeginElec = BeginMonth.Text;
            EndElec = EndMonth.Text;
            Right1 = int.TryParse(BeginElec, out BeginElecint);
            Right2 = int.TryParse(EndElec, out EndElecint);
            if (Right1 == true)
            {

                if (BeginElecint < 0)
                {
                    MessageBox.Show("Значение не может быть отрицательным!");

                    BeginMonth.Clear();
                    EndMonth.Clear();
                    Cost.Clear();
                    Wasted.Clear();
                }
                
                if (BeginElecint > EndElecint)
                {
                    MessageBox.Show("Показания в начале месяца не могут быть больше, чем в конце!");
                    
                    BeginMonth.Clear();
                    EndMonth.Clear();
                    Cost.Clear();
                    Wasted.Clear();
                }

            }
            else
            {
                MessageBox.Show("Значение не целое, либо в нём содержатся буквы!");

                BeginMonth.Clear();
                EndMonth.Clear();
                Cost.Clear();
                Wasted.Clear();
            }

            if (Right2 == true) 
            {
                if (EndElecint < 0)
                {
                    MessageBox.Show("Значение не может быть отрицательным!");

                    BeginMonth.Clear();
                    EndMonth.Clear();
                    Cost.Clear();
                    Wasted.Clear();
                }
            }
            else
            {
                MessageBox.Show("Значение не целое, либо в нём содержатся буквы!");

                BeginMonth.Clear();
                EndMonth.Clear();
                Cost.Clear();
                Wasted.Clear();
            }
            
            int wasted; double cost;

            wasted = EndElecint - BeginElecint;

            if (wasted < 200)
            {
                cost = wasted * 2;

                Cost.Text = cost.ToString();
            }
            if (wasted > 200)
            {
                int over;
                cost = 200 * 2;
                over = wasted - 200;
                cost = (over * 2.5) + cost;
                
                Cost.Text = cost.ToString();
            }
            Wasted.Text = wasted.ToString();
            
            






        }

        private void Clear_Click(object sender, EventArgs e)
        {
            BeginMonth.Clear();
            EndMonth.Clear();
            Wasted.Clear();
            Cost.Clear();
        }
    }
}
