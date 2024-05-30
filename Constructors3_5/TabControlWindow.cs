using System;
using System.Drawing;
using System.Security.Policy;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class TabControlWindow : Form
	{
		public TabControlWindow()
		{
			InitializeComponent();
		}

		private void TabControlWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			TabControl tabControl = new TabControl();
			this.Controls.Add(tabControl);


			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("tab changed"); };
			TabControl tabControl1 = new TabControl(action);
			tabControl1.Location = new Point(200, 0);
			//add tabpages
			TabPage tabPage1 = new Wisej.Web.TabPage();
			tabPage1.Text = "tabPage1";
			tabControl1.Controls.Add(tabPage1);
			TabPage tabPage2 = new Wisej.Web.TabPage();
			tabPage2.Text = "tabPage2";
			tabControl1.Controls.Add(tabPage2);
			this.Controls.Add(tabControl1);

			//constructor 3
			TabPage tabPage2_1 = new Wisej.Web.TabPage();
			tabPage2_1.Text = "tabPage2_1";
			TabPage tabPage2_2 = new Wisej.Web.TabPage();
			tabPage2_2.Text = "tabPage2_2";
			TabPage[] tabPages2 = new TabPage[] { tabPage2_1, tabPage2_2};

			TabControl tabControl2 = new TabControl(tabPages2);
			tabControl2.Location = new Point(500, 0);
			this.Controls.Add(tabControl2);


			TabPage tabPage3_1 = new Wisej.Web.TabPage();
			tabPage3_1.Text = "tabPage3_1";
			TabPage tabPage3_2 = new Wisej.Web.TabPage();
			tabPage3_2.Text = "tabPage3_2";
			TabPage[] tabPages3 = new TabPage[] { tabPage3_1, tabPage3_2 };
			TabControl tabControl3 = new TabControl(tabPages3, action);
			tabControl3.Location = new Point(0, 150);
			this.Controls.Add(tabControl3);

			//constructor 4
			Point location4 = new Point(240, 150);
			Size size4 = new Size(200, 200);
			TabControl tabControl4 = new TabControl(location4, size4, action);
			//add tabpages
			TabPage tabPage1_4 = new Wisej.Web.TabPage();
			tabPage1_4.Text = "tabPage1_4";
			tabControl4.Controls.Add(tabPage1_4);
			TabPage tabPage2_4 = new Wisej.Web.TabPage();
			tabPage2_4.Text = "tabPage2_4";
			tabControl4.Controls.Add(tabPage2_4);
			this.Controls.Add(tabControl4);

			//constructor 5
			Point location5 = new Point(500, 150);
			Size size5 = new Size(200, 200);
			TabPage tabPage5_1 = new Wisej.Web.TabPage();
			tabPage5_1.Text = "tabPage5_1";
			TabPage tabPage5_2 = new Wisej.Web.TabPage();
			tabPage5_2.Text = "tabPage5_2";
			TabPage[] tabPages5 = new TabPage[] { tabPage5_1, tabPage5_2 };
			TabControl tabControl5 = new TabControl(location5, size5, tabPages5);
			this.Controls.Add(tabControl5);


			//TabControl tabControl6 = new TabControl(location6, size6, tabPages6, action)
		}
	}
}
