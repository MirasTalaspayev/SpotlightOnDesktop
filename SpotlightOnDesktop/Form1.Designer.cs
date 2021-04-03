
namespace SpotlightOnDesktop
{
    partial class Form1
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
            this.btn_ImageSetter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ImageSetter
            // 
            this.btn_ImageSetter.Location = new System.Drawing.Point(65, 48);
            this.btn_ImageSetter.Name = "btn_ImageSetter";
            this.btn_ImageSetter.Size = new System.Drawing.Size(75, 27);
            this.btn_ImageSetter.TabIndex = 0;
            this.btn_ImageSetter.Text = "Set Image";
            this.btn_ImageSetter.UseVisualStyleBackColor = true;
            this.btn_ImageSetter.Click += new System.EventHandler(this.NextImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 136);
            this.Controls.Add(this.btn_ImageSetter);
            this.Name = "Form1";
            this.Text = "SpotlightOnDesktop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ImageSetter;
    }
}

