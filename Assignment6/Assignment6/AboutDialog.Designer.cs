namespace Assignment6
{
    partial class AboutDialog
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
            this.aboutLabel1 = new Assignment3.OathLabel();
            this.SuspendLayout();
            // 
            // BaseLabel
            // 
            this.BaseLabel.Visible = false;
            // 
            // AboutDialog
            // 
            this.BaseLabel.Visible = false;
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.SetText("This application lets you draw rectangles and ellipses, select their color and size, and even use gradients!\n" +
                "Let your creativity loose with this application!");
            this.aboutLabel1.BackColor = System.Drawing.Color.Red;
            this.aboutLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutLabel1.ForeColor = System.Drawing.Color.Black;
            this.aboutLabel1.Location = new System.Drawing.Point(0, 163);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(600, 97);
            this.aboutLabel1.TabIndex = 3;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Controls.Add(this.aboutLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OathDialog";
            this.Text = "OathDialog";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AboutDialog_Paint);
            this.Controls.SetChildIndex(this.BaseTextbox, 0);
            this.Controls.SetChildIndex(this.BaseLabel, 0);
            this.Controls.SetChildIndex(this.aboutLabel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Assignment3.OathLabel aboutLabel1;

    }
}