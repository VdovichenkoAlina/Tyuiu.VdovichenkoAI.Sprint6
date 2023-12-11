
namespace Tyuiu.VdovichenkoAI.Sprint6.Task4.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.flowLayoutPanelTask4_VAI = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxTask4_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask4_VAI = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_VAI = new System.Windows.Forms.GroupBox();
            this.labelFinal_VAI = new System.Windows.Forms.Label();
            this.labelStart_VAI = new System.Windows.Forms.Label();
            this.textBoxStart_VAI = new System.Windows.Forms.TextBox();
            this.textBoxFinal_VAI = new System.Windows.Forms.TextBox();
            this.buttonDone_VAI = new System.Windows.Forms.Button();
            this.buttonSave_VAI = new System.Windows.Forms.Button();
            this.buttonInfo_VAI = new System.Windows.Forms.Button();
            this.flowLayoutPanelOutPutData_VAI = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxOutPutData_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_VAI = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.flowLayoutPanelInPutData_VAI = new System.Windows.Forms.FlowLayoutPanel();
            this.chartFunction_VAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanelTask4_VAI.SuspendLayout();
            this.groupBoxTask4_VAI.SuspendLayout();
            this.groupBoxInPutData_VAI.SuspendLayout();
            this.flowLayoutPanelOutPutData_VAI.SuspendLayout();
            this.groupBoxOutPutData_VAI.SuspendLayout();
            this.flowLayoutPanelInPutData_VAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAI)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTask4_VAI
            // 
            this.flowLayoutPanelTask4_VAI.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanelTask4_VAI.Controls.Add(this.groupBoxTask4_VAI);
            this.flowLayoutPanelTask4_VAI.Controls.Add(this.groupBoxInPutData_VAI);
            this.flowLayoutPanelTask4_VAI.Controls.Add(this.buttonDone_VAI);
            this.flowLayoutPanelTask4_VAI.Controls.Add(this.buttonSave_VAI);
            this.flowLayoutPanelTask4_VAI.Controls.Add(this.buttonInfo_VAI);
            this.flowLayoutPanelTask4_VAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelTask4_VAI.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTask4_VAI.Name = "flowLayoutPanelTask4_VAI";
            this.flowLayoutPanelTask4_VAI.Size = new System.Drawing.Size(1055, 100);
            this.flowLayoutPanelTask4_VAI.TabIndex = 0;
            // 
            // groupBoxTask4_VAI
            // 
            this.groupBoxTask4_VAI.Controls.Add(this.textBoxTask4_VAI);
            this.groupBoxTask4_VAI.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask4_VAI.Name = "groupBoxTask4_VAI";
            this.groupBoxTask4_VAI.Size = new System.Drawing.Size(407, 100);
            this.groupBoxTask4_VAI.TabIndex = 0;
            this.groupBoxTask4_VAI.TabStop = false;
            this.groupBoxTask4_VAI.Text = "Условие";
            // 
            // textBoxTask4_VAI
            // 
            this.textBoxTask4_VAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask4_VAI.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask4_VAI.Multiline = true;
            this.textBoxTask4_VAI.Name = "textBoxTask4_VAI";
            this.textBoxTask4_VAI.ReadOnly = true;
            this.textBoxTask4_VAI.Size = new System.Drawing.Size(394, 69);
            this.textBoxTask4_VAI.TabIndex = 0;
            this.textBoxTask4_VAI.Text = "Протабулировать функцию f(x) на заданом диапазоне от -5 до 5.\r\nРезультат вывести " +
    "в textBox, построить график функции и сохранить в файл OutPutFileTask4V2.txt по " +
    "нажатию кнопки.";
            // 
            // groupBoxInPutData_VAI
            // 
            this.groupBoxInPutData_VAI.Controls.Add(this.labelFinal_VAI);
            this.groupBoxInPutData_VAI.Controls.Add(this.labelStart_VAI);
            this.groupBoxInPutData_VAI.Controls.Add(this.textBoxStart_VAI);
            this.groupBoxInPutData_VAI.Controls.Add(this.textBoxFinal_VAI);
            this.groupBoxInPutData_VAI.Location = new System.Drawing.Point(416, 3);
            this.groupBoxInPutData_VAI.Name = "groupBoxInPutData_VAI";
            this.groupBoxInPutData_VAI.Size = new System.Drawing.Size(286, 100);
            this.groupBoxInPutData_VAI.TabIndex = 1;
            this.groupBoxInPutData_VAI.TabStop = false;
            this.groupBoxInPutData_VAI.Text = "Ввод данных";
            // 
            // labelFinal_VAI
            // 
            this.labelFinal_VAI.AutoSize = true;
            this.labelFinal_VAI.Location = new System.Drawing.Point(162, 34);
            this.labelFinal_VAI.Name = "labelFinal_VAI";
            this.labelFinal_VAI.Size = new System.Drawing.Size(89, 17);
            this.labelFinal_VAI.TabIndex = 1;
            this.labelFinal_VAI.Text = "Конец шага:";
            // 
            // labelStart_VAI
            // 
            this.labelStart_VAI.AutoSize = true;
            this.labelStart_VAI.Location = new System.Drawing.Point(18, 34);
            this.labelStart_VAI.Name = "labelStart_VAI";
            this.labelStart_VAI.Size = new System.Drawing.Size(87, 17);
            this.labelStart_VAI.TabIndex = 1;
            this.labelStart_VAI.Text = "Старт шага:";
            // 
            // textBoxStart_VAI
            // 
            this.textBoxStart_VAI.Location = new System.Drawing.Point(21, 54);
            this.textBoxStart_VAI.Name = "textBoxStart_VAI";
            this.textBoxStart_VAI.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_VAI.TabIndex = 0;
            // 
            // textBoxFinal_VAI
            // 
            this.textBoxFinal_VAI.Location = new System.Drawing.Point(165, 54);
            this.textBoxFinal_VAI.Name = "textBoxFinal_VAI";
            this.textBoxFinal_VAI.Size = new System.Drawing.Size(100, 22);
            this.textBoxFinal_VAI.TabIndex = 0;
            // 
            // buttonDone_VAI
            // 
            this.buttonDone_VAI.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_VAI.Location = new System.Drawing.Point(708, 3);
            this.buttonDone_VAI.Name = "buttonDone_VAI";
            this.buttonDone_VAI.Size = new System.Drawing.Size(148, 91);
            this.buttonDone_VAI.TabIndex = 2;
            this.buttonDone_VAI.Text = "Выполнить";
            this.buttonDone_VAI.UseVisualStyleBackColor = false;
            this.buttonDone_VAI.Click += new System.EventHandler(this.buttonDone_VAI_Click);
            // 
            // buttonSave_VAI
            // 
            this.buttonSave_VAI.BackColor = System.Drawing.Color.Yellow;
            this.buttonSave_VAI.Location = new System.Drawing.Point(862, 3);
            this.buttonSave_VAI.Name = "buttonSave_VAI";
            this.buttonSave_VAI.Size = new System.Drawing.Size(100, 91);
            this.buttonSave_VAI.TabIndex = 3;
            this.buttonSave_VAI.Text = "Сохранить";
            this.buttonSave_VAI.UseVisualStyleBackColor = false;
            this.buttonSave_VAI.Click += new System.EventHandler(this.buttonSave_VAI_Click);
            // 
            // buttonInfo_VAI
            // 
            this.buttonInfo_VAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_VAI.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_VAI.Location = new System.Drawing.Point(968, 3);
            this.buttonInfo_VAI.Name = "buttonInfo_VAI";
            this.buttonInfo_VAI.Size = new System.Drawing.Size(82, 91);
            this.buttonInfo_VAI.TabIndex = 3;
            this.buttonInfo_VAI.Text = "Справка";
            this.buttonInfo_VAI.UseVisualStyleBackColor = false;
            this.buttonInfo_VAI.Click += new System.EventHandler(this.buttonInfo_VAI_Click);
            // 
            // flowLayoutPanelOutPutData_VAI
            // 
            this.flowLayoutPanelOutPutData_VAI.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanelOutPutData_VAI.Controls.Add(this.groupBoxOutPutData_VAI);
            this.flowLayoutPanelOutPutData_VAI.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelOutPutData_VAI.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanelOutPutData_VAI.Name = "flowLayoutPanelOutPutData_VAI";
            this.flowLayoutPanelOutPutData_VAI.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanelOutPutData_VAI.Size = new System.Drawing.Size(200, 407);
            this.flowLayoutPanelOutPutData_VAI.TabIndex = 1;
            // 
            // groupBoxOutPutData_VAI
            // 
            this.groupBoxOutPutData_VAI.Controls.Add(this.textBoxOutPutData_VAI);
            this.groupBoxOutPutData_VAI.Location = new System.Drawing.Point(6, 6);
            this.groupBoxOutPutData_VAI.Name = "groupBoxOutPutData_VAI";
            this.groupBoxOutPutData_VAI.Size = new System.Drawing.Size(200, 401);
            this.groupBoxOutPutData_VAI.TabIndex = 0;
            this.groupBoxOutPutData_VAI.TabStop = false;
            this.groupBoxOutPutData_VAI.Text = "Вывод данных";
            // 
            // textBoxOutPutData_VAI
            // 
            this.textBoxOutPutData_VAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPutData_VAI.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutPutData_VAI.Multiline = true;
            this.textBoxOutPutData_VAI.Name = "textBoxOutPutData_VAI";
            this.textBoxOutPutData_VAI.ReadOnly = true;
            this.textBoxOutPutData_VAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_VAI.Size = new System.Drawing.Size(194, 380);
            this.textBoxOutPutData_VAI.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 407);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // flowLayoutPanelInPutData_VAI
            // 
            this.flowLayoutPanelInPutData_VAI.Controls.Add(this.chartFunction_VAI);
            this.flowLayoutPanelInPutData_VAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelInPutData_VAI.Location = new System.Drawing.Point(203, 100);
            this.flowLayoutPanelInPutData_VAI.Name = "flowLayoutPanelInPutData_VAI";
            this.flowLayoutPanelInPutData_VAI.Size = new System.Drawing.Size(852, 407);
            this.flowLayoutPanelInPutData_VAI.TabIndex = 3;
            // 
            // chartFunction_VAI
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_VAI.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_VAI.Legends.Add(legend2);
            this.chartFunction_VAI.Location = new System.Drawing.Point(3, 3);
            this.chartFunction_VAI.Name = "chartFunction_VAI";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_VAI.Series.Add(series2);
            this.chartFunction_VAI.Size = new System.Drawing.Size(849, 404);
            this.chartFunction_VAI.TabIndex = 0;
            this.chartFunction_VAI.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.ForeColor = System.Drawing.Color.RoyalBlue;
            title2.Name = "TitleFX";
            title2.Text = "График функции f(x)";
            this.chartFunction_VAI.Titles.Add(title2);
            // 
            // FormMain_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 507);
            this.Controls.Add(this.flowLayoutPanelInPutData_VAI);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.flowLayoutPanelOutPutData_VAI);
            this.Controls.Add(this.flowLayoutPanelTask4_VAI);
            this.MinimumSize = new System.Drawing.Size(1073, 554);
            this.Name = "FormMain_VAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 2 | Вдовиченко А. И.";
            this.flowLayoutPanelTask4_VAI.ResumeLayout(false);
            this.groupBoxTask4_VAI.ResumeLayout(false);
            this.groupBoxTask4_VAI.PerformLayout();
            this.groupBoxInPutData_VAI.ResumeLayout(false);
            this.groupBoxInPutData_VAI.PerformLayout();
            this.flowLayoutPanelOutPutData_VAI.ResumeLayout(false);
            this.groupBoxOutPutData_VAI.ResumeLayout(false);
            this.groupBoxOutPutData_VAI.PerformLayout();
            this.flowLayoutPanelInPutData_VAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTask4_VAI;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOutPutData_VAI;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInPutData_VAI;
        private System.Windows.Forms.GroupBox groupBoxTask4_VAI;
        private System.Windows.Forms.TextBox textBoxTask4_VAI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_VAI;
        private System.Windows.Forms.TextBox textBoxStart_VAI;
        private System.Windows.Forms.TextBox textBoxFinal_VAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_VAI;
        private System.Windows.Forms.TextBox textBoxOutPutData_VAI;
        private System.Windows.Forms.Label labelFinal_VAI;
        private System.Windows.Forms.Label labelStart_VAI;
        private System.Windows.Forms.Button buttonDone_VAI;
        private System.Windows.Forms.Button buttonSave_VAI;
        private System.Windows.Forms.Button buttonInfo_VAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAI;
    }
}

