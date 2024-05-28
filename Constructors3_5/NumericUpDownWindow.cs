using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class NumericUpDownWindow : Form
	{
		public NumericUpDownWindow()
		{
			InitializeComponent();
		}

		private void NumericUpDownWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			NumericUpDown numericUpDown = new NumericUpDown();
			this.Controls.Add(numericUpDown);

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("value changed"); };
			NumericUpDown numericUpDown1 = new NumericUpDown(action);
			numericUpDown1.Location = new Point(150, 0);
			this.Controls.Add(numericUpDown1);

			//constructor 3
			NumericUpDown numericUpDown2 = new NumericUpDown("label");
			numericUpDown2.Location = new Point(300, 0);
			this.Controls.Add(numericUpDown2);

			NumericUpDown numericUpDown3 = new NumericUpDown("label", action);
			numericUpDown3.Location = new Point(450, 0);
			this.Controls.Add(numericUpDown3);

			//constructor 4
			Point location4 = new Point(0, 100);
			Size size4 = new Size(200, 200);
			NumericUpDown numericUpDown4 = new NumericUpDown(location4, size4);
			this.Controls.Add(numericUpDown4);

			Point location5 = new Point(250, 100);
			Size size5 = new Size(200, 200);
			NumericUpDown numericUpDown5 = new NumericUpDown(location5, size5, action);
			this.Controls.Add(numericUpDown5);

			//constructor 5
			Point location6 = new Point(0, 200);
			Size size6 = new Size(200, 200);
			NumericUpDown numericUpDown6 = new NumericUpDown("label", location6, size6);
			this.Controls.Add(numericUpDown6);

			Point location7 = new Point(200, 200);
			Size size7 = new Size(200, 200);
			NumericUpDown numericUpDown7 = new NumericUpDown("label", location7, size7, action);
			this.Controls.Add(numericUpDown7);
		}
	}
}
