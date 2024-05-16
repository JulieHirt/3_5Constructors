using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class LinkLabelWindow : Form
	{
		public LinkLabelWindow()
		{
			InitializeComponent();
		}

		private void LinkLabelWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			LinkLabel linkLabel1 = new LinkLabel();
			linkLabel1.Text = "hello";
			this.Controls.Add(linkLabel1);

			//constructor 2
			LinkLabel linkLabel2 = new LinkLabel("test text here");
			linkLabel2.Location = new System.Drawing.Point(0, 30);
			this.Controls.Add(linkLabel2);


			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("clicked linklabel"); };
			LinkLabel linkLabel3 = new LinkLabel("action", action);
			linkLabel3.Location = new System.Drawing.Point(0, 60);
			this.Controls.Add(linkLabel3);

			//constructor 3
			LinkLabel linkLabel4 = new LinkLabel("here is a very very long text", new Point(0, 100), new Size(100, 50), action);
			this.Controls.Add(linkLabel4);
		}
	}
}
