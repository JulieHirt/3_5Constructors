using System;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class MaskedTextBoxWindow : Form
	{
		public MaskedTextBoxWindow()
		{
			InitializeComponent();
		}

		private void MaskedTextBoxWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			MaskedTextBox maskedTextBox = new MaskedTextBox();
			this.Controls.Add(maskedTextBox);

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("text changed"); };
			MaskedTextBox maskedTextBox1 = new MaskedTextBox(action);
			maskedTextBox1.Location = new System.Drawing.Point(100, 9);
			this.Controls.Add(maskedTextBox1);
		}

		//MaskedTextBox maskedTextBox2 = new MaskedTextBox()
	}
}
