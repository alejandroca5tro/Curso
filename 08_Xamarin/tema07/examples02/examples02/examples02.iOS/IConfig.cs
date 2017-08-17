using examples02;
using SQLite.Net.Interop;
using System;
using Xamarin.Forms;

//Dependency : servicio que nos permite tener compatibiidad en las tres plataformas
[assembly: Dependency(typeof(examples02.iOS.Config))]
namespace examples02.iOS
{
    class Config : IConfig
    {
        private string directorioDB;
        private ISQLitePlatform plataforma;
        public string DirectorioDB
        {//obtenemos el directorio en IOS
            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                {
                    var directorio = System.Environment.GetFolderPath(
                        Environment.SpecialFolder.Personal);
                    directorioDB = System.IO.Path.Combine(directorio, "..", "Library");
                }
                return directorioDB;
            }
        }

        public ISQLitePlatform Plataforma
        {//Obtenemos la plataforma en IOS
            get
            {
                if (plataforma == null)
                {
                    plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }
                return plataforma;
            }
        }
    }
}
