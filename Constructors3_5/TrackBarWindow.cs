using System;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class TrackBarWindow : Form
	{
		public TrackBarWindow()
		{
			InitializeComponent();
		}

		private void TrackBarWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			TrackBar trackBar = new TrackBar();
			this.Controls.Add(trackBar);

			//constructor 2
			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("trackbar value changed"); };
			TrackBar trackBar1 = new TrackBar(action);
			trackBar1.Location = new Point(300, 0);
			this.Controls.Add(trackBar1);

			//constructor 3
			Point location2 = new Point(0, 100);
			Size size2 = new Size(200, 200);
			TrackBar trackBar2 = new TrackBar(location2, size2);
			this.Controls.Add(trackBar2);

			Point location3 = new Point(0, 200);
			Size size3 = new Size(300, 300);
			TrackBar trackBar3 = new TrackBar(location3, size3, action);
			this.Controls.Add(trackBar3);
		}
	}
}
