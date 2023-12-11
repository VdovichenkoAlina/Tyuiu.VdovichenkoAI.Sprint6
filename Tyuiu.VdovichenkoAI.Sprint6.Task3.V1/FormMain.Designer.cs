
namespace Tyuiu.VdovichenkoAI.Sprint6.Task3.V1
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
            this.groupBoxTask3_VAI = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_VAI = new System.Windows.Forms.DataGridView();
            this.textBoxTask3_VAI = new System.Windows.Forms.TextBox();
            this.buttonDone_VAI = new System.Windows.Forms.Button();
            this.groupBoxResult_VAI = new System.Windows.Forms.GroupBox();
            this.labelResult_VAI = new System.Windows.Forms.Label();
            this.buttonInfo_VAI = new System.Windows.Forms.Button();
            this.dataGridViewMatrixResult_VAI = new System.Windows.Forms.DataGridView();
            this.groupBoxTask3_VAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_VAI)).BeginInit();
            this.groupBoxResult_VAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_VAI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask3_VAI
            // 
            this.groupBoxTask3_VAI.Controls.Add(this.dataGridViewMatrix_VAI);
            this.groupBoxTask3_VAI.Controls.Add(this.textBoxTask3_VAI);
            this.groupBoxTask3_VAI.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask3_VAI.Name = "groupBoxTask3_VAI";
            this.groupBoxTask3_VAI.Size = new System.Drawing.Size(681, 372);
            this.groupBoxTask3_VAI.TabIndex = 0;
            this.groupBoxTask3_VAI.TabStop = false;
            this.groupBoxTask3_VAI.Text = "Условие";
            // 
            // dataGridViewMatrix_VAI
            // 
            this.dataGridViewMatrix_VAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_VAI.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_VAI.Location = new System.Drawing.Point(379, 22);
            this.dataGridViewMatrix_VAI.Name = "dataGridViewMatrix_VAI";
            this.dataGridViewMatrix_VAI.RowHeadersVisible = false;
            this.dataGridViewMatrix_VAI.RowHeadersWidth = 51;
            this.dataGridViewMatrix_VAI.RowTemplate.Height = 24;
            this.dataGridViewMatrix_VAI.Size = new System.Drawing.Size(296, 344);
            this.dataGridViewMatrix_VAI.TabIndex = 1;
            // 
            // textBoxTask3_VAI
            // 
            this.textBoxTask3_VAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask3_VAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask3_VAI.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask3_VAI.Multiline = true;
            this.textBoxTask3_VAI.Name = "textBoxTask3_VAI";
            this.textBoxTask3_VAI.ReadOnly = true;
            this.textBoxTask3_VAI.Size = new System.Drawing.Size(377, 344);
            this.textBoxTask3_VAI.TabIndex = 0;
            this.textBoxTask3_VAI.TabStop = false;
            this.textBoxTask3_VAI.Text = "Дан массив 5 на 5 элементов. \r\n25 20 28 2 6\r\n19 9 18 -7 24\r\n21 16 5 -7 -8\r\n30 -13" +
    " 1 -15 2\r\n31 9 -3 -9 -18\r\nВыполнить сортировку по возрастанию в первом столбце. " +
    "";
            // 
            // buttonDone_VAI
            // 
            this.buttonDone_VAI.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_VAI.Location = new System.Drawing.Point(1019, 316);
            this.buttonDone_VAI.Name = "buttonDone_VAI";
            this.buttonDone_VAI.Size = new System.Drawing.Size(103, 69);
            this.buttonDone_VAI.TabIndex = 1;
            this.buttonDone_VAI.Text = "Выполнить";
            this.buttonDone_VAI.UseVisualStyleBackColor = false;
            this.buttonDone_VAI.Click += new System.EventHandler(this.buttonDone_VAI_Click);
            // 
            // groupBoxResult_VAI
            // 
            this.groupBoxResult_VAI.Controls.Add(this.dataGridViewMatrixResult_VAI);
            this.groupBoxResult_VAI.Controls.Add(this.labelResult_VAI);
            this.groupBoxResult_VAI.Location = new System.Drawing.Point(700, 12);
            this.groupBoxResult_VAI.Name = "groupBoxResult_VAI";
            this.groupBoxResult_VAI.Size = new System.Drawing.Size(313, 373);
            this.groupBoxResult_VAI.TabIndex = 2;
            this.groupBoxResult_VAI.TabStop = false;
            this.groupBoxResult_VAI.Text = "Вывод данных";
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
            // buttonInfo_VAI
            // 
            this.buttonInfo_VAI.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_VAI.Location = new System.Drawing.Point(1019, 266);
            this.buttonInfo_VAI.Name = "buttonInfo_VAI";
            this.buttonInfo_VAI.Size = new System.Drawing.Size(103, 44);
            this.buttonInfo_VAI.TabIndex = 3;
            this.buttonInfo_VAI.Text = "Справка";
            this.buttonInfo_VAI.UseVisualStyleBackColor = false;
            this.buttonInfo_VAI.Click += new System.EventHandler(this.buttonInfo_VAI_Click);
            // 
            // dataGridViewMatrixResult_VAI
            // 
            this.dataGridViewMatrixResult_VAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_VAI.ColumnHeadersVisible = false;
            this.dataGridViewMatrixResult_VAI.Location = new System.Drawing.Point(7, 43);
            this.dataGridViewMatrixResult_VAI.Name = "dataGridViewMatrixResult_VAI";
            this.dataGridViewMatrixResult_VAI.RowHeadersVisible = false;
            this.dataGridViewMatrixResult_VAI.RowHeadersWidth = 51;
            this.dataGridViewMatrixResult_VAI.RowTemplate.Height = 24;
            this.dataGridViewMatrixResult_VAI.Size = new System.Drawing.Size(296, 324);
            this.dataGridViewMatrixResult_VAI.TabIndex = 1;
            // 
            // FormMain_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 397);
            this.Controls.Add(this.buttonInfo_VAI);
            this.Controls.Add(this.groupBoxResult_VAI);
            this.Controls.Add(this.buttonDone_VAI);
            this.Controls.Add(this.groupBoxTask3_VAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain_VAI";
            this.Text = "Спринт 6 | Таск 3 | Вариант 1 | Вдовиченко А. И.";
            this.Load += new System.EventHandler(this.FormMain_VAI_Load);
            this.groupBoxTask3_VAI.ResumeLayout(false);
            this.groupBoxTask3_VAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_VAI)).EndInit();
            this.groupBoxResult_VAI.ResumeLayout(false);
            this.groupBoxResult_VAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_VAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask3_VAI;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_VAI;
        private System.Windows.Forms.TextBox textBoxTask3_VAI;
        private System.Windows.Forms.Button buttonDone_VAI;
        private System.Windows.Forms.GroupBox groupBoxResult_VAI;
        private System.Windows.Forms.Label labelResult_VAI;
        private System.Windows.Forms.Button buttonInfo_VAI;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_VAI;
    }
}

