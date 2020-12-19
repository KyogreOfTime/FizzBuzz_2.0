namespace FizzBuzzV2
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FizzBuzzButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FizzBuzzButton
            // 
            this.FizzBuzzButton.Location = new System.Drawing.Point(246, 50);
            this.FizzBuzzButton.Name = "FizzBuzzButton";
            this.FizzBuzzButton.Size = new System.Drawing.Size(75, 23);
            this.FizzBuzzButton.TabIndex = 0;
            this.FizzBuzzButton.Text = "FizzBuzz!";
            this.FizzBuzzButton.UseVisualStyleBackColor = true;
            this.FizzBuzzButton.Click += new System.EventHandler(this.FizzBuzzButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Location = new System.Drawing.Point(61, 88);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(448, 163);
            this.OutputLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 263);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.FizzBuzzButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button FizzBuzzButton;
        private System.Windows.Forms.Label OutputLabel;

        #endregion
    }
}