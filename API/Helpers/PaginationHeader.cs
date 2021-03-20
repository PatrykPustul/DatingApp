namespace API.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            CurrentPage = currentPage;
            ItemsPerpage = itemsPerPage;
            TotalItems = totalItems;
            TotalPages = totalPages;
        }

        public int CurrentPage {get; set;}
        public int ItemsPerpage {get; set;}
        public int TotalItems {get;set;}
        public int TotalPages {get;set;}
    }
}