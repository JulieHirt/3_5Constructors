using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class DateTimePickerWindow : Form
	{
		public DateTimePickerWindow()
		{
			InitializeComponent();
		}

		private void DateTimePickerWindow_Load(object sender, EventArgs e)
		{
			DateTimePicker datetimepicker1 = new DateTimePicker();
			this.Controls.Add(datetimepicker1);
			AlertBox.Show(datetimepicker1.Size.ToString());

			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("changed"); };
			DateTimePicker datetimepicker2 = new DateTimePicker(action);
			datetimepicker2.Location = new Point(300, 50);
			this.Controls.Add(datetimepicker2);

			DateTimePicker datetimepicker3 = new DateTimePicker("label", action);
			datetimepicker3.Location = new Point(200, 50);
			this.Controls.Add(datetimepicker3);

			Point p = new Point(200, 100);
			Size s = new Size(200, 30);
			DateTimePicker datetimepicker4 = new DateTimePicker(p, s);
			this.Controls.Add(datetimepicker4);

			DateTimePicker datetimepicker5 = new DateTimePicker(p, s, action);
			datetimepicker5.Location = new Point(300, 100);
			this.Controls.Add(datetimepicker5);


			Point p1 = new Point(200, 200);
			Size s1 = new Size(200, 30);
			Action<object, EventArgs> action1 = (obj, args) => { AlertBox.Show("changed1"); };
			DateTimePicker datetimepicker6 = new DateTimePicker("label", p1, s1, action1);
			this.Controls.Add(datetimepicker6);

		}
	}
}
