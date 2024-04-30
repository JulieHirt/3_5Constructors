
using System;
using System.Drawing;
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
			domainUpDown2.Location = new Point(100, 50);
			domainUpDown2.Items.AddRange(new object[] {
			"item 1",
			"item 2",
			"item 3"});
			this.Controls.Add(domainUpDown2);

			DomainUpDown domainUpDown3 = new DomainUpDown("label", action);
			domainUpDown3.Location = new Point(300, 50);
			this.Controls.Add(domainUpDown3);

			DomainUpDown domainUpDown4 = new DomainUpDown("label2");
			domainUpDown4.Location = new Point(500, 50);
			this.Controls.Add(domainUpDown4);

			Point p = new Point(100, 100);
			Size s = new Size(100, 100);
			DomainUpDown domainUpDown5 = new DomainUpDown(p, s);
			this.Controls.Add(domainUpDown5);


			Point p2 = new Point(300, 100);
			Size s2 = new Size(100, 100);
			DomainUpDown domainUpDown6 = new DomainUpDown(p2,s2,action);
			this.Controls.Add(domainUpDown6);


			Point p3 = new Point(500, 100);
			Size s3 = new Size(100, 100);
			DomainUpDown domainUpDown7 = new DomainUpDown("label3", p3, s3);
			this.Controls.Add(domainUpDown7);

			Point p4 = new Point(100, 200);
			Size s4 = new Size(100, 100);
			DomainUpDown domainUpDown8 = new DomainUpDown("label4", p4, s4, action);
			this.Controls.Add(domainUpDown8);

		}
	}
}
