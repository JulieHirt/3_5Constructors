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

			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("changed"); };
			DateTimePicker datetimepicker2 = new DateTimePicker(action);
			datetimepicker2.Location = new Point(300, 50);
			this.Controls.Add(datetimepicker2);

			DateTimePicker datetimepicker3 = new DateTimePicker("label", action);
			datetimepicker3.Location = new Point(200, 50);
			this.Controls.Add(datetimepicker3);

			Point p = new Point(400, 50);
			Size s = new Size(100, 100);
			DateTimePicker datetimepicker4 = new DateTimePicker(p, s);
			this.Controls.Add(datetimepicker4);

		}
	}
}
