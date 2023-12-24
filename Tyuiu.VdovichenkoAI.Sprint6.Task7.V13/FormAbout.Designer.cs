
namespace Tyuiu.VdovichenkoAI.Sprint6.Task7.V13
{
    partial class FormAbout_VAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_VAI));
            this.pictureBox_VAI = new System.Windows.Forms.PictureBox();
            this.labelInfo_VAI = new System.Windows.Forms.Label();
            this.buttonOK_VAI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VAI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_VAI
            // 
            this.pictureBox_VAI.Image = global::Tyuiu.VdovichenkoAI.Sprint6.Task7.V13.Properties.Resources._560130E2_7FC4_4B78_AA13_2D761641EB13;
            this.pictureBox_VAI.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_VAI.Name = "pictureBox_VAI";
            this.pictureBox_VAI.Size = new System.Drawing.Size(196, 248);
            this.pictureBox_VAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_VAI.TabIndex = 0;
            this.pictureBox_VAI.TabStop = false;
            // 
            // labelInfo_VAI
            // 
            this.labelInfo_VAI.AutoSize = true;
            this.labelInfo_VAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_VAI.Location = new System.Drawing.Point(239, 32);
            this.labelInfo_VAI.Name = "labelInfo_VAI";
            this.labelInfo_VAI.Size = new System.Drawing.Size(388, 144);
            this.labelInfo_VAI.TabIndex = 1;
            this.labelInfo_VAI.Text = resources.GetString("labelInfo_VAI.Text");
            // 
            // buttonOK_VAI
            // 
            this.buttonOK_VAI.Location = new System.Drawing.Point(494, 195);
            this.buttonOK_VAI.Name = "buttonOK_VAI";
            this.buttonOK_VAI.Size = new System.Drawing.Size(175, 65);
            this.buttonOK_VAI.TabIndex = 2;
            this.buttonOK_VAI.Text = "OK";
            this.buttonOK_VAI.UseVisualStyleBackColor = true;
            this.buttonOK_VAI.Click += new System.EventHandler(this.buttonOK_VAI_Click);
            // 
            // FormAbout_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 272);
            this.Controls.Add(this.buttonOK_VAI);
            this.Controls.Add(this.labelInfo_VAI);
            this.Controls.Add(this.pictureBox_VAI);
            this.Name = "FormAbout_VAI";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VAI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_VAI;
        private System.Windows.Forms.Label labelInfo_VAI;
        private System.Windows.Forms.Button buttonOK_VAI;
    }
}