using System;
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
			TabControl tabControl = new TabControl();
			this.Controls.Add(tabControl);
		}
	}
}
