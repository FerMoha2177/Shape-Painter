namespace Assignment6
{
    partial class OathDialog
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
            this.oathLabel1 = new Assignment3.OathLabel();
            this.SuspendLayout();
            // 
            // BaseLabel
            // 
            this.BaseLabel.Visible = false;
            // 
            // oathLabel1
            // 
            this.oathLabel1.BackColor = System.Drawing.Color.Red;
            this.oathLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathLabel1.ForeColor = System.Drawing.Color.Black;
            this.oathLabel1.Location = new System.Drawing.Point(0, 163);
            this.oathLabel1.Name = "oathLabel1";
            this.oathLabel1.Size = new System.Drawing.Size(600, 97);
            this.oathLabel1.TabIndex = 3;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.oathLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OathDialog";
            this.Text = "OathDialog";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OathDialog_Paint);
            this.Controls.SetChildIndex(this.BaseTextbox, 0);
            this.Controls.SetChildIndex(this.BaseLabel, 0);
            this.Controls.SetChildIndex(this.oathLabel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Assignment3.OathLabel oathLabel1;
    }
}