namespace GrenStockWebApi.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string SKU { get; set; }
        public int Amout { get; set; }
        public string ImageUrl { get; set; }
        public Category Category {get;set;}
        public int CategoryId {get;set;}    
    }
}