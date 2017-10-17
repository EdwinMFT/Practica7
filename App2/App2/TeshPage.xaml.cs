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
    //static TeshDatabase database;
    //public static TeshDatabase Database
    //{
    //    get
    //    {
    //        if (database == null)
    //        {
    //            database = new TeshDatabase(DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB.db"));

    //        }
    //        return database;
    //    }
    //}
    //public Teshdatabase(string dbpath)
    //{
    //    database = new SQLiteAsyncConnection(dbpath);
    //    database.CreateTableAsync<TESHDatos>().wait();
        
    //}







    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TeshPage : ContentPage
	{
        public TeshPage()
        {
            InitializeComponent();
            //var imagenDS = new Image
            //{
            //    Source = (ImageSource.FromResource("App2.imagends.jpg")),
            //  //  Source =ImageSource.FromUri(new Uri("https://www.google.com.mx/search?q=goo&rlz=1C1CHBD_esMX762MX762&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjdmerd6-LWAhWq1IMKHbtkCKkQ_AUICigB&biw=1366&bih=662")) //desde internet 
            //};
            //Content = imagenDS;

            //SQLiteAsyncConnection database;
            //string db;
            //db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB.db");
            //database = new SQLiteAsyncConnection(db);
            //database.CreateTableAsync<TESHDatos>().Wait();
            //var elemento = new TESHDatos
            //{
            //    Matricula = 1,
            //    Nombre = "Edwin",
            //    Apellidos = "Michael",
                
            //};
            //database.InsertAsync(elemento);
            
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BasedeDatos());

            //PopAync: regresa ala pagina anterior
            //PopModalAsync: regresa a la pagina anterior sin poder avanzar nuevamente
            //pushModalAsync: va siguiendo un curso de paginas sin poder regresar
            //removeAge: libera los recursos de la memoria del dispositivo elimina la pagina que ya no quiera utilizar
            //popToRootAsync: ingresa ala pagina de raiz
            //pushAsync
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertarDatos());
        }
    }
}