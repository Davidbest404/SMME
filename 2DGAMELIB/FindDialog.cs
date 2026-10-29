using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _2DGAMELIB
{
	public partial class FindDialog : Form
	{
		public FindDialog(RichTextBoxEx RichTextBox)
		{
			this.InitializeComponent();
			this.rtb = RichTextBox;
		}

		private void findDialog_Shown(object sender, EventArgs e)
		{
			this.FindTextBox.Focus();
		}

		private void findDialog_FormClosed(object sender, FormClosedEventArgs e)
		{
			base.Dispose();
		}

		private void findTextBox_TextChanged(object sender, EventArgs e)
		{
			this.ButtonsUse();
		}

		private void ReplaceTextBox_TextChanged(object sender, EventArgs e)
		{
			this.ButtonsUse();
		}

		private void ButtonsUse()
		{
			this.findButton.Enabled = (this.FindTextBox.Text != "");
			this.replaceNextButton.Enabled = (this.findButton.Enabled && this.FindTextBox.Text != this.ReplaceTextBox.Text);
			this.replaceAllButton.Enabled = this.replaceNextButton.Enabled;
		}

		private void findButton_Click(object sender, EventArgs e)
		{
			int num = this.rtb.Text.IndexOf(this.FindTextBox.Text, this.StartPoint);
			if (num > -1)
			{
				this.rtb.Select(num, this.FindTextBox.TextLength);
				this.rtb.ScrollToCaret();
				this.StartPoint = num + this.FindTextBox.Text.Length;
				this.FCount++;
				this.rtb.Focus();
				return;
			}
			if (this.FCount != 0)
			{
				MessageBox.Show(this, string.Concat(new string[]
				{
					"Find:",
					this.FCount.ToString(),
					" Replace:",
					this.RCount.ToString(),
					" end"
				}), this.dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
				return;
			}
			MessageBox.Show(this, "\"" + this.FindTextBox.Text + "\" Not Found", this.dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
		}

		private void replaceNextButton_Click(object sender, EventArgs e)
		{
			int num = this.rtb.Text.IndexOf(this.FindTextBox.Text, this.StartPoint);
			if (num > -1)
			{
				this.rtb.Select(num, this.FindTextBox.TextLength);
				if (this.rtb.SelectionProtected)
				{
					this.rtb.Select(num + this.FindTextBox.TextLength, 0);
				}
				else
				{
					this.rtb.SelectedText = this.ReplaceTextBox.Text;
					this.RCount++;
				}
				this.rtb.ScrollToCaret();
				this.StartPoint = this.rtb.SelectionStart;
				this.rtb.Focus();
				return;
			}
			if (this.RCount != 0)
			{
				MessageBox.Show(this, string.Concat(new string[]
				{
					"Find:",
					this.FCount.ToString(),
					" Replace:",
					this.RCount.ToString(),
					" end"
				}), this.dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
				return;
			}
			MessageBox.Show(this, "\"" + this.FindTextBox.Text + "\" Not Found", this.dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
		}

		private void replaceAllButton_Click(object sender, EventArgs e)
		{
			this.origin = (this.topPosRadio.Checked ? 0 : this.rtb.SelectionStart);
			this.cancelButton.Enabled = true;
			this.label1.Enabled = false;
			this.label2.Enabled = false;
			this.FindTextBox.Enabled = false;
			this.ReplaceTextBox.Enabled = false;
			this.findButton.Enabled = false;
			this.replaceNextButton.Enabled = false;
			this.replaceAllButton.Enabled = false;
			this.topPosRadio.Enabled = false;
			this.currentPosRadio.Enabled = false;
			this.cancel = false;
			while (!this.cancel)
			{
				int num = this.rtb.Text.IndexOf(this.FindTextBox.Text, this.StartPoint);
				if (num > -1)
				{
					this.rtb.Select(num, this.FindTextBox.TextLength);
					if (this.rtb.SelectionProtected)
					{
						this.rtb.Select(num + this.FindTextBox.TextLength, 0);
					}
					else
					{
						this.rtb.SelectedText = this.ReplaceTextBox.Text;
						this.RCount++;
					}
					this.rtb.ScrollToCaret();
					this.StartPoint = this.rtb.SelectionStart;
					Application.DoEvents();
				}
				else
				{
					if (this.RCount != 0)
					{
						MessageBox.Show(this, string.Concat(new string[]
						{
							"Find:",
							this.FCount.ToString(),
							" Replace:",
							this.RCount.ToString(),
							" end"
						}), this.dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
						break;
					}
					MessageBox.Show(this, "\"" + this.FindTextBox.Text + "\" Not Found", this.dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
					break;
				}
			}
			if (this.cancel)
			{
				MessageBox.Show(this, string.Concat(new string[]
				{
					"Find:",
					this.FCount.ToString(),
					" Replace:",
					this.RCount.ToString(),
					" end"
				}), this.dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
			}
			this.cancelButton.Enabled = false;
			this.label1.Enabled = true;
			this.label2.Enabled = true;
			this.FindTextBox.Enabled = true;
			this.ReplaceTextBox.Enabled = true;
			this.findButton.Enabled = true;
			this.replaceNextButton.Enabled = true;
			this.replaceAllButton.Enabled = true;
			this.topPosRadio.Enabled = true;
			this.currentPosRadio.Enabled = true;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.cancel = true;
		}

		private void findPosition_Radio_CheckedChanged(object sender, EventArgs e)
		{
			this.ResetFindPosition();
		}

		private void ResetFindPos()
		{
			this.StartPoint = (this.topPosRadio.Checked ? 0 : this.origin);
			this.FCount = 0;
			this.RCount = 0;
			this.rtb.Select(this.StartPoint, 0);
			this.rtb.Focus();
		}

		public void ResetFindPosition()
		{
			this.StartPoint = (this.topPosRadio.Checked ? 0 : this.rtb.SelectionStart);
			this.FCount = 0;
			this.RCount = 0;
			this.origin = this.rtb.SelectionStart;
		}

		private RichTextBoxEx rtb;

		private int StartPoint;

		private int FCount;

		private int RCount;

		private string dialogTitle = "Finish!";

		private int origin;

		private bool cancel;
	}
}
