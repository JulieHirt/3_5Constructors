using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class ButtonWindow : Form
	{
		public ButtonWindow()
		{
			InitializeComponent();
		}

		private void ButtonWindow_Load(object sender, EventArgs e)
		{

			//constructor 1
			var button = new Button();
			this.Controls.Add(button);

			//constructor 2
			var button2 = new Button("Button 2");
			button2.Location = new Point(150, 0);
			this.Controls.Add(button2);

			var button3 = new Button("Click Me", (s, args) => AlertBox.Show("You clicked me!"));
			button3.Location = new Point(400, 0);
			this.Controls.Add(button3);

			//constructor 3
			var button4 = new Button("Button4", new Point(150, 50), new Size(100, 100));
			this.Controls.Add(button4);

			var button5 = CreateButton5();
			this.Controls.Add(button5);

			var button6 = new Button("Button6", new Point(300, 50), new Size(100, 50), (s, args) => AlertBox.Show("You clicked button6!"));
			this.Controls.Add(button6);

			//constructor 4
			var button7 = new Button("Button4", "menu-overflow", new Point(300, 150), new Size(100, 100));
			this.Controls.Add(button7);

			var button8 = CreateButton8();
			this.Controls.Add(button8);

			var button9 = new Button("Button9", "menu-overflow", new Point(0, 250), new Size(90, 50), (s, args) => AlertBox.Show("You clicked button9!"));
			this.Controls.Add(button9);
		}

		public Button CreateButton5() 
		{ 
			return new Button("Button5", new Point(0, 100), new Size(80, 80), (s, e) => AlertBox.Show("You clicked button5!"));
		}

		public Button CreateButton8() { 
			return new Button("Button8", "menu-overflow", new Point(450, 150), new Size(90, 50), (s, e) => AlertBox.Show("You clicked button8!"));
		}
	}
}
