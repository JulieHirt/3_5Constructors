using System;
using System.Collections.Generic;
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

			//constructor 4
			var datasource = new List<string> {"1","2" };
			ListBox listBox4 = new ListBox(datasource);
			listBox4.Location = new System.Drawing.Point(120, 120);
			this.Controls.Add(listBox4);


			var PeopleList = new List<Person>();
			PeopleList.Add(new Person() { FirstName = "John", Picture = "Doe", Age = 40 });
			PeopleList.Add(new Person() { FirstName = "Jane", Picture = "Doe", Age = 30 });
			ListBox listBox5 = new ListBox(PeopleList, "Age");
			listBox5.Location = new System.Drawing.Point(250, 120);
			this.Controls.Add(listBox5);

			ListBox listBox6 = new ListBox(PeopleList, "Age", "FirstName");
			listBox6.Location = new System.Drawing.Point(400, 120);
			//AlertBox.Show(listBox6.DataSource.ToString());
			this.Controls.Add(listBox6);


			//note:IconMemeber is set to Picture change Picture values to a filepath to an icon.
			ListBox listBox7 = new ListBox(PeopleList, "Age", "FirstName", "Picture");
			listBox7.Location = new System.Drawing.Point(520, 120);
			this.Controls.Add(listBox7);


			//note:IconMemeber is set to Picture change Picture values to a filepath to an icon.
			ListBox listBox8 = new ListBox(PeopleList, "Age", "FirstName", "Picture", action);
			listBox8.Location = new System.Drawing.Point(0, 220);
			this.Controls.Add(listBox8);

			//constructor 5
			Point location9 = new Point(120, 220);
			Size size9 = new Size(100, 100);
			ListBox listBox9 = new ListBox(location9, size9, PeopleList);
			this.Controls.Add(listBox9);


			Point location10 = new Point(250, 220);
			Size size10 = new Size(100, 100);
			ListBox listBox10 = new ListBox(location10, size10, PeopleList, "Age");
			this.Controls.Add(listBox10);

			Point location11 = new Point(400, 220);
			Size size11 = new Size(110, 110);
			ListBox listBox11 = new ListBox(location11, size11, PeopleList, "Age", "FirstName");
			this.Controls.Add(listBox11);

			Point location12 = new Point(0, 320);
			Size size12 = new Size(120, 120);
			ListBox listBox12 = new ListBox(location12, size12, PeopleList, "Age", "FirstName", "Picture");
			this.Controls.Add(listBox12);

			Point location13 = new Point(120, 320);
			Size size13 = new Size(130, 130);
			ListBox listBox13 = new ListBox(location13, size13, PeopleList, "Age", "FirstName", "Picture", action);
			this.Controls.Add(listBox13);



		}
	}

	public class Person
	{
		public string FirstName { get; set; }
		public string Picture { get; set; }
		public int Age { get; set; }
	}
}
