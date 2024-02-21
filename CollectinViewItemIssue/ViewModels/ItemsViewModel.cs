using CollectionViewItemIssue.Services;
using CollectionViewItemIssue.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CollectionViewItemIssue.ViewModels
{
    public class ItemsViewModel : ObservableObject
    {
        private ObservableCollection<Item> items { get; set; } = new ObservableCollection<Item>();

        public IReadOnlyList<Item> Items => items;

        INavigationService navigationService;

        public ItemsViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            foreach (var item in new ItemMock().Items)
            {
                items.Add(item);
            }
        }
    }
}
