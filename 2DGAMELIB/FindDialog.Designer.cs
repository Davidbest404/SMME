namespace _2DGAMELIB
{
	public partial class FindDialog : global::System.Windows.Forms.Form
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
			this.label1 = new global::System.Windows.Forms.Label();
			this.FindTextBox = new global::System.Windows.Forms.TextBox();
			this.findButton = new global::System.Windows.Forms.Button();
			this.currentPosRadio = new global::System.Windows.Forms.RadioButton();
			this.topPosRadio = new global::System.Windows.Forms.RadioButton();
			this.replaceAllButton = new global::System.Windows.Forms.Button();
			this.replaceNextButton = new global::System.Windows.Forms.Button();
			this.ReplaceTextBox = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.cancelButton = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("MS UI Gothic", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 128);
			this.label1.Location = new global::System.Drawing.Point(4, 7);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(31, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Find:";
			this.FindTextBox.Font = new global::System.Drawing.Font("MS UI Gothic", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 128);
			this.FindTextBox.ImeMode = global::System.Windows.Forms.ImeMode.Off;
			this.FindTextBox.Location = new global::System.Drawing.Point(41, 3);
			this.FindTextBox.Name = "FindTextBox";
			this.FindTextBox.Size = new global::System.Drawing.Size(206, 20);
			this.FindTextBox.TabIndex = 1;
			this.FindTextBox.TextChanged += new global::System.EventHandler(this.findTextBox_TextChanged);
			this.findButton.Enabled = false;
			this.findButton.Location = new global::System.Drawing.Point(250, 2);
			this.findButton.Name = "findButton";
			this.findButton.Size = new global::System.Drawing.Size(74, 22);
			this.findButton.TabIndex = 2;
			this.findButton.Text = "Find Next";
			this.findButton.UseVisualStyleBackColor = true;
			this.findButton.Click += new global::System.EventHandler(this.findButton_Click);
			this.currentPosRadio.AutoSize = true;
			this.currentPosRadio.Location = new global::System.Drawing.Point(78, 53);
			this.currentPosRadio.Name = "currentPosRadio";
			this.currentPosRadio.Size = new global::System.Drawing.Size(89, 16);
			this.currentPosRadio.TabIndex = 7;
			this.currentPosRadio.Text = "Current";
			this.currentPosRadio.UseVisualStyleBackColor = true;
			this.currentPosRadio.CheckedChanged += new global::System.EventHandler(this.findPosition_Radio_CheckedChanged);
			this.topPosRadio.AutoSize = true;
			this.topPosRadio.Checked = true;
			this.topPosRadio.Location = new global::System.Drawing.Point(7, 53);
			this.topPosRadio.Name = "topPosRadio";
			this.topPosRadio.Size = new global::System.Drawing.Size(65, 16);
			this.topPosRadio.TabIndex = 6;
			this.topPosRadio.TabStop = true;
			this.topPosRadio.Text = "Begining";
			this.topPosRadio.UseVisualStyleBackColor = true;
			this.topPosRadio.CheckedChanged += new global::System.EventHandler(this.findPosition_Radio_CheckedChanged);
			this.replaceAllButton.Enabled = false;
			this.replaceAllButton.Location = new global::System.Drawing.Point(250, 50);
			this.replaceAllButton.Name = "replaceAllButton";
			this.replaceAllButton.Size = new global::System.Drawing.Size(74, 22);
			this.replaceAllButton.TabIndex = 8;
			this.replaceAllButton.Text = "Replace All";
			this.replaceAllButton.UseVisualStyleBackColor = true;
			this.replaceAllButton.Click += new global::System.EventHandler(this.replaceAllButton_Click);
			this.replaceNextButton.Enabled = false;
			this.replaceNextButton.Location = new global::System.Drawing.Point(250, 26);
			this.replaceNextButton.Name = "replaceNextButton";
			this.replaceNextButton.Size = new global::System.Drawing.Size(74, 22);
			this.replaceNextButton.TabIndex = 5;
			this.replaceNextButton.Text = "Replace Next";
			this.replaceNextButton.UseVisualStyleBackColor = true;
			this.replaceNextButton.Click += new global::System.EventHandler(this.replaceNextButton_Click);
			this.ReplaceTextBox.Font = new global::System.Drawing.Font("MS UI Gothic", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 128);
			this.ReplaceTextBox.ImeMode = global::System.Windows.Forms.ImeMode.Off;
			this.ReplaceTextBox.Location = new global::System.Drawing.Point(41, 27);
			this.ReplaceTextBox.Name = "ReplaceTextBox";
			this.ReplaceTextBox.Size = new global::System.Drawing.Size(206, 20);
			this.ReplaceTextBox.TabIndex = 4;
			this.ReplaceTextBox.TextChanged += new global::System.EventHandler(this.ReplaceTextBox_TextChanged);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("MS UI Gothic", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 128);
			this.label2.Location = new global::System.Drawing.Point(5, 31);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(31, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Replace:";
			this.cancelButton.Enabled = false;
			this.cancelButton.Location = new global::System.Drawing.Point(173, 50);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new global::System.Drawing.Size(74, 22);
			this.cancelButton.TabIndex = 9;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new global::System.EventHandler(this.cancelButton_Click);
			base.AcceptButton = this.findButton;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new global::System.Drawing.Size(326, 75);
			base.Controls.Add(this.cancelButton);
			base.Controls.Add(this.currentPosRadio);
			base.Controls.Add(this.topPosRadio);
			base.Controls.Add(this.replaceAllButton);
			base.Controls.Add(this.findButton);
			base.Controls.Add(this.replaceNextButton);
			base.Controls.Add(this.FindTextBox);
			base.Controls.Add(this.ReplaceTextBox);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "findDialog";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Replace";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.findDialog_FormClosed);
			base.Shown += new global::System.EventHandler(this.findDialog_Shown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TextBox FindTextBox;

		private global::System.Windows.Forms.Button findButton;

		private global::System.Windows.Forms.RadioButton currentPosRadio;

		private global::System.Windows.Forms.RadioButton topPosRadio;

		private global::System.Windows.Forms.Button replaceAllButton;

		private global::System.Windows.Forms.Button replaceNextButton;

		private global::System.Windows.Forms.TextBox ReplaceTextBox;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Button cancelButton;
	}
}
