using System;
using System.Drawing;
using System.Security.Policy;
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
			//constructor 1
			Accordion accordion = new Accordion();
			this.Controls.Add(accordion);

			//constructor 2
			AccordionPanel[] panels1 = new AccordionPanel[] {new AccordionPanel("panel 1_1"), new AccordionPanel("panel 1_2"), new AccordionPanel("panel 1_3") };
			Accordion accordion1 = new Accordion(panels1);
			accordion1.Location = new System.Drawing.Point(300, 0);
			this.Controls.Add(accordion1);

			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("selected index changed"); };
			AccordionPanel[] panels2 = new AccordionPanel[] { new AccordionPanel("panel 1_2"), new AccordionPanel("panel 2_2"), new AccordionPanel("panel 2_3") };
			Accordion accordion2 = new Accordion(panels2, action);
			accordion2.Location = new System.Drawing.Point(600, 0);
			this.Controls.Add(accordion2);

			//constructor 3
			Point location3 = new Point(0, 200);
			Size size3 = new Size(200, 100);
			Accordion accordion3 = new Accordion(location3, size3, null);//action);
			//add 2 panels
			AccordionPanel accordionPanel1 = new AccordionPanel();
			AccordionPanel accordionPanel2 = new AccordionPanel();
			accordion3.Controls.Add(accordionPanel1);
			accordion3.Controls.Add(accordionPanel2);
			this.Controls.Add(accordion3);

			Point location4 = new Point(300, 200);
			Size size4 = new Size(200, 100);
			Accordion accordion4 = new Accordion(location4, size4, action);
			//add 2 panels
			AccordionPanel accordionPanel1_4 = new AccordionPanel();
			AccordionPanel accordionPanel2_4 = new AccordionPanel();
			accordion4.Controls.Add(accordionPanel1_4);
			accordion4.Controls.Add(accordionPanel2_4);
			this.Controls.Add(accordion4);

			//constructor 4
			Point location5 = new Point(600, 200);
			Size size5 = new Size(200, 100);
			Accordion accordion5 = new Accordion(location5, size5, null, action);
			//add 2 panels
			AccordionPanel accordionPanel1_5 = new AccordionPanel();
			AccordionPanel accordionPanel2_5 = new AccordionPanel();
			accordion5.Controls.Add(accordionPanel1_5);
			accordion5.Controls.Add(accordionPanel2_5);
			this.Controls.Add(accordion5);

			Point location6 = new Point(0, 400);
			Size size6 = new Size(200, 100);
			AccordionPanel[] panels6 = new AccordionPanel[] { new AccordionPanel("panel 1_2"), new AccordionPanel("panel 2_2"), new AccordionPanel("panel 2_3") };
			Accordion accordion6 = new Accordion(location6, size6, panels6, action);
			this.Controls.Add(accordion6);

			Point location7 = new Point(300, 400);
			Size size7 = new Size(200, 100);
			Accordion accordion7 = new Accordion(location7, size7, null, null);
			this.Controls.Add(accordion7);

		}
	}
}
