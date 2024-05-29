using System;
using System.Drawing;
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
			TabPage tabPage3_1 = new Wisej.Web.TabPage();
			tabPage3_1.Text = "tabPage3_1";
			TabPage tabPage3_2 = new Wisej.Web.TabPage();
			tabPage3_2.Text = "tabPage3_2";
			TabPage[] tabPages = new TabPage[] { tabPage3_1, tabPage3_2};

			TabControl tabControl2 = new TabControl(tabPages);
			tabControl2.Location = new Point(400, 0);
			this.Controls.Add(tabControl2);
		}
	}
}
