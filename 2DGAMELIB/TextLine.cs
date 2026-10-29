using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _2DGAMELIB
{
	public partial class TextLine : Form
	{
		public TextLine()
		{
			this.richTextBoxCustom1 = new RichTextBoxEx();
			this.InitializeComponent();
			this.richTextBoxCustom1.Location = new Point(this.richTextBoxCustom1.Location.X, this.menuStrip1.Size.Height);
			this.richTextBoxCustom1.Size = new Size(base.ClientSize.Width, base.ClientSize.Height - this.statusStrip1.Size.Height - this.menuStrip1.Size.Height);
			base.Controls.Add(this.richTextBoxCustom1);
			this.richTextBoxCustom1.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBoxCustom1.CursorPositionChanged += this.richTextBoxCustom1_CursorPositionChanged;
			this.richTextBoxCustom1.SelectionChanged += this.richTextBoxCustom1_SelectionChanged;
			this.richTextBoxCustom1.AllowDrop = true;
			this.richTextBoxCustom1.DragEnter += this.richTextBoxCustom1_DragEnter;
			this.richTextBoxCustom1.DragDrop += this.richTextBoxCustom1_DragDrop;
			this.richTextBoxCustom1.TextChanged += this.richTextBoxCustom1_TextChanged;
			this.richTextBoxCustom1.Click += this.richTextBoxCustom1_Click;
			this.richTextBoxCustom1.WordWrap = this.menuTurn.Checked;
			this.richTextBoxCustom1.AcceptsTab = true;
			this.richTextBoxCustom1.LinkClicked += delegate(object sender, LinkClickedEventArgs e)
			{
				try
				{
					Process.Start(e.LinkText);
				}
				catch
				{
					this.toolStripStatusLabel1.Text = "Error : URL does not seem to exist";
				}
			};
		}

		private void TextLine_Resize(object sender, EventArgs e)
		{
			this.richTextBoxCustom1.Location = new Point(this.richTextBoxCustom1.Location.X, this.menuStrip1.Size.Height);
			this.richTextBoxCustom1.Size = new Size(base.ClientSize.Width, base.ClientSize.Height - this.statusStrip1.Size.Height - this.menuStrip1.Size.Height);
		}

		private void TextLine_Shown(object sender, EventArgs e)
		{
			this.richTextBoxCustom1.Focus();
		}

		private void TextLine_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private bool confirmDestructionText()
		{
			return !this.dirtyFlag || MessageBox.Show("The file has not been saved.\n\nAre you sure you want to discard the text you are editing?", "End", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}

		private void richTextBoxCustom1_CursorPositionChanged(object sender, EventArgs e)
		{
			this.toolStripStatusLabel1.Text = "Status";
			this.toolStripStatusLabel2.Text = "y:" + (this.richTextBoxCustom1.CurrentLine + 1).ToString() + ",x:" + this.richTextBoxCustom1.CurrentColumn.ToString();
		}

		private void richTextBoxCustom1_SelectionChanged(object sender, EventArgs e)
		{
			this.toolStripStatusLabel1.Text = "Select:" + this.richTextBoxCustom1.SelectionLength.ToString();
		}

		private void richTextBoxCustom1_TextChanged(object sender, EventArgs e)
		{
			this.setDirty(true);
			this.ddlFlag = false;
		}

		private void richTextBoxCustom1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		private void richTextBoxCustom1_DragDrop(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			if (this.CheckFileType(array[0]))
			{
				if (Path.GetExtension(array[0]).IndexOf("rtf", 0, StringComparison.CurrentCultureIgnoreCase) != -1)
				{
					try
					{
						this.richTextBoxCustom1.LoadFile(array[0], RichTextBoxStreamType.RichText);
						goto IL_6B;
					}
					catch
					{
						this.richTextBoxCustom1.LoadFile(array[0], RichTextBoxStreamType.PlainText);
						goto IL_6B;
					}
				}
				this.richTextBoxCustom1.LoadFile(array[0], RichTextBoxStreamType.PlainText);
				IL_6B:
				this.Text = Path.GetFileNameWithoutExtension(array[0]);
				this.editFilePath = array[0];
				this.ddlFlag = true;
				base.Focus();
			}
		}

		private bool CheckFileType(string filePath)
		{
			return this.Extensions.Contains(Path.GetExtension(filePath).Replace(".", ""));
		}

		private void setDirty(bool flag)
		{
			this.dirtyFlag = flag;
			this.menuOverwriteSave.Enabled = (!(this.editFilePath == "") && !this.ddlFlag && flag);
		}

		private void ShowSaveDateTime()
		{
			this.toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + Path.GetFileNameWithoutExtension(this.editFilePath) + " Save";
		}

		private void Save()
		{
			if (this.saveFileDialog1.FilterIndex == 1)
			{
				this.richTextBoxCustom1.SaveFile(this.editFilePath, RichTextBoxStreamType.PlainText);
				return;
			}
			this.richTextBoxCustom1.SaveFile(this.editFilePath, RichTextBoxStreamType.RichText);
		}

		private void menuNewSave_Click(object sender, EventArgs e)
		{
			this.NewSave();
		}

		private void NewSave()
		{
			this.saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(this.editFilePath);
			this.saveFileDialog1.ShowDialog(this);
		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			this.editFilePath = this.saveFileDialog1.FileName;
			try
			{
				this.Save();
				this.Text = Path.GetFileNameWithoutExtension(this.editFilePath);
				this.setDirty(false);
				this.ShowSaveDateTime();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Save As", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void menuOverwriteSave_Click(object sender, EventArgs e)
		{
			this.OverwriteSave();
		}

		private void OverwriteSave()
		{
			if (File.Exists(this.editFilePath))
			{
				try
				{
					this.Save();
					this.setDirty(false);
					this.ShowSaveDateTime();
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, ex.Message, "Overwriting", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
			MessageBox.Show("The file path \"" + this.editFilePath + "\" is incorrect.\n\nCheck if the directory exists.", "Overwriting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			this.menuOverwriteSave.Enabled = false;
		}

		private void menuTurn_Click(object sender, EventArgs e)
		{
			this.menuTurn.Checked = !this.menuTurn.Checked;
			this.richTextBoxCustom1.WordWrap = this.menuTurn.Checked;
		}

		private void menuFont_Click(object sender, EventArgs e)
		{
			if (this.fontDialog1.ShowDialog() == DialogResult.OK)
			{
				this.richTextBoxCustom1.SelectionFont = this.fontDialog1.Font;
				this.richTextBoxCustom1.SelectionColor = this.fontDialog1.Color;
			}
		}

		private void menuFindReplace_Click(object sender, EventArgs e)
		{
			if (this.findDlg == null || this.findDlg.IsDisposed)
			{
				this.findDlg = new FindDialog(this.richTextBoxCustom1);
				this.findDlg.Location = new Point(base.Location.X + base.Width - this.findDlg.Width, base.Location.Y);
				this.findDlg.Show(this);
			}
		}

		private void richTextBoxCustom1_Click(object sender, EventArgs e)
		{
			if (this.findDlg != null)
			{
				this.findDlg.ResetFindPosition();
			}
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			this.cmenuUndo.Enabled = this.richTextBoxCustom1.CanUndo;
			this.cmenuRedo.Enabled = this.richTextBoxCustom1.CanRedo;
			this.cmenuTrim.Enabled = (this.richTextBoxCustom1.SelectedText != "");
			this.cmenuCopy.Enabled = this.cmenuTrim.Enabled;
			this.cmenuDelete.Enabled = this.cmenuTrim.Enabled;
			IDataObject dataObject = Clipboard.GetDataObject();
			this.cmenuPaste.Enabled = (dataObject.GetDataPresent(DataFormats.Text) | dataObject.GetDataPresent(DataFormats.Bitmap));
			this.cmenuAllSelect.Enabled = (this.richTextBoxCustom1.Text != "");
			this.toolStripMenuItem4.Enabled = this.cmenuAllSelect.Enabled;
		}

		private void cmenuTop_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^{HOME}");
		}

		private void cmenuBottom_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^{END}");
		}

		private void cmenuUndo_Click(object sender, EventArgs e)
		{
			this.richTextBoxCustom1.Undo();
		}

		private void cmenuRedo_Click(object sender, EventArgs e)
		{
			this.richTextBoxCustom1.Redo();
		}

		private void cmenuTrim_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(this.richTextBoxCustom1.SelectedText.ToCRLF(), true);
			this.richTextBoxCustom1.SelectedText = "";
		}

		private void cmenuCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(this.richTextBoxCustom1.SelectedText.ToCRLF(), true);
		}

		private void cmenuPaste_Click(object sender, EventArgs e)
		{
			if (Clipboard.ContainsText())
			{
				this.richTextBoxCustom1.SelectedText = Clipboard.GetText();
			}
		}

		private void cmenuDelete_Click(object sender, EventArgs e)
		{
			SendKeys.Send("{DELETE}");
		}

		private void cmenuAllSelect_Click(object sender, EventArgs e)
		{
			this.richTextBoxCustom1.SelectAll();
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.richTextBoxCustom1.Clear();
		}

		public RichTextBoxEx richTextBoxCustom1;

		private HashSet<string> Extensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"txt",
			"rtf",
			"cs",
			"vb",
			"htm",
			"html",
			"xml",
			"csv",
			"js",
			"vbs",
			"wsh"
		};

		private bool dirtyFlag;

		private bool ddlFlag;

		private string editFilePath = "";

		private FindDialog findDlg;
	}
}
