using System;
using System.Collections.Generic;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class ComboBoxWindow : Form
	{
		public ComboBoxWindow()
		{
			InitializeComponent();
		}

		private void ComboBoxWindow_Load(object sender, EventArgs e)
		{
			//constructor 1
			ComboBox combobox1 = new ComboBox();
			combobox1.Items.Add("apple");
			flowLayoutPanel1.Controls.Add(combobox1);

			//constructor 2
			ComboBox combobox2 = new ComboBox((s, args) => AlertBox.Show("You selected an item from combobox2!"));
			combobox2.Items.Add("item1");
			flowLayoutPanel1.Controls.Add(combobox2);

			//constructor 3
			ComboBox combobox3 = new ComboBox("initial text", (s, args) => AlertBox.Show("You selected an item from combobox3!"));
			combobox3.Items.Add("item1");
			flowLayoutPanel1.Controls.Add(combobox3);

			ComboBox combobox4 = new ComboBox("combobox4");
			combobox3.Items.Add("item1");
			flowLayoutPanel1.Controls.Add(combobox3);

			//constructor 4
			ComboBox combobox5 = new ComboBox(new Point(0, 50), new Size(150, 250), null);
			combobox5.Items.Add("combobox5 item1");
			this.Controls.Add(combobox5);

			ComboBox combobox6 = new ComboBox(new Point(0, 150), new Size(150, 250), (s, args) => AlertBox.Show("You selected an item from combobox6!"));
			combobox6.Items.Add("combobox6 item1");
			this.Controls.Add(combobox6);

			//constructor 5
			ComboBox combobox7 = new ComboBox("combobox7", new Point(0, 200), new Size(150, 250), null);
			combobox7.Items.Add("combobox7 item1");
			this.Controls.Add(combobox7);

			ComboBox combobox8 = new ComboBox("combobox8", new Point(0, 250), new Size(150, 250), (s, args) => AlertBox.Show("You selected an item from combobox8!"));
			combobox8.Items.Add("combobox8 item1");
			this.Controls.Add(combobox8);

			//constructor 6
			var myGroceries9 = new List<string>() {
				"Eggs", "Apples", "Milk"
			};
			ComboBox combobox9 = new ComboBox(myGroceries9);
			flowLayoutPanel1.Controls.Add(combobox9);


			var myList10 = new List<dynamic>()
{
	new { id = 1, name = "John", icon = "Images/apple.png" },
	new { id = 2, name = "Jane", icon = "menu-overflow"},
	new { id = 3, name = "Sally", icon = "menu-overflow"}
};
			ComboBox combobox10 = new ComboBox(myList10, "name", "id", "icon", (s, args) => AlertBox.Show("You selected an item from combobox10!"));
			flowLayoutPanel1.Controls.Add(combobox10);

			//constructor 7

			//		combobox2.Items.Add(
			//new
			//{
			//	ID = 1,
			//	Name = "Wisej",
			//	Icon = "icon-print",
			//	Tooltip = "Tooltip for item 1"
			//});
		}
	}
}
