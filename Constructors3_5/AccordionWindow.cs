using System;
using System.Drawing;
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
			//accordion3.Panels = panels2;
			//add 2 panels
			AccordionPanel accordionPanel1 = new AccordionPanel();
			AccordionPanel accordionPanel2 = new AccordionPanel();
			accordion3.Controls.Add(accordionPanel1);
			accordion3.Controls.Add(accordionPanel2);
			this.Controls.Add(accordion3);

			//Point location4 = new Point(0, 200);
			//Size size4 = new Size(200, 100);
			//Accordion accordion4 = new Accordion(location4, size4, null);//action);
			//															 //accordion4.Panels = panels2;
			//															 //add 2 panels
			//AccordionPanel accordionPanel1 = new AccordionPanel();
			//AccordionPanel accordionPanel2 = new AccordionPanel();
			//accordion4.Controls.Add(accordionPanel1);
			//accordion4.Controls.Add(accordionPanel2);
			//this.Controls.Add(accordion4);

			//constructor 4
			//Accordion accordion5 = new Accordion();
		}
	}
}
