using System;
using System.Drawing;
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

		}
	}
}
