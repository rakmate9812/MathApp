namespace MathApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HimomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HimomLabel
            // 
            this.HimomLabel.AutoSize = true;
            this.HimomLabel.Location = new System.Drawing.Point(370, 81);
            this.HimomLabel.Name = "HimomLabel";
            this.HimomLabel.Size = new System.Drawing.Size(63, 20);
            this.HimomLabel.TabIndex = 0;
            this.HimomLabel.Text = "Hi mom";
            this.HimomLabel.Click += new System.EventHandler(this.HimomLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HimomLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HimomLabel;
    }
}