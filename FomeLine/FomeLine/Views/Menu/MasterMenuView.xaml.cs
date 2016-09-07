using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Menu
{
    public partial class MasterMenuView : MasterDetailPage
    {
        public MasterMenuView()
        {
            InitializeComponent();
            BindingContext = new HomeVm();
        }
    }
}