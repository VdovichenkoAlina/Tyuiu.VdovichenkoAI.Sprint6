using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VdovichenkoAI.Sprint6.Task2.V17.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task2.V17
{
    public partial class FormMain_VAI : Form
    {
        public FormMain_VAI()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_VAI_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_VAI.Text);
                int stopStep = Convert.ToInt32(textBoxFinal_VAI.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;


                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_VAI.Titles.Add("График функции");

                this.chartFunction_VAI.ChartAreas[0].AxisX.Title = "Ось X";

                this.chartFunction_VAI.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_VAI.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_VAI.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_VAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-1 Вдовиченко Алина Игоревна", "Сообщение");
        }

        private void buttonDone_VAI_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_VAI.BackColor = Color.Red;
        }

        private void buttonDone_VAI_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_VAI.BackColor = Color.ForestGreen;
        }

        private void buttonDone_VAI_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_VAI.BackColor = Color.Blue;
        }
    }
}
