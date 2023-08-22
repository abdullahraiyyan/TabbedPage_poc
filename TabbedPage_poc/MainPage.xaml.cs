using TabbedPage_poc.viewmodel;

namespace TabbedPage_poc
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext=new MainViewModel();
            SetCarouselTemplate();
        }

        private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
              CustomTabsView.ScrollTo(e.CurrentItem, null, ScrollToPosition.MakeVisible, true);
        }

        void SetCarouselTemplate()
        {
            var template = new DataTemplate(() =>
            {

                ContentView carouselItem = new ContentView();

                carouselItem.SetBinding(ContentView.ContentProperty, new Binding(nameof(TabViewModel.CarouselItem)));
                return carouselItem;
            });
            carrrrr.ItemTemplate = template;

        }
    }
}
