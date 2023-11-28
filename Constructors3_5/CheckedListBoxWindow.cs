using System;
using System.Collections.Generic;
using System.Drawing;
using Wisej.Web;

namespace Constructors3_5
{
	public partial class CheckedListBoxWindow : Form
	{
		public CheckedListBoxWindow()
		{
			InitializeComponent();
		}

		private void CheckedListBoxWindow_Load(object sender, EventArgs e)
		{




			//constructor 1
			var myGroceries = new List<string>() {
				"Eggs", "Apples", "Milk"
			};
			CheckedListBox checkedListBox1 = new CheckedListBox();
			checkedListBox1.DataSource = myGroceries;
			flowLayoutPanel1.Controls.Add(checkedListBox1);

			//constructor 2
			var myGroceries2 = new List<string>() {
				"Orange", "Grapes", "Cheese"
			};
			CheckedListBox checkedListBox2 = new CheckedListBox((s, args) => AlertBox.Show("You checked checkedListBox2!"));
			checkedListBox2.DataSource = myGroceries2;
			flowLayoutPanel1.Controls.Add(checkedListBox2);

			//constructor 3
			var myGroceries3 = new List<string>() {
				"Chicken", "Bacon", "Avocado"
			};
			CheckedListBox checkedListBox3 = new CheckedListBox(new Point(0, 50), new Size(150, 250), (s, args) => AlertBox.Show("You checked checkedListBox3!"));
			checkedListBox3.DataSource = myGroceries3;
			this.Controls.Add(checkedListBox3);

			//constructor 4
			var myList4 = new List<dynamic>()
{
	new { id = 1, name = "John", icon = "Images/apple.png", checkState = false },
	new { id = 2, name = "Jane", icon = "menu-overflow", checkState = false },
	new { id = 3, name = "Sally", icon = "menu-overflow", checkState = false }
};
			CheckedListBox checkedListBox4 = new CheckedListBox(myList4,"name", "id", "icon", "checkState", (s, args) => AlertBox.Show("You checked checkedListBox4!"));
			flowLayoutPanel1.Controls.Add(checkedListBox4);

			var myGroceries5 = new List<string>() {
				"Egg", "Fish", "Tomato"
			};
			CheckedListBox checkedListBox5 = new CheckedListBox(myGroceries5);
			flowLayoutPanel1.Controls.Add(checkedListBox5);

			//constructor 5
			var myList6 = new List<dynamic>()
{
	new { id = 1, name = "Ted", icon = "Images/apple.png", checkState = false },
	new { id = 2, name = "Fred", icon = "Images/apple.png", checkState = false },
	new { id = 3, name = "Ned", icon = "menu-overflow", checkState = false }
};
			CheckedListBox checkedListBox6 = new CheckedListBox(new Point(200, 250), new Size(190, 150), myList6, "name", "id", "icon", "checkState", (s, args) => AlertBox.Show("You checked checkedListBox6!"));
				this.Controls.Add(checkedListBox6);

			var myList7 = new List<dynamic>()
{
	new { id = 1, name = "one", icon = "Images/apple.png", checkState = false },
	new { id = 2, name = "two", icon = "Images/apple.png", checkState = false },
	new { id = 3, name = "three", icon = "menu-overflow", checkState = false }
};
			CheckedListBox checkedListBox7 = new CheckedListBox(new Point(400, 250), new Size(190, 100), myList7, "name", "id", "icon", "checkState");
			this.Controls.Add(checkedListBox7);

			var myGroceries8 = new List<string>() {
				"Pineapple", "Bacon", "Cheese"
			};
			CheckedListBox checkedListBox8 = new CheckedListBox(new Point(600, 250), new Size(190, 100), myGroceries8);
			this.Controls.Add(checkedListBox8);

		}
	}
}
