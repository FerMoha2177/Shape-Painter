namespace Assignment6
{
    partial class ShapeDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeDialog));
            this.SolidCheckBox = new System.Windows.Forms.CheckBox();
            this.DashedCheckBox = new System.Windows.Forms.CheckBox();
            this.CompoundCheckBox = new System.Windows.Forms.CheckBox();
            this.PenLabel = new System.Windows.Forms.Label();
            this.BrushLabel = new System.Windows.Forms.Label();
            this.LinearGradientCheckBox = new System.Windows.Forms.CheckBox();
            this.SolidBrushCheckBox = new System.Windows.Forms.CheckBox();
            this.HatchedCheckBox = new System.Windows.Forms.CheckBox();
            this.PenColorLabel = new System.Windows.Forms.Label();
            this.BrushColorLabel = new System.Windows.Forms.Label();
            this.PenColorButton = new System.Windows.Forms.Button();
            this.BrushColorButton = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeWidthLabel = new System.Windows.Forms.Label();
            this.SizeHeightLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationYLabel = new System.Windows.Forms.Label();
            this.LocationXLabel = new System.Windows.Forms.Label();
            this.SizeWidthText = new System.Windows.Forms.TextBox();
            this.SizeHeightText = new System.Windows.Forms.TextBox();
            this.LocationXText = new System.Windows.Forms.TextBox();
            this.LocationYText = new System.Windows.Forms.TextBox();
            this.ShapeNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OKButton = new System.Windows.Forms.Button();
            this.PenBindingLabel = new System.Windows.Forms.Label();
            this.BrushBindingLabel = new System.Windows.Forms.Label();
            this.shapeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ShapeNavigator)).BeginInit();
            this.ShapeNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SolidCheckBox
            // 
            this.SolidCheckBox.AutoSize = true;
            this.SolidCheckBox.Location = new System.Drawing.Point(56, 163);
            this.SolidCheckBox.Name = "SolidCheckBox";
            this.SolidCheckBox.Size = new System.Drawing.Size(49, 17);
            this.SolidCheckBox.TabIndex = 3;
            this.SolidCheckBox.Text = "Solid";
            this.SolidCheckBox.UseVisualStyleBackColor = true;
            this.SolidCheckBox.Click += new System.EventHandler(this.SolidCheckBox_Click);
            // 
            // DashedCheckBox
            // 
            this.DashedCheckBox.AutoSize = true;
            this.DashedCheckBox.Location = new System.Drawing.Point(142, 163);
            this.DashedCheckBox.Name = "DashedCheckBox";
            this.DashedCheckBox.Size = new System.Drawing.Size(63, 17);
            this.DashedCheckBox.TabIndex = 4;
            this.DashedCheckBox.Text = "Dashed";
            this.DashedCheckBox.UseVisualStyleBackColor = true;
            this.DashedCheckBox.Click += new System.EventHandler(this.DashedCheckBox_Click);
            // 
            // CompoundCheckBox
            // 
            this.CompoundCheckBox.AutoSize = true;
            this.CompoundCheckBox.Location = new System.Drawing.Point(228, 163);
            this.CompoundCheckBox.Name = "CompoundCheckBox";
            this.CompoundCheckBox.Size = new System.Drawing.Size(77, 17);
            this.CompoundCheckBox.TabIndex = 5;
            this.CompoundCheckBox.Text = "Compound";
            this.CompoundCheckBox.UseVisualStyleBackColor = true;
            this.CompoundCheckBox.Click += new System.EventHandler(this.CompoundCheckBox_Click);
            // 
            // PenLabel
            // 
            this.PenLabel.AutoSize = true;
            this.PenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenLabel.Location = new System.Drawing.Point(138, 127);
            this.PenLabel.Name = "PenLabel";
            this.PenLabel.Size = new System.Drawing.Size(41, 20);
            this.PenLabel.TabIndex = 6;
            this.PenLabel.Text = "Pen:";
            // 
            // BrushLabel
            // 
            this.BrushLabel.AutoSize = true;
            this.BrushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrushLabel.Location = new System.Drawing.Point(439, 127);
            this.BrushLabel.Name = "BrushLabel";
            this.BrushLabel.Size = new System.Drawing.Size(55, 20);
            this.BrushLabel.TabIndex = 7;
            this.BrushLabel.Text = "Brush:";
            // 
            // LinearGradientCheckBox
            // 
            this.LinearGradientCheckBox.AutoSize = true;
            this.LinearGradientCheckBox.Location = new System.Drawing.Point(357, 163);
            this.LinearGradientCheckBox.Name = "LinearGradientCheckBox";
            this.LinearGradientCheckBox.Size = new System.Drawing.Size(98, 17);
            this.LinearGradientCheckBox.TabIndex = 8;
            this.LinearGradientCheckBox.Text = "Linear Gradient";
            this.LinearGradientCheckBox.UseVisualStyleBackColor = true;
            this.LinearGradientCheckBox.Click += new System.EventHandler(this.LinearGradientCheckBox_Click);
            // 
            // SolidBrushCheckBox
            // 
            this.SolidBrushCheckBox.AutoSize = true;
            this.SolidBrushCheckBox.Location = new System.Drawing.Point(461, 163);
            this.SolidBrushCheckBox.Name = "SolidBrushCheckBox";
            this.SolidBrushCheckBox.Size = new System.Drawing.Size(49, 17);
            this.SolidBrushCheckBox.TabIndex = 9;
            this.SolidBrushCheckBox.Text = "Solid";
            this.SolidBrushCheckBox.UseVisualStyleBackColor = true;
            this.SolidBrushCheckBox.Click += new System.EventHandler(this.SolidBrushCheckBox_Click);
            // 
            // HatchedCheckBox
            // 
            this.HatchedCheckBox.AutoSize = true;
            this.HatchedCheckBox.Location = new System.Drawing.Point(529, 163);
            this.HatchedCheckBox.Name = "HatchedCheckBox";
            this.HatchedCheckBox.Size = new System.Drawing.Size(67, 17);
            this.HatchedCheckBox.TabIndex = 10;
            this.HatchedCheckBox.Text = "Hatched";
            this.HatchedCheckBox.UseVisualStyleBackColor = true;
            this.HatchedCheckBox.Click += new System.EventHandler(this.HatchedCheckBox_Click);
            // 
            // PenColorLabel
            // 
            this.PenColorLabel.AutoSize = true;
            this.PenColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenColorLabel.Location = new System.Drawing.Point(27, 215);
            this.PenColorLabel.Name = "PenColorLabel";
            this.PenColorLabel.Size = new System.Drawing.Size(78, 20);
            this.PenColorLabel.TabIndex = 11;
            this.PenColorLabel.Text = "Pen Color";
            // 
            // BrushColorLabel
            // 
            this.BrushColorLabel.AutoSize = true;
            this.BrushColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrushColorLabel.Location = new System.Drawing.Point(363, 215);
            this.BrushColorLabel.Name = "BrushColorLabel";
            this.BrushColorLabel.Size = new System.Drawing.Size(92, 20);
            this.BrushColorLabel.TabIndex = 12;
            this.BrushColorLabel.Text = "Brush Color";
            // 
            // PenColorButton
            // 
            this.PenColorButton.Location = new System.Drawing.Point(111, 212);
            this.PenColorButton.Name = "PenColorButton";
            this.PenColorButton.Size = new System.Drawing.Size(75, 23);
            this.PenColorButton.TabIndex = 13;
            this.PenColorButton.Text = "Change";
            this.PenColorButton.UseVisualStyleBackColor = true;
            this.PenColorButton.Click += new System.EventHandler(this.PenColorButton_Click);
            // 
            // BrushColorButton
            // 
            this.BrushColorButton.Location = new System.Drawing.Point(461, 212);
            this.BrushColorButton.Name = "BrushColorButton";
            this.BrushColorButton.Size = new System.Drawing.Size(75, 23);
            this.BrushColorButton.TabIndex = 14;
            this.BrushColorButton.Text = "Change";
            this.BrushColorButton.UseVisualStyleBackColor = true;
            this.BrushColorButton.Click += new System.EventHandler(this.BrushColorButton_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(27, 278);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(40, 20);
            this.SizeLabel.TabIndex = 15;
            this.SizeLabel.Text = "Size";
            // 
            // SizeWidthLabel
            // 
            this.SizeWidthLabel.AutoSize = true;
            this.SizeWidthLabel.Location = new System.Drawing.Point(28, 317);
            this.SizeWidthLabel.Name = "SizeWidthLabel";
            this.SizeWidthLabel.Size = new System.Drawing.Size(35, 13);
            this.SizeWidthLabel.TabIndex = 16;
            this.SizeWidthLabel.Text = "Width";
            // 
            // SizeHeightLabel
            // 
            this.SizeHeightLabel.AutoSize = true;
            this.SizeHeightLabel.Location = new System.Drawing.Point(28, 347);
            this.SizeHeightLabel.Name = "SizeHeightLabel";
            this.SizeHeightLabel.Size = new System.Drawing.Size(38, 13);
            this.SizeHeightLabel.TabIndex = 17;
            this.SizeHeightLabel.Text = "Height";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(363, 278);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(70, 20);
            this.LocationLabel.TabIndex = 18;
            this.LocationLabel.Text = "Location";
            // 
            // LocationYLabel
            // 
            this.LocationYLabel.AutoSize = true;
            this.LocationYLabel.Location = new System.Drawing.Point(364, 347);
            this.LocationYLabel.Name = "LocationYLabel";
            this.LocationYLabel.Size = new System.Drawing.Size(14, 13);
            this.LocationYLabel.TabIndex = 19;
            this.LocationYLabel.Text = "Y";
            // 
            // LocationXLabel
            // 
            this.LocationXLabel.AutoSize = true;
            this.LocationXLabel.Location = new System.Drawing.Point(364, 317);
            this.LocationXLabel.Name = "LocationXLabel";
            this.LocationXLabel.Size = new System.Drawing.Size(14, 13);
            this.LocationXLabel.TabIndex = 20;
            this.LocationXLabel.Text = "X";
            // 
            // SizeWidthText
            // 
            this.SizeWidthText.Location = new System.Drawing.Point(72, 314);
            this.SizeWidthText.Name = "SizeWidthText";
            this.SizeWidthText.Size = new System.Drawing.Size(100, 20);
            this.SizeWidthText.TabIndex = 21;
            this.SizeWidthText.TextChanged += new System.EventHandler(this.SizeWidthText_TextChanged);
            // 
            // SizeHeightText
            // 
            this.SizeHeightText.Location = new System.Drawing.Point(72, 344);
            this.SizeHeightText.Name = "SizeHeightText";
            this.SizeHeightText.Size = new System.Drawing.Size(100, 20);
            this.SizeHeightText.TabIndex = 22;
            this.SizeHeightText.TextChanged += new System.EventHandler(this.SizeHeightText_TextChanged);
            // 
            // LocationXText
            // 
            this.LocationXText.Location = new System.Drawing.Point(384, 310);
            this.LocationXText.Name = "LocationXText";
            this.LocationXText.Size = new System.Drawing.Size(100, 20);
            this.LocationXText.TabIndex = 23;
            this.LocationXText.TextAlignChanged += new System.EventHandler(this.LocationXText_TextAlignChanged);
            // 
            // LocationYText
            // 
            this.LocationYText.Location = new System.Drawing.Point(384, 347);
            this.LocationYText.Name = "LocationYText";
            this.LocationYText.Size = new System.Drawing.Size(100, 20);
            this.LocationYText.TabIndex = 24;
            this.LocationYText.TextChanged += new System.EventHandler(this.LocationYText_TextChanged);
            // 
            // ShapeNavigator
            // 
            this.ShapeNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ShapeNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ShapeNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ShapeNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ShapeNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.ShapeNavigator.Location = new System.Drawing.Point(0, 0);
            this.ShapeNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ShapeNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ShapeNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ShapeNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ShapeNavigator.Name = "ShapeNavigator";
            this.ShapeNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ShapeNavigator.Size = new System.Drawing.Size(800, 27);
            this.ShapeNavigator.TabIndex = 25;
            this.ShapeNavigator.Text = "Shape Navigator";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.moveFirstButton_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.movePreviousButton_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.moveNextButton_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.moveLastButton_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(682, 398);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(107, 41);
            this.OKButton.TabIndex = 26;
            this.OKButton.Text = "Apply";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PenBindingLabel
            // 
            this.PenBindingLabel.AutoSize = true;
            this.PenBindingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenBindingLabel.Location = new System.Drawing.Point(185, 127);
            this.PenBindingLabel.Name = "PenBindingLabel";
            this.PenBindingLabel.Size = new System.Drawing.Size(44, 20);
            this.PenBindingLabel.TabIndex = 27;
            this.PenBindingLabel.Text = "Solid";
            // 
            // BrushBindingLabel
            // 
            this.BrushBindingLabel.AutoSize = true;
            this.BrushBindingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrushBindingLabel.Location = new System.Drawing.Point(500, 127);
            this.BrushBindingLabel.Name = "BrushBindingLabel";
            this.BrushBindingLabel.Size = new System.Drawing.Size(44, 20);
            this.BrushBindingLabel.TabIndex = 28;
            this.BrushBindingLabel.Text = "Solid";
            // 
            // shapeBindingSource
            // 
            this.shapeBindingSource.DataSource = typeof(Assignment6.Shape);
            // 
            // ShapeDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrushBindingLabel);
            this.Controls.Add(this.PenBindingLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ShapeNavigator);
            this.Controls.Add(this.LocationYText);
            this.Controls.Add(this.LocationXText);
            this.Controls.Add(this.SizeHeightText);
            this.Controls.Add(this.SizeWidthText);
            this.Controls.Add(this.LocationXLabel);
            this.Controls.Add(this.LocationYLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.SizeHeightLabel);
            this.Controls.Add(this.SizeWidthLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.BrushColorButton);
            this.Controls.Add(this.PenColorButton);
            this.Controls.Add(this.BrushColorLabel);
            this.Controls.Add(this.PenColorLabel);
            this.Controls.Add(this.HatchedCheckBox);
            this.Controls.Add(this.SolidBrushCheckBox);
            this.Controls.Add(this.LinearGradientCheckBox);
            this.Controls.Add(this.BrushLabel);
            this.Controls.Add(this.PenLabel);
            this.Controls.Add(this.CompoundCheckBox);
            this.Controls.Add(this.DashedCheckBox);
            this.Controls.Add(this.SolidCheckBox);
            this.Name = "ShapeDialog";
            this.Text = "ShapeDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShapeDialog_FormClosed);
            this.Load += new System.EventHandler(this.ShapeDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShapeNavigator)).EndInit();
            this.ShapeNavigator.ResumeLayout(false);
            this.ShapeNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox SolidCheckBox;
        private System.Windows.Forms.CheckBox DashedCheckBox;
        private System.Windows.Forms.CheckBox CompoundCheckBox;
        private System.Windows.Forms.Label PenLabel;
        private System.Windows.Forms.Label BrushLabel;
        private System.Windows.Forms.CheckBox LinearGradientCheckBox;
        private System.Windows.Forms.CheckBox SolidBrushCheckBox;
        private System.Windows.Forms.CheckBox HatchedCheckBox;
        private System.Windows.Forms.Label PenColorLabel;
        private System.Windows.Forms.Label BrushColorLabel;
        private System.Windows.Forms.Button PenColorButton;
        private System.Windows.Forms.Button BrushColorButton;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label SizeWidthLabel;
        private System.Windows.Forms.Label SizeHeightLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label LocationYLabel;
        private System.Windows.Forms.Label LocationXLabel;
        private System.Windows.Forms.TextBox SizeWidthText;
        private System.Windows.Forms.TextBox SizeHeightText;
        private System.Windows.Forms.TextBox LocationXText;
        private System.Windows.Forms.TextBox LocationYText;
        private System.Windows.Forms.BindingNavigator ShapeNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource shapeBindingSource;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label PenBindingLabel;
        private System.Windows.Forms.Label BrushBindingLabel;
    }
}