using System.Windows.Forms;

namespace Assignment3
{
    partial class BaseDialogForm
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

        public void NameForm(groupAndMemberName name)
        { 
            name.Visible = true;
            name.Dock = DockStyle.Top;
            this.Controls.Add(name);
        }

        public void CourseForm(CourseSemesterForm course)
        {
            course.Visible = true;
            course.Dock = DockStyle.Bottom;
            this.Controls.Add(course);
        }

        public void BlankSpace()
        {
            Panel blankspace = new Panel();
            blankspace.Dock = DockStyle.Fill;
            this.Controls.Add(blankspace);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.BaseTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BaseLabel = new System.Windows.Forms.Label();
            this.courseSemesterForm = new Assignment3.CourseSemesterForm();
            this.groupAndMemberName = new Assignment3.groupAndMemberName();
            this.SuspendLayout();
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.Transparent;
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 163);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(800, 181);
            this.CenterPanel.TabIndex = 2;
            this.CenterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CenterPanel_Paint);
            // 
            // BaseTextbox
            // 
            this.BaseTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BaseTextbox.BackColor = System.Drawing.Color.White;
            this.BaseTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BaseTextbox.Location = new System.Drawing.Point(12, 246);
            this.BaseTextbox.Multiline = true;
            this.BaseTextbox.Name = "BaseTextbox";
            this.BaseTextbox.ReadOnly = true;
            this.BaseTextbox.Size = new System.Drawing.Size(100, 100);
            this.BaseTextbox.TabIndex = 0;
            this.BaseTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BaseTextbox.Visible = false;
            this.BaseTextbox.TextChanged += new System.EventHandler(this.BaseTextbox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BaseLabel
            // 
            this.BaseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BaseLabel.AutoSize = true;
            this.BaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.BaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BaseLabel.Location = new System.Drawing.Point(134, 203);
            this.BaseLabel.Name = "BaseLabel";
            this.BaseLabel.Size = new System.Drawing.Size(51, 20);
            this.BaseLabel.TabIndex = 0;
            this.BaseLabel.Text = "label1";
            this.BaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BaseLabel.Click += new System.EventHandler(this.BaseLabel_Click);
            // 
            // courseSemesterForm
            // 
            this.courseSemesterForm.BackColor = System.Drawing.Color.Transparent;
            this.courseSemesterForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseSemesterForm.Location = new System.Drawing.Point(0, 0);
            this.courseSemesterForm.Margin = new System.Windows.Forms.Padding(4);
            this.courseSemesterForm.Name = "courseSemesterForm";
            this.courseSemesterForm.Size = new System.Drawing.Size(800, 163);
            this.courseSemesterForm.TabIndex = 1;
            // 
            // groupAndMemberName
            // 
            this.groupAndMemberName.BackColor = System.Drawing.Color.Transparent;
            this.groupAndMemberName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupAndMemberName.Location = new System.Drawing.Point(0, 344);
            this.groupAndMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.groupAndMemberName.Name = "groupAndMemberName";
            this.groupAndMemberName.Size = new System.Drawing.Size(800, 106);
            this.groupAndMemberName.TabIndex = 0;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaseLabel);
            this.Controls.Add(this.BaseTextbox);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.courseSemesterForm);
            this.Controls.Add(this.groupAndMemberName);
            this.Name = "BaseDialogForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.BaseDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private groupAndMemberName groupAndMemberName;
        private CourseSemesterForm courseSemesterForm;
        private Panel CenterPanel;
        private ContextMenuStrip contextMenuStrip1;
        protected TextBox BaseTextbox;
        protected Label BaseLabel;
    }
}