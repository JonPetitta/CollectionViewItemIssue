using CollectionViewItemIssue.ViewModels;

namespace CollectionViewItemIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage(ItemsViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
        }
    }

}
