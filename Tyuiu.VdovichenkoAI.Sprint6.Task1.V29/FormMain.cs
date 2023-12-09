using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VdovichenkoAI.Sprint6.Task1.V29.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task1.V29
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
                int startValue = Convert.ToInt32(textBoxStart_VAI.Text);
                int stopValue = Convert.ToInt32(textBoxFinal_VAI.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_VAI.Text = "";
                textBoxResult_VAI.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_VAI.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_VAI.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}  |", startValue, valueArray[i]);
                    textBoxResult_VAI.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_VAI.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_VAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-23-1 Вдовиченко Алина Игоревна", "Сообщение");
        }
    }
}
