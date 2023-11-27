namespace Constructors3_5
{
	partial class CheckboxWindow
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

		#region Wisej.NET Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Location = new System.Drawing.Point(307, 45);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 168);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// CheckboxWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 300);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "CheckboxWindow";
			this.Text = "CheckboxWindow";
			this.Load += new System.EventHandler(this.CheckboxWindow_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
	}
}