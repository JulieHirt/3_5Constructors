using System;
using Wisej.Web;

namespace Constructors3_5
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			ButtonWindow buttonWindow = new ButtonWindow();
			buttonWindow.Show();

			CheckboxWindow checkboxWindow = new CheckboxWindow();
			checkboxWindow.Show();

			CheckedListBoxWindow checkedListBoxWindow = new CheckedListBoxWindow();
			checkedListBoxWindow.Show();

			ComboBoxWindow comboBoxWindow = new ComboBoxWindow();
			comboBoxWindow.Show();

			DateTimePickerWindow dateTimePickerWindow = new DateTimePickerWindow();
			dateTimePickerWindow.Show();

			DomainUpDownWindow domainUpDownWindow = new DomainUpDownWindow();
			domainUpDownWindow.Show();

			FlowLayoutPanelWindow flowLayoutPanelWindow = new FlowLayoutPanelWindow();
			flowLayoutPanelWindow.Show();

			FormWindow formWindow = new FormWindow();
			formWindow.Show();

			LinkLabelWindow linkLabelWindow = new LinkLabelWindow();
			linkLabelWindow.Show();

			ListBoxWindow listBoxWindow = new ListBoxWindow();
			listBoxWindow.Show();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}