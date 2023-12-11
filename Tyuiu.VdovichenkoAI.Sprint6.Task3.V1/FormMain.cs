using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VdovichenkoAI.Sprint6.Task3.V1.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task3.V1
{
    public partial class FormMain_VAI : Form
    {
        public FormMain_VAI()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] array = new int[5, 5] { {25, 20, 28, 2, 6},
                                           {19, 9, 18, -7, 24},
                                           {21, 16, 5, -7, -8},
                                           {30, -13, 1, -15, 2},
                                           {31, 9, -3, -9, -18} };
        private void FormMain_VAI_Load(object sender, EventArgs e)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            dataGridViewMatrix_VAI.ColumnCount = columns;
            dataGridViewMatrix_VAI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_VAI.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_VAI.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                }
            }
        }

        private void buttonDone_VAI_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(array);

            int rows = result.GetUpperBound(0) + 1;
            int columns = result.Length / rows;

            dataGridViewMatrixResult_VAI.ColumnCount = columns;
            dataGridViewMatrixResult_VAI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_VAI.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_VAI.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }
        }

        private void buttonInfo_VAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-1 Вдовиченко Алина Игоревна", "Сообщение");
        }
    }
}
