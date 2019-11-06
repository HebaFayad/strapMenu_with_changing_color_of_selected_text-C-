namespace lab_5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.men_new = new System.Windows.Forms.ToolStripMenuItem();
            this.men_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.men_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.men_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.men_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.men_PrintPer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.men_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.men_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.men_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.men_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.men_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.men_Past = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.men_Selecall = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.men_font = new System.Windows.Forms.ToolStripMenuItem();
            this.men_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.men_fontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.men_backColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Rtxt_file = new System.Windows.Forms.RichTextBox();
            this.Font_D = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TS_lblPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_new,
            this.men_open,
            this.toolStripSeparator,
            this.men_Save,
            this.men_SaveAs,
            this.toolStripSeparator1,
            this.men_Print,
            this.men_PrintPer,
            this.toolStripSeparator2,
            this.men_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // men_new
            // 
            this.men_new.Image = ((System.Drawing.Image)(resources.GetObject("men_new.Image")));
            this.men_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.men_new.Name = "men_new";
            this.men_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.men_new.Size = new System.Drawing.Size(152, 22);
            this.men_new.Text = "&New";
            this.men_new.Click += new System.EventHandler(this.men_new_Click);
            // 
            // men_open
            // 
            this.men_open.Image = ((System.Drawing.Image)(resources.GetObject("men_open.Image")));
            this.men_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.men_open.Name = "men_open";
            this.men_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.men_open.Size = new System.Drawing.Size(152, 22);
            this.men_open.Text = "&Open";
            this.men_open.Click += new System.EventHandler(this.men_open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // men_Save
            // 
            this.men_Save.Image = ((System.Drawing.Image)(resources.GetObject("men_Save.Image")));
            this.men_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.men_Save.Name = "men_Save";
            this.men_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.men_Save.Size = new System.Drawing.Size(152, 22);
            this.men_Save.Text = "&Save";
            // 
            // men_SaveAs
            // 
            this.men_SaveAs.Name = "men_SaveAs";
            this.men_SaveAs.Size = new System.Drawing.Size(152, 22);
            this.men_SaveAs.Text = "Save &As";
            this.men_SaveAs.Click += new System.EventHandler(this.men_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // men_Print
            // 
            this.men_Print.Image = ((System.Drawing.Image)(resources.GetObject("men_Print.Image")));
            this.men_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.men_Print.Name = "men_Print";
            this.men_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.men_Print.Size = new System.Drawing.Size(152, 22);
            this.men_Print.Text = "&Print";
            // 
            // men_PrintPer
            // 
            this.men_PrintPer.Image = ((System.Drawing.Image)(resources.GetObject("men_PrintPer.Image")));
            this.men_PrintPer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.men_PrintPer.Name = "men_PrintPer";
            this.men_PrintPer.Size = new System.Drawing.Size(152, 22);
            this.men_PrintPer.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // men_Exit
            // 
            this.men_Exit.Name = "men_Exit";
            this.men_Exit.Size = new System.Drawing.Size(152, 22);
            this.men_Exit.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_Undo,
            this.men_Redo,
            this.toolStripSeparator3,
            this.men_Cut,
            this.men_Copy,
            this.men_Past,
            this.toolStripSeparator4,
            this.men_Selecall});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // men_Undo
            // 
            this.men_Undo.Name = "men_Undo";
            this.men_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.men_Undo.Size = new System.Drawing.Size(152, 22);
            this.men_Undo.Text = "&Undo";
            // 
            // men_Redo
            // 
            this.men_Redo.Name = "men_Redo";
            this.men_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.men_Redo.Size = new System.Drawing.Size(152, 22);
            this.men_Redo.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // men_Cut
            // 
            this.men_Cut.Image = ((System.Drawing.Image)(resources.GetObject("men_Cut.Image")));
            this.men_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.men_Cut.Name = "men_Cut";
            this.men_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.men_Cut.Size = new System.Drawing.Size(152, 22);
            this.men_Cut.Text = "Cu&t";
            this.men_Cut.Click += new System.EventHandler(this.men_Cut_Click);
            // 
            // men_Copy
            // 
            this.men_Copy.Image = ((System.Drawing.Image)(resources.GetObject("men_Copy.Image")));
            this.men_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.men_Copy.Name = "men_Copy";
            this.men_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.men_Copy.Size = new System.Drawing.Size(152, 22);
            this.men_Copy.Text = "&Copy";
            // 
            // men_Past
            // 
            this.men_Past.Image = ((System.Drawing.Image)(resources.GetObject("men_Past.Image")));
            this.men_Past.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.men_Past.Name = "men_Past";
            this.men_Past.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.men_Past.Size = new System.Drawing.Size(152, 22);
            this.men_Past.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // men_Selecall
            // 
            this.men_Selecall.Name = "men_Selecall";
            this.men_Selecall.Size = new System.Drawing.Size(152, 22);
            this.men_Selecall.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_font,
            this.men_Color});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // men_font
            // 
            this.men_font.Name = "men_font";
            this.men_font.Size = new System.Drawing.Size(152, 22);
            this.men_font.Text = "Font";
            this.men_font.Click += new System.EventHandler(this.men_font_Click);
            // 
            // men_Color
            // 
            this.men_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_fontColor,
            this.men_backColor});
            this.men_Color.Name = "men_Color";
            this.men_Color.Size = new System.Drawing.Size(152, 22);
            this.men_Color.Text = "Color";
            this.men_Color.Click += new System.EventHandler(this.men_Color_Click);
            // 
            // men_fontColor
            // 
            this.men_fontColor.Name = "men_fontColor";
            this.men_fontColor.Size = new System.Drawing.Size(152, 22);
            this.men_fontColor.Text = "Font Color";
            this.men_fontColor.ToolTipText = "This select can change color font";
            this.men_fontColor.Click += new System.EventHandler(this.men_fontColor_Click);
            // 
            // men_backColor
            // 
            this.men_backColor.Name = "men_backColor";
            this.men_backColor.Size = new System.Drawing.Size(152, 22);
            this.men_backColor.Text = "Back Color";
            this.men_backColor.Click += new System.EventHandler(this.men_backColor_Click);
            // 
            // Rtxt_file
            // 
            this.Rtxt_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtxt_file.Location = new System.Drawing.Point(0, 24);
            this.Rtxt_file.Name = "Rtxt_file";
            this.Rtxt_file.Size = new System.Drawing.Size(539, 353);
            this.Rtxt_file.TabIndex = 1;
            this.Rtxt_file.Text = "";
            this.Rtxt_file.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_lblPath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(539, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TS_lblPath
            // 
            this.TS_lblPath.Name = "TS_lblPath";
            this.TS_lblPath.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 377);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Rtxt_file);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem men_new;
        private System.Windows.Forms.ToolStripMenuItem men_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem men_Save;
        private System.Windows.Forms.ToolStripMenuItem men_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem men_Print;
        private System.Windows.Forms.ToolStripMenuItem men_PrintPer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem men_Exit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem men_Undo;
        private System.Windows.Forms.ToolStripMenuItem men_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem men_Cut;
        private System.Windows.Forms.ToolStripMenuItem men_Copy;
        private System.Windows.Forms.ToolStripMenuItem men_Past;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem men_Selecall;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem men_font;
        private System.Windows.Forms.ToolStripMenuItem men_Color;
        private System.Windows.Forms.ToolStripMenuItem men_fontColor;
        private System.Windows.Forms.ToolStripMenuItem men_backColor;
        private System.Windows.Forms.RichTextBox Rtxt_file;
        private System.Windows.Forms.FontDialog Font_D;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TS_lblPath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

