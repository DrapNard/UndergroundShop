using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace UndergroundShop.Views.Main
{
    public partial class BrowseView : UserControl
    {
        public BrowseView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
