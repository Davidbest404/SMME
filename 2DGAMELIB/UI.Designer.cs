namespace _2DGAMELIB
{
	public partial class UI : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::_2DGAMELIB.UI));
			this.wpfImage1 = new global::_2DGAMELIB.WPFImage();
			this.hostedComponent1 = new global::System.Windows.Controls.Image();
			base.SuspendLayout();
			this.wpfImage1.BackColor = global::System.Drawing.Color.Black;
			this.wpfImage1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.wpfImage1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.wpfImage1.Location = new global::System.Drawing.Point(0, 0);
			this.wpfImage1.Name = "wpfImage1";
			this.wpfImage1.Size = new global::System.Drawing.Size(284, 262);
			this.wpfImage1.TabIndex = 0;
			this.wpfImage1.Text = "wpfImage1";
			this.wpfImage1.Child = this.hostedComponent1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Controls.Add(this.wpfImage1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "UI";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "UI";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.UI_FormClosing);
			base.Load += new global::System.EventHandler(this.UI_Load);
			base.Move += new global::System.EventHandler(this.UI_Move);
			base.Resize += new global::System.EventHandler(this.UI_Resize);
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer components;

		private global::_2DGAMELIB.WPFImage wpfImage1;

		private global::System.Windows.Controls.Image hostedComponent1;
	}
}
