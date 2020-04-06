namespace Assignment3
{
    partial class OathLabel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Oath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Oath
            // 
            this.Oath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Oath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oath.Location = new System.Drawing.Point(0, 0);
            this.Oath.Name = "Oath";
            this.Oath.Size = new System.Drawing.Size(370, 150);
            this.Oath.TabIndex = 0;
            this.Oath.Text = "\"As a student of this University: I will be honest in my academic endeavors. I wi" +
    "ll not represent someone else\'s work as my own. I will not cheat, nor will I aid" +
    " in another\'s cheating.\"";
            // 
            // OathLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Oath);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "OathLabel";
            this.Size = new System.Drawing.Size(370, 150);
            this.ResumeLayout(false);

        }

        public void SetText(string text)
        {
            this.Oath.Text = text;
        }

        #endregion

        private System.Windows.Forms.Label Oath;
    }
}
