using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class FormWindow : Form
	{
		public FormWindow()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//constructor 1
			Form form1 = new Form();
			//form1.ShowDialog();

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("closed"); };
			Form form2 = new Form(action);
			//form2.ShowDialog();


			//constructor 3
			var button1 = new Button("Button 1-1");
			var button2 = new Button("Button 2-1", new Point(0, 50), new Size(100, 100));
			var button3 = new Button("Button 3-1", new Point(120, 50), new Size(100, 100));
			Control[] controlArray = new Control[] { button1, button2, button3 };
			Form form3 = new Form(controlArray, action);
			//form3.ShowDialog();


			var button1_2 = new Button("Button 1-2");
			var button2_2 = new Button("Button 2-2", new Point(0, 50), new Size(100, 100));
			var button3_2 = new Button("Button 3-2", new Point(120, 50), new Size(100, 100));
			Control[] controlArray2 = new Control[] { button1_2, button2_2, button3_2 };
			Form form4 = new Form(controlArray2);
			//form4.ShowDialog();


			//constructor 4
			var button1_3 = new Button("Button 1-3");
			var button2_3 = new Button("Button 2-3", new Point(0, 50), new Size(100, 100));
			var button3_3 = new Button("Button 3-3", new Point(120, 50), new Size(100, 100));
			Control[] controlArray3 = new Control[] { button1_3, button2_3, button3_3 };
			Form form5 = new Form(new Point(100, 50), new Size(400, 400),controlArray3);
			//form5.ShowDialog();


			//can't do this: Form form = new Form(new Point(100, 50), new Size(400, 400)); 
			//because it can't differentiate between constructor 4 5 and 6
			//does not work even if last parameter is null
			//Form formtest = new Form(new Point(100, 50), new Size(400, 400), null);

			//constructor 5
			Form form6 = new Form(new Point(100, 50), new Size(400, 400), action);
			//form6.ShowDialog();

			//constructor 6
			var button1_4 = new Button("Button 1-4");
			var button2_4 = new Button("Button 2-4", new Point(0, 50), new Size(100, 100));
			var button3_4 = new Button("Button 3-4", new Point(120, 50), new Size(100, 100));
			Control[] controlArray4 = new Control[] { button1_3, button2_3, button3_3 };
			Form form7 = new Form(new Point(100, 50), new Size(400, 400), controlArray4, action);
			form7.ShowDialog();

		}
	}
}
