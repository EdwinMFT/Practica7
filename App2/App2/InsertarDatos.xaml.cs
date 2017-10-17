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
    public partial class InsertarDatos : ContentPage
    {
        SQLiteConnection database;
        public InsertarDatos()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB3.db3");
            database = new SQLiteConnection(db);
            database.CreateTable<TESHDatos>();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                Matricula = Convert.ToInt32(Entry_ID.Text),
                Nombre = Entry_Name.Text,
                Apellidos = Entry_Ap.Text,
                Direccion=Entry_Dir.Text,
                Telefono=Entry_Tel.Text,
                Carrera=Entry_Car.Text,
                Semestre=Entry_Sem.Text,
                Correo=Entry_Cor.Text,
                Github=Entry_Git.Text



            };
            database.Insert(datos);
            Navigation.PushAsync(new BasedeDatos());
        }
    }
}