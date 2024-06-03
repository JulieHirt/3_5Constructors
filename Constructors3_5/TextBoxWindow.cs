using System;
using System.Drawing;
using System.Security.Policy;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class TextBoxWindow : Form
	{
		public TextBoxWindow()
		{
			InitializeComponent();
		}

		private void TextBoxWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			TextBox textBox = new TextBox();
			this.Controls.Add(textBox);

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("text changed"); };
			TextBox textBox1 = new TextBox(action);
			textBox1.Location = new Point(120, 0);
			this.Controls.Add(textBox1);

			//constructor 3
			TextBox textBox2 = new TextBox("label");
			textBox2.Location = new Point(220, 0);
			this.Controls.Add(textBox2);

			TextBox textBox3 = new TextBox("label", action);
			textBox3.Location = new Point(320, 0);
			this.Controls.Add(textBox3);

			//constructor 4
			Point location4 = new Point(420, 0);
			Size size4 = new Size(100, 100);
			TextBox textBox4 = new TextBox(location4, size4);
			this.Controls.Add(textBox4);

			Point location5 = new Point(520, 0);
			Size size5 = new Size(100, 100);
			TextBox textBox5 = new TextBox(location5, size5, action);
			this.Controls.Add(textBox5);

			//constructor 5
			Point location6 = new Point(620, 0);
			Size size6 = new Size(100, 100);
			TextBox textBox6 = new TextBox("label", location6, size6);
			this.Controls.Add(textBox6);

			Point location7 = new Point(720, 0);
			Size size7 = new Size(100, 100);
			TextBox textBox7 = new TextBox("label", location7, size7, action);
			this.Controls.Add(textBox7);
		}
	}
}
