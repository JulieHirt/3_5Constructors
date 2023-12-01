using System;
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
		}
	}
}
