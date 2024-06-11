using System;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class AccordionWindow : Form
	{
		public AccordionWindow()
		{
			InitializeComponent();
		}

		private void AccordionWindow_Load(object sender, EventArgs e)
		{
			Accordion accordion = new Accordion();
			this.Controls.Add(accordion);
		}
	}
}
