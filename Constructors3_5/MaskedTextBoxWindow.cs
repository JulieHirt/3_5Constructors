using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class MaskedTextBoxWindow : Form
	{
		public MaskedTextBoxWindow()
		{
			InitializeComponent();
		}

		private void MaskedTextBoxWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			MaskedTextBox maskedTextBox = new MaskedTextBox();
			this.Controls.Add(maskedTextBox);

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("text changed"); };
			MaskedTextBox maskedTextBox1 = new MaskedTextBox(action);
			maskedTextBox1.Location = new System.Drawing.Point(100, 9);
			this.Controls.Add(maskedTextBox1);

			//constructor 3
			MaskedTextBox maskedTextBox2 = new MaskedTextBox("000");
			maskedTextBox2.Location = new System.Drawing.Point(210, 9);
			this.Controls.Add(maskedTextBox2);

			MaskedTextBox maskedTextBox3 = new MaskedTextBox("000", action);
			maskedTextBox3.Location = new System.Drawing.Point(320, 9);
			this.Controls.Add(maskedTextBox3);

			//constructor 4
			Point location6 = new Point(210, 100);
			Size size6 = new Size(100, 100);
			MaskedTextBox maskedTextBox6 = new MaskedTextBox(location6, size6);
			this.Controls.Add(maskedTextBox6);

			Point location7 = new Point(320, 100);
			Size size7 = new Size(100, 100);
			MaskedTextBox maskedTextBox7 = new MaskedTextBox(location7, size7, action);
			this.Controls.Add(maskedTextBox7);

			//constructor 5
			MaskedTextBox maskedTextBox4 = new MaskedTextBox("label", "000");
			maskedTextBox4.Location = new System.Drawing.Point(430, 9);
			this.Controls.Add(maskedTextBox4);

			MaskedTextBox maskedTextBox5 = new MaskedTextBox("label", "000", action);
			maskedTextBox5.Location = new System.Drawing.Point(0, 100);
			this.Controls.Add(maskedTextBox5);

			//constructor 6
			Point location8 = new Point(120, 200);
			Size size8 = new Size(100, 100);
			MaskedTextBox maskedTextBox8 = new MaskedTextBox("label8", "000", location8, size8);
			this.Controls.Add(maskedTextBox8);

			Point location9 = new Point(320, 200);
			Size size9 = new Size(100, 100);
			MaskedTextBox maskedTextBox9 = new MaskedTextBox("label9", "000", location9, size9, action);
			this.Controls.Add(maskedTextBox9);
		}
	}
}
