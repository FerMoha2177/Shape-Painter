namespace Assignment6
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidPenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDashedPenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compoundPenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidBrushMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchBrushMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearGradientBrushMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.NewBtn = new System.Windows.Forms.ToolStripButton();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RectangleButton = new System.Windows.Forms.ToolStripButton();
            this.OvalButton = new System.Windows.Forms.ToolStripButton();
            this.CustomShapeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PenTypeSplitBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDashedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrushTypeSplitBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.solidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PenBrushColorSplitBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.penColorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.brushColorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapeMenuItem,
            this.penMenuItem,
            this.brushMenuItem,
            this.windowToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 24);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click_1);
            // 
            // shapeMenuItem
            // 
            this.shapeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipseToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.customToolStripMenuItem});
            this.shapeMenuItem.Name = "shapeMenuItem";
            this.shapeMenuItem.Size = new System.Drawing.Size(51, 20);
            this.shapeMenuItem.Text = "Shape";
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // penMenuItem
            // 
            this.penMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidPenMenuItem,
            this.customDashedPenMenuItem,
            this.compoundPenMenuItem});
            this.penMenuItem.Name = "penMenuItem";
            this.penMenuItem.Size = new System.Drawing.Size(39, 20);
            this.penMenuItem.Text = "Pen";
            // 
            // solidPenMenuItem
            // 
            this.solidPenMenuItem.Name = "solidPenMenuItem";
            this.solidPenMenuItem.Size = new System.Drawing.Size(157, 22);
            this.solidPenMenuItem.Text = "Solid";
            this.solidPenMenuItem.Click += new System.EventHandler(this.solidPenMenuItem_Click);
            // 
            // customDashedPenMenuItem
            // 
            this.customDashedPenMenuItem.Name = "customDashedPenMenuItem";
            this.customDashedPenMenuItem.Size = new System.Drawing.Size(157, 22);
            this.customDashedPenMenuItem.Text = "Custom dashed";
            this.customDashedPenMenuItem.Click += new System.EventHandler(this.customDashedPenMenuItem_Click);
            // 
            // compoundPenMenuItem
            // 
            this.compoundPenMenuItem.Name = "compoundPenMenuItem";
            this.compoundPenMenuItem.Size = new System.Drawing.Size(157, 22);
            this.compoundPenMenuItem.Text = "Compound";
            this.compoundPenMenuItem.Click += new System.EventHandler(this.compoundPenMenuItem_Click);
            // 
            // brushMenuItem
            // 
            this.brushMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidBrushMenuItem,
            this.hatchBrushMenuItem,
            this.linearGradientBrushMenuItem});
            this.brushMenuItem.Name = "brushMenuItem";
            this.brushMenuItem.Size = new System.Drawing.Size(49, 20);
            this.brushMenuItem.Text = "Brush";
            // 
            // solidBrushMenuItem
            // 
            this.solidBrushMenuItem.Name = "solidBrushMenuItem";
            this.solidBrushMenuItem.Size = new System.Drawing.Size(153, 22);
            this.solidBrushMenuItem.Text = "Solid";
            this.solidBrushMenuItem.Click += new System.EventHandler(this.solidBrushMenuItem_Click);
            // 
            // hatchBrushMenuItem
            // 
            this.hatchBrushMenuItem.Name = "hatchBrushMenuItem";
            this.hatchBrushMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hatchBrushMenuItem.Text = "Hatch";
            this.hatchBrushMenuItem.Click += new System.EventHandler(this.hatchBrushMenuItem_Click);
            // 
            // linearGradientBrushMenuItem
            // 
            this.linearGradientBrushMenuItem.Name = "linearGradientBrushMenuItem";
            this.linearGradientBrushMenuItem.Size = new System.Drawing.Size(153, 22);
            this.linearGradientBrushMenuItem.Text = "Linear gradient";
            this.linearGradientBrushMenuItem.Click += new System.EventHandler(this.linearGradientBrushMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penColorToolStripMenuItem,
            this.brushColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // penColorToolStripMenuItem
            // 
            this.penColorToolStripMenuItem.Name = "penColorToolStripMenuItem";
            this.penColorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.penColorToolStripMenuItem.Text = "Pen Color";
            this.penColorToolStripMenuItem.Click += new System.EventHandler(this.PenColorToolStripMenuItem_Click_1);
            // 
            // brushColorToolStripMenuItem
            // 
            this.brushColorToolStripMenuItem.Name = "brushColorToolStripMenuItem";
            this.brushColorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.brushColorToolStripMenuItem.Text = "Brush Color";
            this.brushColorToolStripMenuItem.Click += new System.EventHandler(this.BrushColorToolStripMenuItem_Click);
            // 
            // shapeOptionsToolStripMenuItem
            // 
            this.shapeOptionsToolStripMenuItem.Name = "shapeOptionsToolStripMenuItem";
            this.shapeOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shapeOptionsToolStripMenuItem.Text = "Shape Options";
            this.shapeOptionsToolStripMenuItem.Click += new System.EventHandler(this.ShapeOptionsToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBtn,
            this.OpenFileButton,
            this.SaveFileButton,
            this.toolStripSeparator1,
            this.RectangleButton,
            this.OvalButton,
            this.CustomShapeBtn,
            this.toolStripSeparator2,
            this.PenTypeSplitBtn,
            this.BrushTypeSplitBtn,
            this.PenBrushColorSplitBtn,
            this.toolStripSeparator4});
            this.toolStrip.Location = new System.Drawing.Point(0, 48);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // NewBtn
            // 
            this.NewBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewBtn.Image = global::Assignment6.Properties.Resources.icons8_new_file_64;
            this.NewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(23, 22);
            this.NewBtn.Text = "New File";
            this.NewBtn.ToolTipText = "New File";
            this.NewBtn.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileButton.Image = global::Assignment6.Properties.Resources.icons8_import_50;
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(23, 22);
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.ToolTipText = "Open File";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileButton.Image = global::Assignment6.Properties.Resources.icons8_save_50;
            this.SaveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(23, 22);
            this.SaveFileButton.Text = "Save";
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RectangleButton
            // 
            this.RectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleButton.Image = global::Assignment6.Properties.Resources.icons8_rectangle_50;
            this.RectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(23, 22);
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // OvalButton
            // 
            this.OvalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OvalButton.Image = global::Assignment6.Properties.Resources.icons8_oval_24;
            this.OvalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OvalButton.Name = "OvalButton";
            this.OvalButton.Size = new System.Drawing.Size(23, 22);
            this.OvalButton.Text = "OvalButton";
            this.OvalButton.Click += new System.EventHandler(this.OvalButton_Click);
            // 
            // CustomShapeBtn
            // 
            this.CustomShapeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CustomShapeBtn.Image = global::Assignment6.Properties.Resources.icons8_polygon_30;
            this.CustomShapeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CustomShapeBtn.Name = "CustomShapeBtn";
            this.CustomShapeBtn.Size = new System.Drawing.Size(23, 22);
            this.CustomShapeBtn.Text = "CustomShapeBtn";
            this.CustomShapeBtn.Click += new System.EventHandler(this.CustomShapeBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PenTypeSplitBtn
            // 
            this.PenTypeSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenTypeSplitBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.customDashedToolStripMenuItem,
            this.compoundToolStripMenuItem});
            this.PenTypeSplitBtn.Image = global::Assignment6.Properties.Resources.icons8_pen_50;
            this.PenTypeSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenTypeSplitBtn.Name = "PenTypeSplitBtn";
            this.PenTypeSplitBtn.Size = new System.Drawing.Size(32, 22);
            this.PenTypeSplitBtn.Text = "PenTypeSplitBtn";
            this.PenTypeSplitBtn.ToolTipText = "Select Pent Type";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.SolidToolStripMenuItem_Click);
            // 
            // customDashedToolStripMenuItem
            // 
            this.customDashedToolStripMenuItem.Name = "customDashedToolStripMenuItem";
            this.customDashedToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.customDashedToolStripMenuItem.Text = "Custom Dashed";
            this.customDashedToolStripMenuItem.Click += new System.EventHandler(this.CustomDashedToolStripMenuItem_Click);
            // 
            // compoundToolStripMenuItem
            // 
            this.compoundToolStripMenuItem.Name = "compoundToolStripMenuItem";
            this.compoundToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.compoundToolStripMenuItem.Text = "Compound";
            this.compoundToolStripMenuItem.Click += new System.EventHandler(this.CompoundToolStripMenuItem_Click);
            // 
            // BrushTypeSplitBtn
            // 
            this.BrushTypeSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BrushTypeSplitBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem1,
            this.hatchedToolStripMenuItem,
            this.linearGradientToolStripMenuItem});
            this.BrushTypeSplitBtn.Image = global::Assignment6.Properties.Resources.icons8_paint_brush_50;
            this.BrushTypeSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrushTypeSplitBtn.Name = "BrushTypeSplitBtn";
            this.BrushTypeSplitBtn.Size = new System.Drawing.Size(32, 22);
            this.BrushTypeSplitBtn.Text = "BrushTypeSplitBtn";
            this.BrushTypeSplitBtn.ToolTipText = "Select Brush Type";
            this.BrushTypeSplitBtn.ButtonClick += new System.EventHandler(this.BrushTypeSplitBtn_ButtonClick);
            // 
            // solidToolStripMenuItem1
            // 
            this.solidToolStripMenuItem1.Name = "solidToolStripMenuItem1";
            this.solidToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.solidToolStripMenuItem1.Text = "Solid";
            this.solidToolStripMenuItem1.Click += new System.EventHandler(this.SolidToolStripMenuItem1_Click);
            // 
            // hatchedToolStripMenuItem
            // 
            this.hatchedToolStripMenuItem.Name = "hatchedToolStripMenuItem";
            this.hatchedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hatchedToolStripMenuItem.Text = "Hatched";
            this.hatchedToolStripMenuItem.Click += new System.EventHandler(this.HatchedToolStripMenuItem_Click);
            // 
            // linearGradientToolStripMenuItem
            // 
            this.linearGradientToolStripMenuItem.Name = "linearGradientToolStripMenuItem";
            this.linearGradientToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.linearGradientToolStripMenuItem.Text = "Linear Gradient";
            this.linearGradientToolStripMenuItem.Click += new System.EventHandler(this.LinearGradientToolStripMenuItem_Click);
            // 
            // PenBrushColorSplitBtn
            // 
            this.PenBrushColorSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenBrushColorSplitBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penColorToolStripMenuItem2,
            this.brushColorToolStripMenuItem2});
            this.PenBrushColorSplitBtn.Image = global::Assignment6.Properties.Resources.icons8_paint_palette_50;
            this.PenBrushColorSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenBrushColorSplitBtn.Name = "PenBrushColorSplitBtn";
            this.PenBrushColorSplitBtn.Size = new System.Drawing.Size(32, 22);
            this.PenBrushColorSplitBtn.Text = "PenBrushColorSplitBtn";
            this.PenBrushColorSplitBtn.ToolTipText = "Select the Pen or Brush Icone to change their colors";
            // 
            // penColorToolStripMenuItem2
            // 
            this.penColorToolStripMenuItem2.Image = global::Assignment6.Properties.Resources.icons8_pen_48;
            this.penColorToolStripMenuItem2.Name = "penColorToolStripMenuItem2";
            this.penColorToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.penColorToolStripMenuItem2.Text = "Pen Color";
            this.penColorToolStripMenuItem2.Click += new System.EventHandler(this.PenColorToolStripMenuItem2_Click);
            // 
            // brushColorToolStripMenuItem2
            // 
            this.brushColorToolStripMenuItem2.Image = global::Assignment6.Properties.Resources.icons8_paint_50;
            this.brushColorToolStripMenuItem2.Name = "brushColorToolStripMenuItem2";
            this.brushColorToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.brushColorToolStripMenuItem2.Text = "Brush Color";
            this.brushColorToolStripMenuItem2.Click += new System.EventHandler(this.BrushColorToolStripMenuItem2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.Controls.SetChildIndex(this.mainMenuStrip, 0);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem shapeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penMenuItem;

        private System.Windows.Forms.ToolStripMenuItem solidPenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customDashedPenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compoundPenMenuItem;

        private System.Windows.Forms.ToolStripMenuItem brushMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidBrushMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchBrushMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearGradientBrushMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushColorToolStripMenuItem;
        //private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        //private System.Windows.Forms.ToolStripMenuItem shapeOptionsToolStripMenuItem1;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
        private System.Windows.Forms.ToolStripMenuItem shapeOptionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        private System.Windows.Forms.ToolStripMenuItem oathAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton NewBtn;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripButton SaveFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RectangleButton;
        private System.Windows.Forms.ToolStripButton OvalButton;
        private System.Windows.Forms.ToolStripButton CustomShapeBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton PenTypeSplitBtn;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customDashedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton BrushTypeSplitBtn;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hatchedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton PenBrushColorSplitBtn;
        private System.Windows.Forms.ToolStripMenuItem penColorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem brushColorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

