using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class FlowLayoutPanelWindow : Form
	{
		public FlowLayoutPanelWindow()
		{
			InitializeComponent();
		}

		private void FlowLayoutPanelWindow_Load(object sender, EventArgs e)
		{
			//BorderStyle is set to solid so that we can see the panel

			FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();
			flowLayoutPanel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(flowLayoutPanel1);


			var button1 = new Button("Button 1-1");
			var button2 = new Button("Button 2-1");
			var button3 = new Button("Button 3-1");
			Control[] controlArray = new Control[]{ button1, button2, button3 };
			FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel(controlArray);
			flowLayoutPanel2.Location = new Point(100, 150);
			flowLayoutPanel2.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(flowLayoutPanel2);


			var button1_2 = new Button("Button 1-2");
			var button2_2 = new Button("Button 2-2");
			var button3_2 = new Button("Button 3-2");
			Control[] controlArray2 = new Control[] { button1_2, button2_2, button3_2 };
			FlowLayoutPanel flowLayoutPanel3 = new FlowLayoutPanel(controlArray2, FlowDirection.TopDown);
			flowLayoutPanel3.Location = new Point(350, 150);
			flowLayoutPanel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(flowLayoutPanel3);


			Point p = new Point(700, 150);
			Size s = new Size(200, 100);
			FlowLayoutPanel flowLayoutPanel4 = new FlowLayoutPanel(p,s);
			flowLayoutPanel4.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(flowLayoutPanel4);


			var button1_3 = new Button("Button 1-3");
			var button2_3 = new Button("Button 2-3");
			var button3_3 = new Button("Button 3-3");
			Control[] controlArray3 = new Control[] { button1_3, button2_3, button3_3 };
			Point p2 = new Point(100,300);
			Size s2 = new Size(200, 100);
			FlowLayoutPanel flowLayoutPanel5 = new FlowLayoutPanel(p2, s2, controlArray3);
			flowLayoutPanel5.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(flowLayoutPanel5);


			var button1_4 = new Button("Button 1");
			var button2_4 = new Button("Button 2");
			var button3_4 = new Button("Button 3");
			Control[] controlArray4 = new Control[] { button1_4, button2_4, button3_4 };
			Point p3 = new Point(300, 300);
			Size s3 = new Size(200, 100);
			FlowLayoutPanel flowLayoutPanel6 = new FlowLayoutPanel(p3, s3, controlArray4, FlowDirection.TopDown);
			flowLayoutPanel6.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(flowLayoutPanel6);

		}
	}
}
