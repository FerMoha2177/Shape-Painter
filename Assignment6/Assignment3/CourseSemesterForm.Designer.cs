namespace Assignment3
{
    partial class CourseSemesterForm
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
            this.courseName = new System.Windows.Forms.Label();
            this.courseSemester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseName
            // 
            this.courseName.BackColor = System.Drawing.Color.Transparent;
            this.courseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.courseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.courseName.Location = new System.Drawing.Point(0, 0);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(350, 100);
            this.courseName.TabIndex = 0;
            this.courseName.Text = "Advanced Windows Programming (COP 4226)";
            this.courseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseSemester
            // 
            this.courseSemester.BackColor = System.Drawing.Color.Transparent;
            this.courseSemester.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.courseSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.courseSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.courseSemester.Location = new System.Drawing.Point(0, 66);
            this.courseSemester.Name = "courseSemester";
            this.courseSemester.Size = new System.Drawing.Size(350, 100);
            this.courseSemester.TabIndex = 0;
            this.courseSemester.Text = "Fall 2019";
            this.courseSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseSemesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.courseSemester);
            this.Name = "CourseSemesterForm";
            this.Size = new System.Drawing.Size(350, 166);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.Label courseSemester;
    }
}
