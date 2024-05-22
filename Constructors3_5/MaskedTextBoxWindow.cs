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
		}
	}
}
