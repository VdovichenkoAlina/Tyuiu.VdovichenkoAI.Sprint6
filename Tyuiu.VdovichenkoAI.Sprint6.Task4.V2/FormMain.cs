using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.VdovichenkoAI.Sprint6.Task4.V2.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task4.V2
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

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_VAI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VAI.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPutData_VAI.Text = "";

                chartFunction_VAI.Series[0].Points.Clear();
                for (int i = 0; i < len; i++, startStep++)
                {
                    this.chartFunction_VAI.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPutData_VAI.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_VAI_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V2.txt";
                File.WriteAllText(path, textBoxOutPutData_VAI.Text);

                DialogResult dialogResult = MessageBox.Show(this, $"Файл {path} сохранён успешно!\n Открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    //System.Diagnostics.Process.Start( path );
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_VAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-1 Вдовиченко Алина Игоревна", "Сообщение");
        }
    }
}
