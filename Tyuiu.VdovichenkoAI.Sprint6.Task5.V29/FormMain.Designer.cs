
namespace Tyuiu.VdovichenkoAI.Sprint6.Task5.V29
{
    partial class FormMain_VAI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask5_VAI = new System.Windows.Forms.Panel();
            this.groupBoxTask5_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask5_VAI = new System.Windows.Forms.TextBox();
            this.panelChart_VAI = new System.Windows.Forms.Panel();
            this.panelResult_VAI = new System.Windows.Forms.Panel();
            this.groupBoxResult_VAI = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.chart_VAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_VAI = new System.Windows.Forms.Button();
            this.buttonOpen_VAI = new System.Windows.Forms.Button();
            this.buttonInfo_VAI = new System.Windows.Forms.Button();
            this.dataGridViewNums_VAI = new System.Windows.Forms.DataGridView();
            this.panelTask5_VAI.SuspendLayout();
            this.groupBoxTask5_VAI.SuspendLayout();
            this.panelChart_VAI.SuspendLayout();
            this.panelResult_VAI.SuspendLayout();
            this.groupBoxResult_VAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_VAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_VAI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask5_VAI
            // 
            this.panelTask5_VAI.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelTask5_VAI.Controls.Add(this.buttonInfo_VAI);
            this.panelTask5_VAI.Controls.Add(this.buttonOpen_VAI);
            this.panelTask5_VAI.Controls.Add(this.buttonDone_VAI);
            this.panelTask5_VAI.Controls.Add(this.groupBoxTask5_VAI);
            this.panelTask5_VAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask5_VAI.Location = new System.Drawing.Point(0, 0);
            this.panelTask5_VAI.Name = "panelTask5_VAI";
            this.panelTask5_VAI.Size = new System.Drawing.Size(1086, 100);
            this.panelTask5_VAI.TabIndex = 0;
            // 
            // groupBoxTask5_VAI
            // 
            this.groupBoxTask5_VAI.Controls.Add(this.textBoxTask5_VAI);
            this.groupBoxTask5_VAI.Location = new System.Drawing.Point(13, 3);
            this.groupBoxTask5_VAI.Name = "groupBoxTask5_VAI";
            this.groupBoxTask5_VAI.Size = new System.Drawing.Size(687, 91);
            this.groupBoxTask5_VAI.TabIndex = 0;
            this.groupBoxTask5_VAI.TabStop = false;
            this.groupBoxTask5_VAI.Text = "Условие";
            // 
            // textBoxTask5_VAI
            // 
            this.textBoxTask5_VAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask5_VAI.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask5_VAI.Multiline = true;
            this.textBoxTask5_VAI.Name = "textBoxTask5_VAI";
            this.textBoxTask5_VAI.ReadOnly = true;
            this.textBoxTask5_VAI.Size = new System.Drawing.Size(674, 63);
            this.textBoxTask5_VAI.TabIndex = 0;
            this.textBoxTask5_VAI.Text = "Прочитать данные из файла InPutFileTask5V29.txt. Вывести в dataGridView. Вывести " +
    "все числа, больше или равные 10. Построить диаграмму по этим значениям.";
            // 
            // panelChart_VAI
            // 
            this.panelChart_VAI.Controls.Add(this.chart_VAI);
            this.panelChart_VAI.Controls.Add(this.splitter1);
            this.panelChart_VAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_VAI.Location = new System.Drawing.Point(0, 100);
            this.panelChart_VAI.Name = "panelChart_VAI";
            this.panelChart_VAI.Size = new System.Drawing.Size(1086, 374);
            this.panelChart_VAI.TabIndex = 0;
            // 
            // panelResult_VAI
            // 
            this.panelResult_VAI.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelResult_VAI.Controls.Add(this.splitter2);
            this.panelResult_VAI.Controls.Add(this.groupBoxResult_VAI);
            this.panelResult_VAI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_VAI.Location = new System.Drawing.Point(0, 100);
            this.panelResult_VAI.Name = "panelResult_VAI";
            this.panelResult_VAI.Size = new System.Drawing.Size(200, 374);
            this.panelResult_VAI.TabIndex = 0;
            // 
            // groupBoxResult_VAI
            // 
            this.groupBoxResult_VAI.Controls.Add(this.dataGridViewNums_VAI);
            this.groupBoxResult_VAI.Location = new System.Drawing.Point(4, 7);
            this.groupBoxResult_VAI.Name = "groupBoxResult_VAI";
            this.groupBoxResult_VAI.Size = new System.Drawing.Size(193, 364);
            this.groupBoxResult_VAI.TabIndex = 0;
            this.groupBoxResult_VAI.TabStop = false;
            this.groupBoxResult_VAI.Text = "Вывод данных";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(1083, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 374);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(197, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 374);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // chart_VAI
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_VAI.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_VAI.Legends.Add(legend3);
            this.chart_VAI.Location = new System.Drawing.Point(197, 0);
            this.chart_VAI.Name = "chart_VAI";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_VAI.Series.Add(series3);
            this.chart_VAI.Size = new System.Drawing.Size(886, 374);
            this.chart_VAI.TabIndex = 1;
            this.chart_VAI.Text = "chart1";
            // 
            // buttonDone_VAI
            // 
            this.buttonDone_VAI.Location = new System.Drawing.Point(706, 12);
            this.buttonDone_VAI.Name = "buttonDone_VAI";
            this.buttonDone_VAI.Size = new System.Drawing.Size(136, 82);
            this.buttonDone_VAI.TabIndex = 1;
            this.buttonDone_VAI.Text = "Выполнить";
            this.buttonDone_VAI.UseVisualStyleBackColor = true;
            this.buttonDone_VAI.Click += new System.EventHandler(this.buttonDone_VAI_Click);
            // 
            // buttonOpen_VAI
            // 
            this.buttonOpen_VAI.Location = new System.Drawing.Point(848, 12);
            this.buttonOpen_VAI.Name = "buttonOpen_VAI";
            this.buttonOpen_VAI.Size = new System.Drawing.Size(115, 82);
            this.buttonOpen_VAI.TabIndex = 2;
            this.buttonOpen_VAI.Text = "Открыть файл";
            this.buttonOpen_VAI.UseVisualStyleBackColor = true;
            this.buttonOpen_VAI.Click += new System.EventHandler(this.buttonOpen_VAI_Click);
            // 
            // buttonInfo_VAI
            // 
            this.buttonInfo_VAI.Location = new System.Drawing.Point(969, 12);
            this.buttonInfo_VAI.Name = "buttonInfo_VAI";
            this.buttonInfo_VAI.Size = new System.Drawing.Size(105, 82);
            this.buttonInfo_VAI.TabIndex = 3;
            this.buttonInfo_VAI.Text = "Справка";
            this.buttonInfo_VAI.UseVisualStyleBackColor = true;
            this.buttonInfo_VAI.Click += new System.EventHandler(this.buttonInfo_VAI_Click);
            // 
            // dataGridViewNums_VAI
            // 
            this.dataGridViewNums_VAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_VAI.ColumnHeadersVisible = false;
            this.dataGridViewNums_VAI.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewNums_VAI.Name = "dataGridViewNums_VAI";
            this.dataGridViewNums_VAI.RowHeadersVisible = false;
            this.dataGridViewNums_VAI.RowHeadersWidth = 51;
            this.dataGridViewNums_VAI.RowTemplate.Height = 24;
            this.dataGridViewNums_VAI.Size = new System.Drawing.Size(180, 336);
            this.dataGridViewNums_VAI.TabIndex = 0;
            // 
            // FormMain_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 474);
            this.Controls.Add(this.panelResult_VAI);
            this.Controls.Add(this.panelChart_VAI);
            this.Controls.Add(this.panelTask5_VAI);
            this.Name = "FormMain_VAI";
            this.Text = "Спринт 6 | Таск 5 | Вариант 29 | Вдовиченко А. И.";
            this.panelTask5_VAI.ResumeLayout(false);
            this.groupBoxTask5_VAI.ResumeLayout(false);
            this.groupBoxTask5_VAI.PerformLayout();
            this.panelChart_VAI.ResumeLayout(false);
            this.panelResult_VAI.ResumeLayout(false);
            this.groupBoxResult_VAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_VAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_VAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask5_VAI;
        private System.Windows.Forms.GroupBox groupBoxTask5_VAI;
        private System.Windows.Forms.TextBox textBoxTask5_VAI;
        private System.Windows.Forms.Panel panelChart_VAI;
        private System.Windows.Forms.Panel panelResult_VAI;
        private System.Windows.Forms.GroupBox groupBoxResult_VAI;
        private System.Windows.Forms.Button buttonInfo_VAI;
        private System.Windows.Forms.Button buttonOpen_VAI;
        private System.Windows.Forms.Button buttonDone_VAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_VAI;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView dataGridViewNums_VAI;
    }
}

