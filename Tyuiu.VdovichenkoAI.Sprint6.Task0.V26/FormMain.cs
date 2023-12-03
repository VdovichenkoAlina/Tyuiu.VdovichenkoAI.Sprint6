using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VdovichenkoAI.Sprint6.Task0.V26.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint6.Task0.V26
{
    public partial class FormMain_VAI : Form
    {
        public FormMain_VAI()
        {
            InitializeComponent();
        }

        private void buttonDone_VAI_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_VAI.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_VAI.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_VAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_VAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-23-1 Вдовиченко Алина Игоревна", "Сообщение");
        }
    }
}
