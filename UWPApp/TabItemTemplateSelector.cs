
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWPApp
{
    public class TabItemTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var homeIdentity = item as HomeIdentity;
            return homeIdentity == null ? OfficeTemplate : HomeTemplate;
        }

        public DataTemplate HomeTemplate { get; set; }
        public DataTemplate OfficeTemplate { get; set; }
    }
}
