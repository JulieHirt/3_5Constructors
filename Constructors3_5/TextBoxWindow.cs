using System;
using System.Drawing;
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

			TextBox textBox3 = new TextBox("label", action);
		}
	}
}
