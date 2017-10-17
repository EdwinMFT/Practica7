using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPage : ContentPage
    {
        SQLiteConnection database;
        public SelectPage(object selectedItem)
        {
            var dato = selectedItem as TESHDatos;
            BindingContext = dato;
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB3.db3");
            database = new SQLiteConnection(db);
        }
        
        private void Actualizar_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                Matricula = Convert.ToInt32(Entry_Id.Text),
                Nombre = Entry_Name.Text,
                Apellidos = Entry_Ap.Text,
                Direccion=Entry_Dir.Text,
                Telefono=Entry_Tel.Text,
                Carrera=Entry_Car.Text,
                Semestre=Entry_Sem.Text,
                Correo=Entry_Cor.Text,
                Github=Entry_Git.Text
            };
            database.Update(datos);
            Navigation.PushAsync(new BasedeDatos());
            DisplayAlert("","Regsitro Actualizado","OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                Matricula = Convert.ToInt32(Entry_Id.Text),
                Nombre = Entry_Name.Text,
                Apellidos = Entry_Ap.Text,
                Direccion = Entry_Dir.Text,
                Telefono = Entry_Tel.Text,
                Carrera = Entry_Car.Text,
                Semestre = Entry_Sem.Text,
                Correo = Entry_Cor.Text,
                Github = Entry_Git.Text
            };
            database.Delete(datos);
            Navigation.PushAsync(new BasedeDatos());
            DisplayAlert("", "Regsitro Eliminado", "OK");
        }
    }
}