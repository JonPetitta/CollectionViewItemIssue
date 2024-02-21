namespace CollectionViewItemIssue.Services;
public interface INavigationService
{
    Task NavigateToAsync(string route, IDictionary<string, object>? routeParameters = null);

    Task PopAsync();
}
