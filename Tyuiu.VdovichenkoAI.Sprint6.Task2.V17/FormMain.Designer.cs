
namespace Tyuiu.VdovichenkoAI.Sprint6.Task2.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask2_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask2_VAI = new System.Windows.Forms.TextBox();
            this.groupBoxResult_VAI = new System.Windows.Forms.GroupBox();
            this.chartFunction_VAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_VAI = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_VAI = new System.Windows.Forms.Label();
            this.groupBoxInPutData_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxFinal_VAI = new System.Windows.Forms.TextBox();
            this.labelFinal_VAI = new System.Windows.Forms.Label();
            this.textBoxStart_VAI = new System.Windows.Forms.TextBox();
            this.labelStart_VAI = new System.Windows.Forms.Label();
            this.buttonInfo_VAI = new System.Windows.Forms.Button();
            this.buttonDone_VAI = new System.Windows.Forms.Button();
            this.groupBoxTask2_VAI.SuspendLayout();
            this.groupBoxResult_VAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_VAI)).BeginInit();
            this.groupBoxInPutData_VAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask2_VAI
            // 
            this.groupBoxTask2_VAI.Controls.Add(this.textBoxTask2_VAI);
            this.groupBoxTask2_VAI.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask2_VAI.Name = "groupBoxTask2_VAI";
            this.groupBoxTask2_VAI.Size = new System.Drawing.Size(561, 317);
            this.groupBoxTask2_VAI.TabIndex = 0;
            this.groupBoxTask2_VAI.TabStop = false;
            this.groupBoxTask2_VAI.Text = "Условие";
            // 
            // textBoxTask2_VAI
            // 
            this.textBoxTask2_VAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask2_VAI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTask2_VAI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxTask2_VAI.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask2_VAI.Multiline = true;
            this.textBoxTask2_VAI.Name = "textBoxTask2_VAI";
            this.textBoxTask2_VAI.ReadOnly = true;
            this.textBoxTask2_VAI.Size = new System.Drawing.Size(548, 271);
            this.textBoxTask2_VAI.TabIndex = 0;
            this.textBoxTask2_VAI.TabStop = false;
            this.textBoxTask2_VAI.Text = "Протабулировать функцию f(x) на заданном диапазоне. Результат вывести в DataGridV" +
    "iew и построить график функции.\r\n";
            // 
            // groupBoxResult_VAI
            // 
            this.groupBoxResult_VAI.Controls.Add(this.chartFunction_VAI);
            this.groupBoxResult_VAI.Controls.Add(this.dataGridViewFunction_VAI);
            this.groupBoxResult_VAI.Controls.Add(this.labelResult_VAI);
            this.groupBoxResult_VAI.Location = new System.Drawing.Point(581, 13);
            this.groupBoxResult_VAI.Name = "groupBoxResult_VAI";
            this.groupBoxResult_VAI.Size = new System.Drawing.Size(550, 427);
            this.groupBoxResult_VAI.TabIndex = 1;
            this.groupBoxResult_VAI.TabStop = false;
            this.groupBoxResult_VAI.Text = "Вывод данных";
            // 
            // chartFunction_VAI
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFunction_VAI.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartFunction_VAI.Legends.Add(legend6);
            this.chartFunction_VAI.Location = new System.Drawing.Point(185, 43);
            this.chartFunction_VAI.Name = "chartFunction_VAI";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFunction_VAI.Series.Add(series6);
            this.chartFunction_VAI.Size = new System.Drawing.Size(359, 378);
            this.chartFunction_VAI.TabIndex = 2;
            this.chartFunction_VAI.Text = "chart1";
            // 
            // dataGridViewFunction_VAI
            // 
            this.dataGridViewFunction_VAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_VAI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.ColumnF});
            this.dataGridViewFunction_VAI.Location = new System.Drawing.Point(10, 43);
            this.dataGridViewFunction_VAI.Name = "dataGridViewFunction_VAI";
            this.dataGridViewFunction_VAI.ReadOnly = true;
            this.dataGridViewFunction_VAI.RowHeadersVisible = false;
            this.dataGridViewFunction_VAI.RowHeadersWidth = 51;
            this.dataGridViewFunction_VAI.RowTemplate.Height = 24;
            this.dataGridViewFunction_VAI.Size = new System.Drawing.Size(169, 378);
            this.dataGridViewFunction_VAI.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "F(x)";
            this.ColumnF.MinimumWidth = 6;
            this.ColumnF.Name = "ColumnF";
            this.ColumnF.ReadOnly = true;
            this.ColumnF.Width = 50;
            // 
            // labelResult_VAI
            // 
            this.labelResult_VAI.AutoSize = true;
            this.labelResult_VAI.Location = new System.Drawing.Point(7, 22);
            this.labelResult_VAI.Name = "labelResult_VAI";
            this.labelResult_VAI.Size = new System.Drawing.Size(80, 17);
            this.labelResult_VAI.TabIndex = 0;
            this.labelResult_VAI.Text = "Результат:";
            // 
            // groupBoxInPutData_VAI
            // 
            this.groupBoxInPutData_VAI.Controls.Add(this.textBoxFinal_VAI);
            this.groupBoxInPutData_VAI.Controls.Add(this.labelFinal_VAI);
            this.groupBoxInPutData_VAI.Controls.Add(this.textBoxStart_VAI);
            this.groupBoxInPutData_VAI.Controls.Add(this.labelStart_VAI);
            this.groupBoxInPutData_VAI.Location = new System.Drawing.Point(13, 336);
            this.groupBoxInPutData_VAI.Name = "groupBoxInPutData_VAI";
            this.groupBoxInPutData_VAI.Size = new System.Drawing.Size(297, 104);
            this.groupBoxInPutData_VAI.TabIndex = 2;
            this.groupBoxInPutData_VAI.TabStop = false;
            this.groupBoxInPutData_VAI.Text = "Ввод данных";
            // 
            // textBoxFinal_VAI
            // 
            this.textBoxFinal_VAI.Location = new System.Drawing.Point(146, 76);
            this.textBoxFinal_VAI.Name = "textBoxFinal_VAI";
            this.textBoxFinal_VAI.Size = new System.Drawing.Size(116, 22);
            this.textBoxFinal_VAI.TabIndex = 1;
            // 
            // labelFinal_VAI
            // 
            this.labelFinal_VAI.AutoSize = true;
            this.labelFinal_VAI.Location = new System.Drawing.Point(143, 35);
            this.labelFinal_VAI.Name = "labelFinal_VAI";
            this.labelFinal_VAI.Size = new System.Drawing.Size(89, 17);
            this.labelFinal_VAI.TabIndex = 2;
            this.labelFinal_VAI.Text = "Конец шага:";
            // 
            // textBoxStart_VAI
            // 
            this.textBoxStart_VAI.Location = new System.Drawing.Point(6, 76);
            this.textBoxStart_VAI.Name = "textBoxStart_VAI";
            this.textBoxStart_VAI.Size = new System.Drawing.Size(116, 22);
            this.textBoxStart_VAI.TabIndex = 1;
            // 
            // labelStart_VAI
            // 
            this.labelStart_VAI.AutoSize = true;
            this.labelStart_VAI.Location = new System.Drawing.Point(6, 35);
            this.labelStart_VAI.Name = "labelStart_VAI";
            this.labelStart_VAI.Size = new System.Drawing.Size(87, 17);
            this.labelStart_VAI.TabIndex = 0;
            this.labelStart_VAI.Text = "Старт шага:";
            // 
            // buttonInfo_VAI
            // 
            this.buttonInfo_VAI.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_VAI.Location = new System.Drawing.Point(317, 336);
            this.buttonInfo_VAI.Name = "buttonInfo_VAI";
            this.buttonInfo_VAI.Size = new System.Drawing.Size(99, 104);
            this.buttonInfo_VAI.TabIndex = 3;
            this.buttonInfo_VAI.Text = "Справка";
            this.buttonInfo_VAI.UseVisualStyleBackColor = false;
            this.buttonInfo_VAI.Click += new System.EventHandler(this.buttonInfo_VAI_Click);
            // 
            // buttonDone_VAI
            // 
            this.buttonDone_VAI.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_VAI.Location = new System.Drawing.Point(423, 337);
            this.buttonDone_VAI.Name = "buttonDone_VAI";
            this.buttonDone_VAI.Size = new System.Drawing.Size(151, 103);
            this.buttonDone_VAI.TabIndex = 4;
            this.buttonDone_VAI.Text = "Выполнить";
            this.buttonDone_VAI.UseVisualStyleBackColor = false;
            this.buttonDone_VAI.Click += new System.EventHandler(this.buttonDone_VAI_Click);
            this.buttonDone_VAI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_VAI_MouseDown);
            this.buttonDone_VAI.MouseEnter += new System.EventHandler(this.buttonDone_VAI_MouseEnter);
            this.buttonDone_VAI.MouseLeave += new System.EventHandler(this.buttonDone_VAI_MouseLeave);
            // 
            // FormMain_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 452);
            this.Controls.Add(this.buttonDone_VAI);
            this.Controls.Add(this.buttonInfo_VAI);
            this.Controls.Add(this.groupBoxInPutData_VAI);
            this.Controls.Add(this.groupBoxResult_VAI);
            this.Controls.Add(this.groupBoxTask2_VAI);
            this.Name = "FormMain_VAI";
            this.Text = "Спринт 6 | Таск 2 | Вариант 17 | Вдовиченко А. И.";
            this.groupBoxTask2_VAI.ResumeLayout(false);
            this.groupBoxTask2_VAI.PerformLayout();
            this.groupBoxResult_VAI.ResumeLayout(false);
            this.groupBoxResult_VAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_VAI)).EndInit();
            this.groupBoxInPutData_VAI.ResumeLayout(false);
            this.groupBoxInPutData_VAI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask2_VAI;
        private System.Windows.Forms.TextBox textBoxTask2_VAI;
        private System.Windows.Forms.GroupBox groupBoxResult_VAI;
        private System.Windows.Forms.DataGridView dataGridViewFunction_VAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
        private System.Windows.Forms.Label labelResult_VAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_VAI;
        private System.Windows.Forms.TextBox textBoxFinal_VAI;
        private System.Windows.Forms.Label labelFinal_VAI;
        private System.Windows.Forms.TextBox textBoxStart_VAI;
        private System.Windows.Forms.Label labelStart_VAI;
        private System.Windows.Forms.Button buttonInfo_VAI;
        private System.Windows.Forms.Button buttonDone_VAI;
    }
}

