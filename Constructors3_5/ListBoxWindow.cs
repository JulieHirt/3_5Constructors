using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class ListBoxWindow : Form
	{
		public ListBoxWindow()
		{
			InitializeComponent();
		}

		private void ListBoxWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			ListBox listBox = new ListBox();
			this.Controls.Add(listBox);

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("selected index changed"); };
			ListBox listBox1 = new ListBox(action);
			listBox1.Items.Add("one");
			listBox1.Items.Add("two");
			listBox1.Location = new System.Drawing.Point(150, 0);
			this.Controls.Add(listBox1);

			//constructor 3
			Point location = new Point(300,0);
			Size size  = new Size(100,100);
			ListBox listBox2 = new ListBox(location, size, action);
			listBox2.Items.Add("one");
			listBox2.Items.Add("two");
			this.Controls.Add(listBox2);


			Point location3 = new Point(0, 120);
			Size size3 = new Size(100, 100);
			ListBox listBox3 = new ListBox(location3, size3);
			listBox3.Items.Add("one");
			listBox3.Items.Add("two");
			this.Controls.Add(listBox3);


		}
	}
}
