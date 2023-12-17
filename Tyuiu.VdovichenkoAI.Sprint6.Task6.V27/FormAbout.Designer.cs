
namespace Tyuiu.VdovichenkoAI.Sprint6.Task6.V27
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
            this.labelInfo_VAI = new System.Windows.Forms.Label();
            this.buttonClose_VAI = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_VAI
            // 
            this.labelInfo_VAI.AutoSize = true;
            this.labelInfo_VAI.Location = new System.Drawing.Point(291, 24);
            this.labelInfo_VAI.Name = "labelInfo_VAI";
            this.labelInfo_VAI.Size = new System.Drawing.Size(377, 153);
            this.labelInfo_VAI.TabIndex = 1;
            this.labelInfo_VAI.Text = resources.GetString("labelInfo_VAI.Text");
            // 
            // buttonClose_VAI
            // 
            this.buttonClose_VAI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonClose_VAI.Location = new System.Drawing.Point(526, 221);
            this.buttonClose_VAI.Name = "buttonClose_VAI";
            this.buttonClose_VAI.Size = new System.Drawing.Size(174, 63);
            this.buttonClose_VAI.TabIndex = 2;
            this.buttonClose_VAI.Text = "ОК";
            this.buttonClose_VAI.UseVisualStyleBackColor = false;
            this.buttonClose_VAI.Click += new System.EventHandler(this.buttonClose_VAI_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.VdovichenkoAI.Sprint6.Task6.V27.Properties.Resources.IMG_9580;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout_VAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 296);
            this.Controls.Add(this.buttonClose_VAI);
            this.Controls.Add(this.labelInfo_VAI);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_VAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfo_VAI;
        private System.Windows.Forms.Button buttonClose_VAI;
    }
}