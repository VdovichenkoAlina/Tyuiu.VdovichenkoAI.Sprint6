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
using Tyuiu.VdovichenkoAI.Sprint6.Task7.V13.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task7.V13
{
    public partial class FormMain_VAI : Form
    {
        public FormMain_VAI()
        {
            InitializeComponent();
            openFileDialogTask7_VAI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_VAI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        private void buttonOpenFile_VAI_Click(object sender, EventArgs e)
        {
            openFileDialogTask7_VAI.ShowDialog();
            openFilePath = openFileDialogTask7_VAI.FileName;

            string fileData = File.ReadAllText(openFilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] temp = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(temp[c]);
                }
            }

            dataGridViewInPut_VAI.ColumnCount = colums;
            dataGridViewInPut_VAI.RowCount = rows;
            dataGridViewOutPut_VAI.ColumnCount = colums;
            dataGridViewOutPut_VAI.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInPut_VAI.Columns[i].Width = 40;
                dataGridViewOutPut_VAI.Columns[i].Width = 40;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInPut_VAI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonDone_VAI.Enabled = true;
        }

        private void buttonDone_VAI_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutPut_VAI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_VAI.Enabled = true;
        }

        private void buttonSaveFile_VAI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_VAI.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_VAI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_VAI.ShowDialog();

            string path = saveFileDialogMatrix_VAI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_VAI.RowCount;
            int columns = dataGridViewOutPut_VAI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_VAI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_VAI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_VAI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VAI.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_VAI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VAI.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_VAI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VAI.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_VAI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VAI.ToolTipTitle = "Справка";
        }

        private void buttonInfo_VAI_Click(object sender, EventArgs e)
        {
            FormAbout_VAI formAbout = new FormAbout_VAI();
            formAbout.ShowDialog();
        }
    }
}
