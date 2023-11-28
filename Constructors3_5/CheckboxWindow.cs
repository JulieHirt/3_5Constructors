using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class CheckboxWindow : Form
	{
		public CheckboxWindow()
		{
			InitializeComponent();
		}

		private void CheckboxWindow_Load(object sender, EventArgs e)
		{

			//constructor 1
			var checkbox1 = new CheckBox();
			this.Controls.Add(checkbox1);


			//constructor 2
			var checkbox2 = new CheckBox("checkbox2", (s, args) => AlertBox.Show("You checked checkbox2"));
			flowLayoutPanel1.Controls.Add(checkbox2);

			var checkbox3 = new CheckBox("checkbox3");
			flowLayoutPanel1.Controls.Add(checkbox3);

			//constructor 3
			var checkbox4 = new CheckBox("checkbox4", new Point(0, 50), new Size(100, 100), (s, args) => AlertBox.Show("You checked checkbox4"));
			this.Controls.Add(checkbox4);


		}
	}
}
