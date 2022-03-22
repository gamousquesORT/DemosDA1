using System;

namespace ejemplosClase
{
    public class SearchEngine
    {
        public void searchUsingController(SearchController controller, String search)
        {
            String result = controller.search(search);
        }
    }
}