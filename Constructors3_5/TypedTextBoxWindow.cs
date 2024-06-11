using System;
using System.Drawing;
using System.Security.Policy;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class TypedTextBoxWindow : Form
	{
		public TypedTextBoxWindow()
		{
			InitializeComponent();
		}

		private void TypedTextBoxWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			TypedTextBox typedTextBox = new TypedTextBox();
			this.Controls.Add(typedTextBox);

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("text changed"); };
			TypedTextBox typedTextBox1 = new TypedTextBox(action);
			typedTextBox1.Location = new Point(100, 0);
			this.Controls.Add(typedTextBox1);

			//constructor 3
			TypedTextBox typedTextBox2 = new TypedTextBox("label");
			typedTextBox2.Location = new Point(200, 0);
			this.Controls.Add(typedTextBox2);

			TypedTextBox typedTextBox3 = new TypedTextBox("label",action);
			typedTextBox3.Location = new Point(300, 0);
			this.Controls.Add(typedTextBox3);

			//constructor 4
			Point location4 = new Point(0, 100);
			Size size4 = new Size(200, 100);
			TypedTextBox typedTextBox4 = new TypedTextBox(location4, size4);
			this.Controls.Add(typedTextBox4);

			Point location5 = new Point(300, 100);
			Size size5 = new Size(200, 100);
			TypedTextBox typedTextBox5 = new TypedTextBox(location5, size5, action);
			this.Controls.Add(typedTextBox5);

			//constructor 5
			Point location6 = new Point(0, 200);
			Size size6 = new Size(200, 100);
			TypedTextBox typedTextBox6 = new TypedTextBox("label", location6, size6);
			this.Controls.Add(typedTextBox6);

			Point location7 = new Point(300, 200);
			Size size7 = new Size(200, 100);
			TypedTextBox typedTextBox7 = new TypedTextBox("label", location7, size7, action);
			this.Controls.Add(typedTextBox7);
		}
	}
}
