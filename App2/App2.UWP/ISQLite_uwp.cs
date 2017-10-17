using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using App2.UWP;
using Windows.Storage;
using SQLite;

[assembly: Dependency(typeof(ISQLite_uwp))]
namespace App2.UWP
{
    public class ISQLite_uwp : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
