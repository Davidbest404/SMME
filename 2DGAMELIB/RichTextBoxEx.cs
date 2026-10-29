using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2DGAMELIB
{
	public class RichTextBoxEx : RichTextBox
	{
		public event EventHandler CursorPositionChanged;

		public RichTextBoxEx()
		{
			this.BackColor = SystemColors.Window;
			base.SetStyle(ControlStyles.Selectable, false);
		}

		protected virtual void OnCursorPositionChanged(EventArgs e)
		{
			if (this.CursorPositionChanged != null)
			{
				this.CursorPositionChanged(this, e);
			}
		}

		protected override void OnSelectionChanged(EventArgs e)
		{
			this.OnCursorPositionChanged(e);
			if (this.SelectionLength > 0)
			{
				base.OnSelectionChanged(e);
			}
		}

		public int CurrentLine
		{
			get
			{
				return this.GetLineFromCharIndex(base.SelectionStart);
			}
		}

		public int CurrentColumn
		{
			get
			{
				return base.SelectionStart - base.GetFirstCharIndexOfCurrentLine();
			}
		}
	}
}
