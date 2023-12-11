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
using Tyuiu.VdovichenkoAI.Sprint6.Task5.V29.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task5.V29
{
    public partial class FormMain_VAI : Form
    {
        public FormMain_VAI()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Администратор\source\repos\Tyuiu.VdovichenkoAI.Sprint6\Tyuiu.VdovichenkoAI.Sprint6.Task5.V29\bin\Debug\InPutFileTask5V29.txt";
        private void buttonDone_VAI_Click(object sender, EventArgs e)
        {
            dataGridViewNums_VAI.ColumnCount = 2;
            dataGridViewNums_VAI.Columns[0].Width = 20;
            dataGridViewNums_VAI.Columns[1].Width = 50;

            this.chart_VAI.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart_VAI.ChartAreas[0].AxisY.Title = "Ось Y";

            chart_VAI.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_VAI.Rows.Add(i.ToString(), numsMass[i].ToString());
                chart_VAI.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_VAI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_VAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-23-1 Вдовиченко Алина Игоревна", "Сообщение");
        }
    }
}

