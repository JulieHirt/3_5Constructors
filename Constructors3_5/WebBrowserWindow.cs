using System;
using System.Drawing;
using System.Security.Policy;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class WebBrowserWindow : Form
	{
		public WebBrowserWindow()
		{
			InitializeComponent();
		}

		private void WebBrowserWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			WebBrowser webBrowser = new WebBrowser();
			webBrowser.Size = new System.Drawing.Size(100,100);
			this.Controls.Add(webBrowser);


			//constructor 2
			WebBrowser webBrowser1 = new WebBrowser("https://demo.wisej.com/codeproject");
			webBrowser1.Location = new Point(150, 0);
			webBrowser1.Size = new System.Drawing.Size(100, 100);
			this.Controls.Add(webBrowser1);

			Action<object, EventArgs> action = (obj, args) => { AlertBox.Show("document completed"); };
			WebBrowser webBrowser2 = new WebBrowser("https://demo.wisej.com/codeproject", action);
			webBrowser2.Location = new Point(300, 0);
			webBrowser2.Size = new System.Drawing.Size(100, 100);
			this.Controls.Add(webBrowser2);

			//constructor 3
			Point location3 = new Point(450, 0);
			Size size3 = new Size(100, 100);
			WebBrowser webBrowser3 = new WebBrowser(location3, size3);
			this.Controls.Add(webBrowser3);

			Point location4 = new Point(0, 150);
			Size size4 = new Size(100, 100);
			WebBrowser webBrowser4 = new WebBrowser(location4, size4, action);
			webBrowser4.Url = new Uri ("https://demo.wisej.com/codeproject");
			this.Controls.Add(webBrowser4);

			//constructor 4
			Point location5 = new Point(150, 150);
			Size size5 = new Size(100, 100);
			WebBrowser webBrowser5 = new WebBrowser("https://demo.wisej.com/codeproject", location5, size5);
			this.Controls.Add(webBrowser5);

			Point location6 = new Point(300, 150);
			Size size6 = new Size(100, 100);
			WebBrowser webBrowser6 = new WebBrowser("https://demo.wisej.com/codeproject", location6, size6, action);
			this.Controls.Add(webBrowser6);

		}
	}
}
