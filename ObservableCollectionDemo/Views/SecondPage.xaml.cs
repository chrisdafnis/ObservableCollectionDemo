using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ObservableCollectionDemo
{
	public partial class SecondPage : ContentPage
	{

		public SecondPage()
		{
			InitializeComponent();
		}

		private async void BtnSave_Click(object sender, EventArgs e)
		{
			FirstPage.objSecondopageList.Add(new Items
			{
				FirstName = entryfirstname.Text,
				LastName = entrylastname.Text,
				CompanyName = entrycomapanyname.Text,
				MobileNumber = entrymobilenumber.Text,
				Designation = entrydesignation.Text,
				Address = editoraddress.Text
			});

			await Navigation.PopAsync();
		}

		void mobileNoChanged(object sender, TextChangedEventArgs e)
		{
			var mobileObject = (Entry)sender;
			var textValue = mobileObject.Text;
			if (textValue.Length > 10)
			{
				entrymobilenumber.Text = textValue.Remove(textValue.Length - 1);
			}
		}
	}

	public class Items
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string CompanyName { get; set; }

		public string MobileNumber { get; set; }

		public string Designation { get; set; }

		public string Address { get; set; }
	}
}
