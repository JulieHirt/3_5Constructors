using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class RadioButtonWindow : Form
	{
		public RadioButtonWindow()
		{
			InitializeComponent();
		}

		private void RadioButtonWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			RadioButton radioButton = new RadioButton();
			this.Controls.Add(radioButton);

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("radiobutton"); };
			RadioButton radioButton1 = new RadioButton("text");
			radioButton1.Location = new Point(100, 0);
			this.Controls.Add(radioButton1);

			RadioButton radioButton2 = new RadioButton("text2", action);
			radioButton2.Location = new Point(200, 0);
			this.Controls.Add(radioButton2);

			//constructor 3
			Point location3 = new Point(300, 0);
			Size size3 = new Size(200, 200);
			RadioButton radioButton3 = new RadioButton("text3", location3, size3);
			this.Controls.Add(radioButton3);

			Point location4 = new Point(400, 0);
			Size size4 = new Size(200, 200);
			RadioButton radioButton4 = new RadioButton("text4", location4, size4, action);
			this.Controls.Add(radioButton4);


		}
	}
}
