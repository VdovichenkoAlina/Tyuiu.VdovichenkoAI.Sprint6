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
using Tyuiu.VdovichenkoAI.Sprint6.Task6.V27.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task6.V27
{
    public partial class FormMain_VAI : Form
    {
        public FormMain_VAI()
        {
            InitializeComponent();
        }

        string openFilePath;

        DataService ds = new DataService();
        private void buttonDone_VAI_Click(object sender, EventArgs e)
        {
            textBoxOutPut_VAI.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_VAI_Click(object sender, EventArgs e)
        {
            FormAbout_VAI formAbout = new FormAbout_VAI();
            formAbout.ShowDialog();
        }

        private void buttonOpenFileTask6_VAI_Click(object sender, EventArgs e)
        {
            openFileDialogTask6_VAI.ShowDialog();
            openFilePath = openFileDialogTask6_VAI.FileName;
            textBoxInPut_VAI.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_VAI.Text = groupBoxOutPut_VAI.Text + " " + openFileDialogTask6_VAI.FileName;
            buttonDone_VAI.Enabled = true;
        }
    }
}
