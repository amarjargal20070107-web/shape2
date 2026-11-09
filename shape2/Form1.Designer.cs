namespace shape2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            penToolStripMenuItem = new ToolStripMenuItem();
            eraserToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            shapeToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            triangleToolStripMenuItem = new ToolStripMenuItem();
            lineToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnNew = new ToolStripButton();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnPen = new ToolStripButton();
            btnEraser = new ToolStripButton();
            btnColor = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnClear = new ToolStripButton();
            lblSize = new ToolStripLabel();
            cmbSize = new ToolStripComboBox();
            DrawingPanel = new Panel();
            statusStrip1 = new StatusStrip();
            lblColorStatus = new ToolStripStatusLabel();
            lblWidthStatus = new ToolStripStatusLabel();
            lblPosition = new ToolStripStatusLabel();
            menuStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            DrawingPanel.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem, shapeToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(982, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(126, 26);
            newToolStripMenuItem.Text = "new";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(126, 26);
            openToolStripMenuItem.Text = "open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(126, 26);
            saveToolStripMenuItem.Text = "save";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(126, 26);
            undoToolStripMenuItem.Text = "undo";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(126, 26);
            clearToolStripMenuItem.Text = "clear";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { penToolStripMenuItem, eraserToolStripMenuItem, colorToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // penToolStripMenuItem
            // 
            penToolStripMenuItem.Name = "penToolStripMenuItem";
            penToolStripMenuItem.Size = new Size(132, 26);
            penToolStripMenuItem.Text = "pen";
            // 
            // eraserToolStripMenuItem
            // 
            eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            eraserToolStripMenuItem.Size = new Size(132, 26);
            eraserToolStripMenuItem.Text = "eraser";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(132, 26);
            colorToolStripMenuItem.Text = "color";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(131, 26);
            aboutToolStripMenuItem.Text = "about";
            // 
            // shapeToolStripMenuItem
            // 
            shapeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { circleToolStripMenuItem, rectangleToolStripMenuItem, triangleToolStripMenuItem, lineToolStripMenuItem });
            shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            shapeToolStripMenuItem.Size = new Size(64, 24);
            shapeToolStripMenuItem.Text = "Shape";
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(224, 26);
            circleToolStripMenuItem.Text = "Дугуй";
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(224, 26);
            rectangleToolStripMenuItem.Text = "Тэгш өнцөгт";
            // 
            // triangleToolStripMenuItem
            // 
            triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            triangleToolStripMenuItem.Size = new Size(224, 26);
            triangleToolStripMenuItem.Text = "Гурвалжин";
            // 
            // lineToolStripMenuItem
            // 
            lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            lineToolStripMenuItem.Size = new Size(224, 26);
            lineToolStripMenuItem.Text = "Шулуун";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNew, btnOpen, btnSave, toolStripSeparator1, btnPen, btnEraser, btnColor, toolStripSeparator2, btnClear, lblSize, cmbSize });
            toolStrip1.Location = new Point(0, 52);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(982, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            btnNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(43, 25);
            btnNew.Text = "New";
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(49, 25);
            btnOpen.Text = "Open";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(44, 25);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnPen
            // 
            btnPen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnPen.Image = (Image)resources.GetObject("btnPen.Image");
            btnPen.ImageTransparentColor = Color.Magenta;
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(36, 25);
            btnPen.Text = "Pen";
            // 
            // btnEraser
            // 
            btnEraser.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEraser.Image = (Image)resources.GetObject("btnEraser.Image");
            btnEraser.ImageTransparentColor = Color.Magenta;
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(53, 25);
            btnEraser.Text = "Eraser";
            // 
            // btnColor
            // 
            btnColor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnColor.Image = (Image)resources.GetObject("btnColor.Image");
            btnColor.ImageTransparentColor = Color.Magenta;
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(49, 25);
            btnColor.Text = "Color";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 25);
            btnClear.Text = "Clear";
            // 
            // lblSize
            // 
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(39, 25);
            lblSize.Text = "Size;";
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.Items.AddRange(new object[] { "1 ", "3", "5", "8", "12", "20" });
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(121, 28);
            // 
            // DrawingPanel
            // 
            DrawingPanel.BorderStyle = BorderStyle.FixedSingle;
            DrawingPanel.Controls.Add(statusStrip1);
            DrawingPanel.Dock = DockStyle.Fill;
            DrawingPanel.Location = new Point(0, 80);
            DrawingPanel.Name = "DrawingPanel";
            DrawingPanel.Size = new Size(982, 523);
            DrawingPanel.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblColorStatus, lblWidthStatus, lblPosition });
            statusStrip1.Location = new Point(0, 495);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(980, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblColorStatus
            // 
            lblColorStatus.Name = "lblColorStatus";
            lblColorStatus.Size = new Size(71, 20);
            lblColorStatus.Text = "Өнгө:хар";
            // 
            // lblWidthStatus
            // 
            lblWidthStatus.Name = "lblWidthStatus";
            lblWidthStatus.Size = new Size(80, 20);
            lblWidthStatus.Text = "Өргөн:3px";
            // 
            // lblPosition
            // 
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(52, 20);
            lblPosition.Text = "X:0 Y:0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(DrawingPanel);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyPaint";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            DrawingPanel.ResumeLayout(false);
            DrawingPanel.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem penToolStripMenuItem;
        private ToolStripMenuItem eraserToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNew;
        private ToolStripButton btnOpen;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnPen;
        private ToolStripButton btnEraser;
        private ToolStripButton btnColor;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnClear;
        private ToolStripLabel lblSize;
        private ToolStripComboBox cmbSize;
        private Panel DrawingPanel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblColorStatus;
        private ToolStripStatusLabel lblWidthStatus;
        private ToolStripStatusLabel lblPosition;
        private ToolStripMenuItem shapeToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripMenuItem lineToolStripMenuItem;
    }
}
