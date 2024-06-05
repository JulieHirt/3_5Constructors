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
		}
	}
}
