
namespace Tyuiu.VdovichenkoAI.Sprint6.Task0.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_VAI));
            this.buttonDone_VAI = new System.Windows.Forms.Button();
            this.groupBoxTask0_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask0_VAI = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_VAI = new System.Windows.Forms.PictureBox();
            this.groupBoxInPutData_VAI = new System.Windows.Forms.GroupBox();
            this.labelVarX_VAI = new System.Windows.Forms.Label();
            this.textBoxVarX_VAI = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxResult_VAI = new System.Windows.Forms.TextBox();
            this.labelResult_VAI = new System.Windows.Forms.Label();
            this.buttonHelp_VAI = new System.Windows.Forms.Button();
            this.groupBoxTask0_VAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_VAI)).BeginInit();
            this.groupBoxInPutData_VAI.SuspendLayout();
            this.groupBoxOutPutData_VAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_VAI
            // 
            this.buttonDone_VAI.Location = new System.Drawing.Point(640, 378);
            this.buttonDone_VAI.Name = "buttonDone_VAI";
            this.buttonDone_VAI.Size = new System.Drawing.Size(137, 42);
            this.buttonDone_VAI.TabIndex = 0;
            this.buttonDone_VAI.Text = "Выполнить";
            this.buttonDone_VAI.UseVisualStyleBackColor = true;
            this.buttonDone_VAI.Click += new System.EventHandler(this.buttonDone_VAI_Click);
            // 
            // groupBoxTask0_VAI
            // 
            this.groupBoxTask0_VAI.Controls.Add(this.textBoxTask0_VAI);
            this.groupBoxTask0_VAI.Controls.Add(this.pictureBoxFormula_VAI);
            this.groupBoxTask0_VAI.Location = new System.Drawing.Point(21, 23);
            this.groupBoxTask0_VAI.Name = "groupBoxTask0_VAI";
            this.groupBoxTask0_VAI.Size = new System.Drawing.Size(756, 223);
            this.groupBoxTask0_VAI.TabIndex = 1;
            this.groupBoxTask0_VAI.TabStop = false;
            this.groupBoxTask0_VAI.Text = "Условие";
            // 
            // textBoxTask0_VAI
            // 
            this.textBoxTask0_VAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask0_VAI.Location = new System.Drawing.Point(10, 22);
            this.textBoxTask0_VAI.Multiline = true;
            this.textBoxTask0_VAI.Name = "textBoxTask0_VAI";
            this.textBoxTask0_VAI.ReadOnly = true;
            this.textBoxTask0_VAI.Size = new System.Drawing.Size(481, 195);
            this.textBoxTask0_VAI.TabIndex = 2;
            this.textBoxTask0_VAI.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_VAI
            // 
            this.pictureBoxFormula_VAI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_VAI.Image")));
            this.pictureBoxFormula_VAI.Location = new System.Drawing.Point(585, 22);
            this.pictureBoxFormula_VAI.Name = "pictureBoxFormula_VAI";
            this.pictureBoxFormula_VAI.Size = new System.Drawing.Size(160, 75);
            this.pictureBoxFormula_VAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula_VAI.TabIndex = 1;
            this.pictureBoxFormula_VAI.TabStop = false;
            // 
            // groupBoxInPutData_VAI
            // 
            this.groupBoxInPutData_VAI.Controls.Add(this.labelVarX_VAI);
            this.groupBoxInPutData_VAI.Controls.Add(this.textBoxVarX_VAI);
            this.groupBoxInPutData_VAI.Location = new System.Drawing.Point(21, 261);
            this.groupBoxInPutData_VAI.Name = "groupBoxInPutData_VAI";
            this.groupBoxInPutData_VAI.Size = new System.Drawing.Size(196, 140);
            this.groupBoxInPutData_VAI.TabIndex = 2;
            this.groupBoxInPutData_VAI.TabStop = false;
            this.groupBoxInPutData_VAI.Text = "Ввод данных";
            // 
            // labelVarX_VAI
            // 
            this.labelVarX_VAI.AutoSize = true;
            this.labelVarX_VAI.Location = new System.Drawing.Point(3, 34);
            this.labelVarX_VAI.Name = "labelVarX_VAI";
            this.labelVarX_VAI.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_VAI.TabIndex = 2;
            this.labelVarX_VAI.Text = "Переменная X:";
            // 
            // textBoxVarX_VAI
            // 
            this.textBoxVarX_VAI.Location = new System.Drawing.Point(6, 77);
            this.textBoxVarX_VAI.Name = "textBoxVarX_VAI";
            this.textBoxVarX_VAI.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_VAI.TabIndex = 1;
            this.textBoxVarX_VAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_VAI_KeyPress);
            // 
            // groupBoxOutPutData_VAI
            // 
            this.groupBoxOutPutData_VAI.Controls.Add(this.textBoxResult_VAI);
            this.groupBoxOutPutData_VAI.Controls.Add(this.labelResult_VAI);
            this.groupBoxOutPutData_VAI.Location = new System.Drawing.Point(302, 261);
            this.groupBoxOutPutData_VAI.Name = "groupBoxOutPutData_VAI";
            this.groupBoxOutPutData_VAI.Size = new System.Drawing.Size(210, 140);
            this.groupBoxOutPutData_VAI.TabIndex = 3;
            this.groupBoxOutPutData_VAI.TabStop = false;
            this.groupBoxOutPutData_VAI.Text = "Вывод данных";
            // 
            // textBoxResult_VAI
            // 
            this.textBoxResult_VAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_VAI.Location = new System.Drawing.Point(9, 77);
            this.textBoxResult_VAI.Name = "textBoxResult_VAI";
            this.textBoxResult_VAI.ReadOnly = true;
            this.textBoxResult_VAI.Size = new System.Drawing.Size(100, 15);
            this.textBoxResult_VAI.TabIndex = 1;
            // 
            // labelResult_VAI
            // 
            this.labelResult_VAI.AutoSize = true;
            this.labelResult_VAI.Location = new System.Drawing.Point(6, 34);
            this.labelResult_VAI.Name = "labelResult_VAI";
            this.labelResult_VAI.Size = new System.Drawing.Size(80, 17);
            this.labelResult_VAI.TabIndex = 0;
            this.labelResult_VAI.Text = "Результат:";
            // 
            // buttonHelp_VAI
            // 
            this.buttonHelp_VAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_VAI.Location = new System.Drawing.Point(731, 328);
            this.buttonHelp_VAI.Name = "buttonHelp_VAI";
            this.buttonHelp_VAI.Size = new System.Drawing.Size(46, 42);
            this.buttonHelp_VAI.TabIndex = 4;
            this.buttonHelp_VAI.Text = "?";
            this.buttonHelp_VAI.UseVisualStyleBackColor = true;
            this.buttonHelp_VAI.Click += new System.EventHandler(this.buttonHelp_VAI_Click);
            // 
            // FormMain_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_VAI);
            this.Controls.Add(this.groupBoxOutPutData_VAI);
            this.Controls.Add(this.groupBoxInPutData_VAI);
            this.Controls.Add(this.groupBoxTask0_VAI);
            this.Controls.Add(this.buttonDone_VAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_VAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Вдовиченко А. И.";
            this.groupBoxTask0_VAI.ResumeLayout(false);
            this.groupBoxTask0_VAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_VAI)).EndInit();
            this.groupBoxInPutData_VAI.ResumeLayout(false);
            this.groupBoxInPutData_VAI.PerformLayout();
            this.groupBoxOutPutData_VAI.ResumeLayout(false);
            this.groupBoxOutPutData_VAI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_VAI;
        private System.Windows.Forms.GroupBox groupBoxTask0_VAI;
        private System.Windows.Forms.PictureBox pictureBoxFormula_VAI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_VAI;
        private System.Windows.Forms.Label labelVarX_VAI;
        private System.Windows.Forms.TextBox textBoxVarX_VAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_VAI;
        private System.Windows.Forms.TextBox textBoxResult_VAI;
        private System.Windows.Forms.Label labelResult_VAI;
        private System.Windows.Forms.TextBox textBoxTask0_VAI;
        private System.Windows.Forms.Button buttonHelp_VAI;
    }
}

