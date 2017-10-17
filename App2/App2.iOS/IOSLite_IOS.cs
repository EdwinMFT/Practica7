using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Foundation;
using UIKit;
using Xamarin.Forms;
using SQliteClase.iOS;
using System.IO;
using App2;
//using SQLite;

[assembly: Dependency(typeof(ISQLite_IOS))]
namespace SQliteClase.iOS
{
    public class ISQLite_IOS : ISQLite
    {
        public string GetLocalFilePath(String filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, filename);
        }

    }
}