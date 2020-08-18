using System.ComponentModel.DataAnnotations;

namespace EconomicMappingAPI.Models
{ 
    public class UrlQuery
    {
        private const int maxPageSize = 20;
        public int _PageNumber { get; set; }
        public int _PageSize { get; set; }
        public UrlQuery(int pageNumber, int pageSize)
        {
            _PageNumber = pageNumber;
            _PageSize = pageSize;
        }
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value < maxPageSize) ? value : maxPageSize;
            }
        }
    }
}