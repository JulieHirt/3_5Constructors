using System;
using System.Drawing;
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
		}
	}
}
