using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class TablelayoutPanelWindow : Form
	{
		public TablelayoutPanelWindow()
		{
			InitializeComponent();
		}

		private void TablelayoutPanelWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			TableLayoutPanel panel = new TableLayoutPanel();
			panel.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(panel);

			//constructor 2
			Point location2 = new Point(300, 0);
			Size size2 = new Size(100,100);
			TableLayoutPanel panel2 = new TableLayoutPanel(location2, size2);
			panel2.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(panel2);

			Control[] controls = new Control[] { new Button(), new Button() };
			Point location3 = new Point(600, 0);
			Size size3 = new Size(100, 100);
			TableLayoutPanel panel3 = new TableLayoutPanel(location3, size3, controls);
			panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(panel3);

		}
	}
}
