using System.Collections.Generic;
using Xamarin.Forms;

namespace FomeLine.Views.Menu
{
    public class MenuListView : ListView
    {
        public MenuListView()
        {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            var cell = new DataTemplate(typeof(MenuCell));
            cell.SetBinding(TextCell.TextProperty, "Titulo");
            
            ItemTemplate = cell;
        }
    }
}