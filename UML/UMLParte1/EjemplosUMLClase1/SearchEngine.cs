namespace ejemplosClase;

public class SearchEngine
{
    public void searchUsingController(SearchController controller, string search)
    {
        var result = controller.search(search);
    }
}