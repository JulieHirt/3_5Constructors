using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class MonthCalendarWindow : Form
	{
		public MonthCalendarWindow()
		{
			InitializeComponent();
		}

		private void MonthCalendarWindow_Load(object sender, EventArgs e)
		{

			//constructor 1
			MonthCalendar monthCalendar = new MonthCalendar();
			this.Controls.Add(monthCalendar);

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("date changed"); };
			MonthCalendar monthCalendar1 = new MonthCalendar(action);
			monthCalendar1.Location = new Point(350, 0);
			this.Controls.Add(monthCalendar1);

			//constructor 3
			Point location = new Point(700, 0);
			Size size = new Size(200, 200);
			MonthCalendar monthCalendar2 = new MonthCalendar(location, size, action);
			this.Controls.Add(monthCalendar2);
		}
	}
}
