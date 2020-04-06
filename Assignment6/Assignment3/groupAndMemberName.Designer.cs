namespace Assignment3
{
    partial class groupAndMemberName
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
            this.groupAndMemberNames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupAndMemberNames
            // 
            this.groupAndMemberNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAndMemberNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.groupAndMemberNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.groupAndMemberNames.Location = new System.Drawing.Point(0, 0);
            this.groupAndMemberNames.Name = "groupAndMemberNames";
            this.groupAndMemberNames.Size = new System.Drawing.Size(350, 300);
            this.groupAndMemberNames.TabIndex = 0;
            this.groupAndMemberNames.Text = "Team 5\r\nAndre Marin, Ferris Mohammed, Justin Cabrera";
            this.groupAndMemberNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupAndMemberName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.groupAndMemberNames);
            this.Name = "groupAndMemberName";
            this.Size = new System.Drawing.Size(350, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label groupAndMemberNames;
    }
}
