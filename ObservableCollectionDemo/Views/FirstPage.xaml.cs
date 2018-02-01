using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ObservableCollectionDemo
{
	public partial class FirstPage : ContentPage
	{
		public static ObservableCollection<Items> objSecondopageList;

		public FirstPage()
		{
			InitializeComponent();

			objSecondopageList = new ObservableCollection<Items>();

			NavigationPage.SetHasNavigationBar(this, false);
			EmployeeView.ItemsSource = objSecondopageList;
		}

		private async void BtnAdd_Click(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SecondPage());
		}
	}
}
