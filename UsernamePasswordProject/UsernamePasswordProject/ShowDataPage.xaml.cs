using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsernamePasswordProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowDataPage : ContentPage
    {
        /*
        public ObservableCollection<User> userListView { get; set; }
        
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        */
        
        public ShowDataPage()
        {
            InitializeComponent();

            /*
            userListView = new ObservableCollection<User>();
            
            userListView.Add(new User() { Username = "Alyssa", Password="abc" });
            userListView.Add(new User() { Username = "Brennan", Password="123" });

            BindingContext = this;
            */
        }

        async void OnItemClicked (object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}