
namespace Tyuiu.VdovichenkoAI.Sprint6.Task6.V27
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_VAI));
            this.panelInfo_VAI = new System.Windows.Forms.Panel();
            this.buttonInfo_VAI = new System.Windows.Forms.Button();
            this.buttonDone_VAI = new System.Windows.Forms.Button();
            this.buttonOpenFile_VAI = new System.Windows.Forms.Button();
            this.panelTask6_VAI = new System.Windows.Forms.Panel();
            this.groupBoxTask6_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask6_VAI = new System.Windows.Forms.TextBox();
            this.panelInPut_VAI = new System.Windows.Forms.Panel();
            this.groupBoxInPut_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_VAI = new System.Windows.Forms.TextBox();
            this.panelOutPut_VAI = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_VAI = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_VAI = new System.Windows.Forms.TextBox();
            this.openFileDialogTask6_VAI = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask6_VAI = new System.Windows.Forms.ToolTip(this.components);
            this.panelInfo_VAI.SuspendLayout();
            this.panelTask6_VAI.SuspendLayout();
            this.groupBoxTask6_VAI.SuspendLayout();
            this.panelInPut_VAI.SuspendLayout();
            this.groupBoxInPut_VAI.SuspendLayout();
            this.panelOutPut_VAI.SuspendLayout();
            this.groupBoxOutPut_VAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo_VAI
            // 
            this.panelInfo_VAI.Controls.Add(this.buttonInfo_VAI);
            this.panelInfo_VAI.Controls.Add(this.buttonDone_VAI);
            this.panelInfo_VAI.Controls.Add(this.buttonOpenFile_VAI);
            this.panelInfo_VAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo_VAI.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_VAI.Name = "panelInfo_VAI";
            this.panelInfo_VAI.Size = new System.Drawing.Size(931, 69);
            this.panelInfo_VAI.TabIndex = 0;
            // 
            // buttonInfo_VAI
            // 
            this.buttonInfo_VAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_VAI.Image = global::Tyuiu.VdovichenkoAI.Sprint6.Task6.V27.Properties.Resources.information;
            this.buttonInfo_VAI.Location = new System.Drawing.Point(825, 3);
            this.buttonInfo_VAI.Name = "buttonInfo_VAI";
            this.buttonInfo_VAI.Size = new System.Drawing.Size(103, 63);
            this.buttonInfo_VAI.TabIndex = 2;
            this.toolTipTask6_VAI.SetToolTip(this.buttonInfo_VAI, "Сведение о программе");
            this.buttonInfo_VAI.UseVisualStyleBackColor = true;
            this.buttonInfo_VAI.Click += new System.EventHandler(this.buttonInfo_VAI_Click);
            // 
            // buttonDone_VAI
            // 
            this.buttonDone_VAI.Image = global::Tyuiu.VdovichenkoAI.Sprint6.Task6.V27.Properties.Resources.page_white_go;
            this.buttonDone_VAI.Location = new System.Drawing.Point(120, 3);
            this.buttonDone_VAI.Name = "buttonDone_VAI";
            this.buttonDone_VAI.Size = new System.Drawing.Size(111, 63);
            this.buttonDone_VAI.TabIndex = 1;
            this.toolTipTask6_VAI.SetToolTip(this.buttonDone_VAI, "Выводит слова в которых встречается Н в результирующую строку.");
            this.buttonDone_VAI.UseVisualStyleBackColor = true;
            this.buttonDone_VAI.Click += new System.EventHandler(this.buttonDone_VAI_Click);
            // 
            // buttonOpenFile_VAI
            // 
            this.buttonOpenFile_VAI.Image = global::Tyuiu.VdovichenkoAI.Sprint6.Task6.V27.Properties.Resources.folder_page;
            this.buttonOpenFile_VAI.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_VAI.Name = "buttonOpenFile_VAI";
            this.buttonOpenFile_VAI.Size = new System.Drawing.Size(111, 63);
            this.buttonOpenFile_VAI.TabIndex = 0;
            this.toolTipTask6_VAI.SetToolTip(this.buttonOpenFile_VAI, "Открыть файл.\r\nВыберите нужный файл для обработки.\r\n");
            this.buttonOpenFile_VAI.UseVisualStyleBackColor = true;
            // 
            // panelTask6_VAI
            // 
            this.panelTask6_VAI.Controls.Add(this.groupBoxTask6_VAI);
            this.panelTask6_VAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask6_VAI.Location = new System.Drawing.Point(0, 69);
            this.panelTask6_VAI.Name = "panelTask6_VAI";
            this.panelTask6_VAI.Size = new System.Drawing.Size(931, 102);
            this.panelTask6_VAI.TabIndex = 1;
            // 
            // groupBoxTask6_VAI
            // 
            this.groupBoxTask6_VAI.Controls.Add(this.textBoxTask6_VAI);
            this.groupBoxTask6_VAI.Location = new System.Drawing.Point(3, 7);
            this.groupBoxTask6_VAI.Name = "groupBoxTask6_VAI";
            this.groupBoxTask6_VAI.Size = new System.Drawing.Size(925, 89);
            this.groupBoxTask6_VAI.TabIndex = 0;
            this.groupBoxTask6_VAI.TabStop = false;
            this.groupBoxTask6_VAI.Text = "Условие";
            // 
            // textBoxTask6_VAI
            // 
            this.textBoxTask6_VAI.Location = new System.Drawing.Point(6, 22);
            this.textBoxTask6_VAI.Multiline = true;
            this.textBoxTask6_VAI.Name = "textBoxTask6_VAI";
            this.textBoxTask6_VAI.ReadOnly = true;
            this.textBoxTask6_VAI.Size = new System.Drawing.Size(913, 67);
            this.textBoxTask6_VAI.TabIndex = 0;
            this.textBoxTask6_VAI.Text = resources.GetString("textBoxTask6_VAI.Text");
            // 
            // panelInPut_VAI
            // 
            this.panelInPut_VAI.Controls.Add(this.groupBoxInPut_VAI);
            this.panelInPut_VAI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_VAI.Location = new System.Drawing.Point(0, 171);
            this.panelInPut_VAI.Name = "panelInPut_VAI";
            this.panelInPut_VAI.Size = new System.Drawing.Size(452, 349);
            this.panelInPut_VAI.TabIndex = 2;
            // 
            // groupBoxInPut_VAI
            // 
            this.groupBoxInPut_VAI.Controls.Add(this.textBoxInPut_VAI);
            this.groupBoxInPut_VAI.Location = new System.Drawing.Point(4, 7);
            this.groupBoxInPut_VAI.Name = "groupBoxInPut_VAI";
            this.groupBoxInPut_VAI.Size = new System.Drawing.Size(448, 339);
            this.groupBoxInPut_VAI.TabIndex = 0;
            this.groupBoxInPut_VAI.TabStop = false;
            this.groupBoxInPut_VAI.Text = "Ввод";
            // 
            // textBoxInPut_VAI
            // 
            this.textBoxInPut_VAI.Location = new System.Drawing.Point(9, 21);
            this.textBoxInPut_VAI.Multiline = true;
            this.textBoxInPut_VAI.Name = "textBoxInPut_VAI";
            this.textBoxInPut_VAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_VAI.Size = new System.Drawing.Size(433, 312);
            this.textBoxInPut_VAI.TabIndex = 0;
            // 
            // panelOutPut_VAI
            // 
            this.panelOutPut_VAI.Controls.Add(this.groupBoxOutPut_VAI);
            this.panelOutPut_VAI.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOutPut_VAI.Location = new System.Drawing.Point(458, 171);
            this.panelOutPut_VAI.Name = "panelOutPut_VAI";
            this.panelOutPut_VAI.Size = new System.Drawing.Size(473, 349);
            this.panelOutPut_VAI.TabIndex = 3;
            // 
            // groupBoxOutPut_VAI
            // 
            this.groupBoxOutPut_VAI.Controls.Add(this.textBoxOutPut_VAI);
            this.groupBoxOutPut_VAI.Location = new System.Drawing.Point(4, 7);
            this.groupBoxOutPut_VAI.Name = "groupBoxOutPut_VAI";
            this.groupBoxOutPut_VAI.Size = new System.Drawing.Size(466, 339);
            this.groupBoxOutPut_VAI.TabIndex = 0;
            this.groupBoxOutPut_VAI.TabStop = false;
            this.groupBoxOutPut_VAI.Text = "Вывод";
            // 
            // textBoxOutPut_VAI
            // 
            this.textBoxOutPut_VAI.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutPut_VAI.Multiline = true;
            this.textBoxOutPut_VAI.Name = "textBoxOutPut_VAI";
            this.textBoxOutPut_VAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_VAI.Size = new System.Drawing.Size(451, 312);
            this.textBoxOutPut_VAI.TabIndex = 0;
            // 
            // openFileDialogTask6_VAI
            // 
            this.openFileDialogTask6_VAI.FileName = "openFileDialog1";
            // 
            // toolTipTask6_VAI
            // 
            this.toolTipTask6_VAI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask6_VAI.ToolTipTitle = "Подсказка";
            // 
            // FormMain_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 520);
            this.Controls.Add(this.panelOutPut_VAI);
            this.Controls.Add(this.panelInPut_VAI);
            this.Controls.Add(this.panelTask6_VAI);
            this.Controls.Add(this.panelInfo_VAI);
            this.Name = "FormMain_VAI";
            this.Text = "Спринт 6 | Таск 6 | Вариант 27 | Вдовиченко А. И.";
            this.panelInfo_VAI.ResumeLayout(false);
            this.panelTask6_VAI.ResumeLayout(false);
            this.groupBoxTask6_VAI.ResumeLayout(false);
            this.groupBoxTask6_VAI.PerformLayout();
            this.panelInPut_VAI.ResumeLayout(false);
            this.groupBoxInPut_VAI.ResumeLayout(false);
            this.groupBoxInPut_VAI.PerformLayout();
            this.panelOutPut_VAI.ResumeLayout(false);
            this.groupBoxOutPut_VAI.ResumeLayout(false);
            this.groupBoxOutPut_VAI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo_VAI;
        private System.Windows.Forms.Button buttonInfo_VAI;
        private System.Windows.Forms.Button buttonDone_VAI;
        private System.Windows.Forms.Button buttonOpenFile_VAI;
        private System.Windows.Forms.Panel panelTask6_VAI;
        private System.Windows.Forms.GroupBox groupBoxTask6_VAI;
        private System.Windows.Forms.TextBox textBoxTask6_VAI;
        private System.Windows.Forms.Panel panelInPut_VAI;
        private System.Windows.Forms.GroupBox groupBoxInPut_VAI;
        private System.Windows.Forms.TextBox textBoxInPut_VAI;
        private System.Windows.Forms.Panel panelOutPut_VAI;
        private System.Windows.Forms.GroupBox groupBoxOutPut_VAI;
        private System.Windows.Forms.TextBox textBoxOutPut_VAI;
        private System.Windows.Forms.ToolTip toolTipTask6_VAI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask6_VAI;
    }
}

