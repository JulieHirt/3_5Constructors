using System;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class DomainUpDownWindow : Form
	{
		public DomainUpDownWindow()
		{
			InitializeComponent();
		}

		private void DomainUpDownWindow_Load(object sender, EventArgs e)
		{
			DomainUpDown domainUpDown1 = new DomainUpDown();
			this.Controls.Add(domainUpDown1);

			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("changed"); };
			DomainUpDown domainUpDown2 = new DomainUpDown(action);
		}
	}
}
