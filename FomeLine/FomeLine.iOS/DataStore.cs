using FomeLine.Repository.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(FomeLine.iOS.DataStore))]
namespace FomeLine.iOS
{
    public class DataStore : IDataStore
    {
        private string _diretorioDb;
        public string Path
        {
            get
            {
                if (string.IsNullOrEmpty(_diretorioDb))
                {
                    _diretorioDb = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return _diretorioDb;
            }
        }

        private SQLite.Net.Interop.ISQLitePlatform _plataforma;
        public SQLite.Net.Interop.ISQLitePlatform Plataform
        {
            get
            {
                if (_plataforma == null) _plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                return _plataforma;
            }

        }

        public DataStore()
        {
        }
    }
}