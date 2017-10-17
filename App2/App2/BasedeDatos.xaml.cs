using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasedeDatos : ContentPage
    {
        public ObservableCollection<TESHDatos> Items { set; get; }
        SQLiteConnection database;
        public BasedeDatos()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB3.db3");
            database = new SQLiteConnection(db);
            database.CreateTable<TESHDatos>();


            Items = new ObservableCollection<TESHDatos>(database.Table<TESHDatos>());
            BindingContext = this;

        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            await Navigation.PushAsync(new SelectPage(e.SelectedItem as TESHDatos));

        }

        private void InsertarRegistros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TeshPage());
        }
    }
}