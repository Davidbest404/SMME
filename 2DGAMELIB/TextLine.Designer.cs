namespace _2DGAMELIB
{
	public partial class TextLine : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_2DGAMELIB.TextLine));
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmenuTop = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmenuBottom = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.cmenuUndo = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmenuRedo = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.cmenuTrim = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmenuCopy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmenuPaste = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmenuDelete = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.cmenuAllSelect = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuFile = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuNewSave = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOverwriteSave = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menueEdit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuFindReplace = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuForm = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuTurn = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuFont = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuData = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuGetData = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuSetData = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.fontDialog1 = new global::System.Windows.Forms.FontDialog();
			this.statusStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.saveFileDialog1.Filter = "Text (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
			this.saveFileDialog1.InitialDirectory = "C:\\";
			this.saveFileDialog1.Title = "Save As";
			this.saveFileDialog1.FileOk += new global::System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1,
				this.toolStripStatusLabel2
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 246);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(292, 27);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.BorderSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.All;
			this.toolStripStatusLabel1.BorderStyle = global::System.Windows.Forms.Border3DStyle.Sunken;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(223, 22);
			this.toolStripStatusLabel1.Spring = true;
			this.toolStripStatusLabel1.Text = "Status";
			this.toolStripStatusLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripStatusLabel2.BorderSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.All;
			this.toolStripStatusLabel2.BorderStyle = global::System.Windows.Forms.Border3DStyle.Sunken;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new global::System.Drawing.Size(54, 22);
			this.toolStripStatusLabel2.Text = "y:1,x:1";
			this.toolStripStatusLabel2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.contextMenuStrip1.BackColor = global::System.Drawing.SystemColors.Menu;
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cmenuTop,
				this.cmenuBottom,
				this.toolStripMenuItem1,
				this.cmenuUndo,
				this.cmenuRedo,
				this.toolStripMenuItem2,
				this.cmenuTrim,
				this.cmenuCopy,
				this.cmenuPaste,
				this.cmenuDelete,
				this.toolStripMenuItem3,
				this.cmenuAllSelect,
				this.toolStripMenuItem4
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.ShowImageMargin = false;
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(119, 222);
			this.contextMenuStrip1.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			this.cmenuTop.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmenuTop.Name = "cmenuTop";
			this.cmenuTop.Padding = new global::System.Windows.Forms.Padding(0);
			this.cmenuTop.Size = new global::System.Drawing.Size(118, 20);
			this.cmenuTop.Text = "Top";
			this.cmenuTop.Click += new global::System.EventHandler(this.cmenuTop_Click);
			this.cmenuBottom.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmenuBottom.Name = "cmenuBottom";
			this.cmenuBottom.Padding = new global::System.Windows.Forms.Padding(0);
			this.cmenuBottom.Size = new global::System.Drawing.Size(118, 20);
			this.cmenuBottom.Text = "Bottom";
			this.cmenuBottom.Click += new global::System.EventHandler(this.cmenuBottom_Click);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(115, 6);
			this.cmenuUndo.BackColor = global::System.Drawing.SystemColors.Menu;
			this.cmenuUndo.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmenuUndo.Name = "cmenuUndo";
			this.cmenuUndo.Padding = new global::System.Windows.Forms.Padding(0);
			this.cmenuUndo.Size = new global::System.Drawing.Size(118, 20);
			this.cmenuUndo.Text = "Undo";
			this.cmenuUndo.Click += new global::System.EventHandler(this.cmenuUndo_Click);
			this.cmenuRedo.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmenuRedo.Name = "cmenuRedo";
			this.cmenuRedo.Padding = new global::System.Windows.Forms.Padding(0);
			this.cmenuRedo.Size = new global::System.Drawing.Size(118, 20);
			this.cmenuRedo.Text = "Redo";
			this.cmenuRedo.Click += new global::System.EventHandler(this.cmenuRedo_Click);
			this.toolStripMenuItem2.BackColor = global::System.Drawing.SystemColors.Menu;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new global::System.Drawing.Size(115, 6);
			this.cmenuTrim.BackColor = global::System.Drawing.SystemColors.Menu;
			this.cmenuTrim.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmenuTrim.Name = "cmenuTrim";
			this.cmenuTrim.Padding = new global::System.Windows.Forms.Padding(0);
			this.cmenuTrim.Size = new global::System.Drawing.Size(118, 20);
			this.cmenuTrim.Text = "Cut";
			this.cmenuTrim.Click += new global::System.EventHandler(this.cmenuTrim_Click);
			this.cmenuCopy.BackColor = global::System.Drawing.SystemColors.Menu;
			this.cmenuCopy.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmenuCopy.Name = "cmenuCopy";
			this.cmenuCopy.Padding = new global::System.Windows.Forms.Padding(0);
			this.cmenuCopy.Size = new global::System.Drawing.Size(118, 20);
			this.cmenuCopy.Text = "Copy";
			this.cmenuCopy.Click += new global::System.EventHandler(this.cmenuCopy_Click);
			this.cmenuPaste.BackColor = global::System.Drawing.SystemColors.Menu;
			this.cmenuPaste.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmenuPaste.Name = "cmenuPaste";
			this.cmenuPaste.Padding = new global::System.Windows.Forms.Padding(0);
			this.cmenuPaste.Size = new global::System.Drawing.Size(118, 20);
			this.cmenuPaste.Text = "Paste";
			this.cmenuPaste.Click += new global::System.EventHandler(this.cmenuPaste_Click);
			this.cmenuDelete.BackColor = global::System.Drawing.SystemColors.Menu;
			this.cmenuDelete.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmenuDelete.Name = "cmenuDelete";
			this.cmenuDelete.Padding = new global::System.Windows.Forms.Padding(0);
			this.cmenuDelete.Size = new global::System.Drawing.Size(118, 20);
			this.cmenuDelete.Text = "Delete";
			this.cmenuDelete.Click += new global::System.EventHandler(this.cmenuDelete_Click);
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new global::System.Drawing.Size(115, 6);
			this.cmenuAllSelect.BackColor = global::System.Drawing.SystemColors.Menu;
			this.cmenuAllSelect.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmenuAllSelect.Name = "cmenuAllSelect";
			this.cmenuAllSelect.Padding = new global::System.Windows.Forms.Padding(0);
			this.cmenuAllSelect.Size = new global::System.Drawing.Size(118, 20);
			this.cmenuAllSelect.Text = "Select All";
			this.cmenuAllSelect.Click += new global::System.EventHandler(this.cmenuAllSelect_Click);
			this.toolStripMenuItem4.BackColor = global::System.Drawing.SystemColors.Menu;
			this.toolStripMenuItem4.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Padding = new global::System.Windows.Forms.Padding(0);
			this.toolStripMenuItem4.Size = new global::System.Drawing.Size(118, 20);
			this.toolStripMenuItem4.Text = "Clear";
			this.toolStripMenuItem4.Click += new global::System.EventHandler(this.toolStripMenuItem4_Click);
			this.menuFile.BackColor = global::System.Drawing.SystemColors.Control;
			this.menuFile.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuFile.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.menuOverwriteSave,
				this.menuNewSave
			});
			this.menuFile.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuFile.Margin = new global::System.Windows.Forms.Padding(2, 0, 3, 0);
			this.menuFile.Name = "menuFile";
			this.menuFile.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuFile.Size = new global::System.Drawing.Size(58, 16);
			this.menuFile.Text = "File";
			this.menuNewSave.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menuNewSave.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuNewSave.Name = "menuNewSave";
			this.menuNewSave.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuNewSave.Size = new global::System.Drawing.Size(172, 20);
			this.menuNewSave.Text = "Save As...";
			this.menuNewSave.Click += new global::System.EventHandler(this.menuNewSave_Click);
			this.menuOverwriteSave.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menuOverwriteSave.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuOverwriteSave.Enabled = false;
			this.menuOverwriteSave.Name = "menuOverwriteSave";
			this.menuOverwriteSave.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuOverwriteSave.ShortcutKeys = (global::System.Windows.Forms.Keys)131155;
			this.menuOverwriteSave.Size = new global::System.Drawing.Size(172, 20);
			this.menuOverwriteSave.Text = "Save";
			this.menuOverwriteSave.Click += new global::System.EventHandler(this.menuOverwriteSave_Click);
			this.menueEdit.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menueEdit.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menueEdit.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.menuFindReplace
			});
			this.menueEdit.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menueEdit.Margin = new global::System.Windows.Forms.Padding(2, 0, 3, 0);
			this.menueEdit.Name = "menueEdit";
			this.menueEdit.Padding = new global::System.Windows.Forms.Padding(0);
			this.menueEdit.Size = new global::System.Drawing.Size(48, 16);
			this.menueEdit.Text = "Edit";
			this.menuFindReplace.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menuFindReplace.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuFindReplace.Name = "menuFindReplace";
			this.menuFindReplace.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuFindReplace.ShortcutKeys = (global::System.Windows.Forms.Keys)131154;
			this.menuFindReplace.Size = new global::System.Drawing.Size(173, 20);
			this.menuFindReplace.Text = "Replace...";
			this.menuFindReplace.Click += new global::System.EventHandler(this.menuFindReplace_Click);
			this.menuForm.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menuForm.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuForm.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.menuTurn,
				this.menuFont
			});
			this.menuForm.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuForm.Margin = new global::System.Windows.Forms.Padding(2, 0, 3, 0);
			this.menuForm.Name = "menuForm";
			this.menuForm.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuForm.Size = new global::System.Drawing.Size(49, 16);
			this.menuForm.Text = "Format";
			this.menuTurn.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menuTurn.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuTurn.Name = "menuTurn";
			this.menuTurn.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuTurn.Size = new global::System.Drawing.Size(167, 20);
			this.menuTurn.Text = "Word Wrap";
			this.menuTurn.Click += new global::System.EventHandler(this.menuTurn_Click);
			this.menuFont.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menuFont.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuFont.Name = "menuFont";
			this.menuFont.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuFont.Size = new global::System.Drawing.Size(167, 20);
			this.menuFont.Text = "Font...";
			this.menuFont.Click += new global::System.EventHandler(this.menuFont_Click);
			this.menuData.BackColor = global::System.Drawing.SystemColors.Control;
			this.menuData.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuData.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.menuGetData,
				this.menuSetData
			});
			this.menuData.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuData.Margin = new global::System.Windows.Forms.Padding(2, 0, 3, 0);
			this.menuData.Name = "menuData";
			this.menuData.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuData.Size = new global::System.Drawing.Size(58, 16);
			this.menuData.Text = "GameData";
			this.menuGetData.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menuGetData.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuGetData.Name = "menuGetData";
			this.menuGetData.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuGetData.Size = new global::System.Drawing.Size(172, 20);
			this.menuGetData.Text = "Get";
			this.menuSetData.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menuSetData.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuSetData.Name = "menuSetData";
			this.menuSetData.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuSetData.Size = new global::System.Drawing.Size(172, 20);
			this.menuSetData.Text = "Set";
			this.menuStrip1.BackColor = global::System.Drawing.SystemColors.Menu;
			this.menuStrip1.Font = new global::System.Drawing.Font("MS UI Gothic", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 128);
			this.menuStrip1.GripMargin = new global::System.Windows.Forms.Padding(0);
			this.menuStrip1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.menuFile,
				this.menueEdit,
				this.menuForm,
				this.menuData
			});
			this.menuStrip1.LayoutStyle = global::System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuStrip1.Size = new global::System.Drawing.Size(292, 16);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.fontDialog1.ShowColor = true;
			this.AllowDrop = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(292, 273);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.menuStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Location = new global::System.Drawing.Point(0, 256);
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "TextLine";
			this.Text = "TextLine";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.TextLine_FormClosing);
			base.Shown += new global::System.EventHandler(this.TextLine_Shown);
			base.Resize += new global::System.EventHandler(this.TextLine_Resize);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;

		private global::System.Windows.Forms.StatusStrip statusStrip1;

		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		private global::System.Windows.Forms.ToolStripMenuItem cmenuUndo;

		private global::System.Windows.Forms.ToolStripMenuItem cmenuTrim;

		private global::System.Windows.Forms.ToolStripMenuItem cmenuCopy;

		private global::System.Windows.Forms.ToolStripMenuItem cmenuPaste;

		private global::System.Windows.Forms.ToolStripMenuItem cmenuDelete;

		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;

		private global::System.Windows.Forms.ToolStripMenuItem cmenuAllSelect;

		private global::System.Windows.Forms.ToolStripMenuItem cmenuRedo;

		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

		private global::System.Windows.Forms.ToolStripMenuItem cmenuTop;

		private global::System.Windows.Forms.ToolStripMenuItem cmenuBottom;

		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

		private global::System.Windows.Forms.ToolStripMenuItem menuFile;

		private global::System.Windows.Forms.ToolStripMenuItem menuNewSave;

		private global::System.Windows.Forms.ToolStripMenuItem menuOverwriteSave;

		private global::System.Windows.Forms.ToolStripMenuItem menueEdit;

		private global::System.Windows.Forms.ToolStripMenuItem menuFindReplace;

		private global::System.Windows.Forms.ToolStripMenuItem menuForm;

		private global::System.Windows.Forms.ToolStripMenuItem menuTurn;

		private global::System.Windows.Forms.ToolStripMenuItem menuFont;

		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

		public global::System.Windows.Forms.MenuStrip menuStrip1;

		private global::System.Windows.Forms.FontDialog fontDialog1;

		public global::System.Windows.Forms.ToolStripMenuItem menuData;

		public global::System.Windows.Forms.ToolStripMenuItem menuGetData;

		public global::System.Windows.Forms.ToolStripMenuItem menuSetData;
	}
}
