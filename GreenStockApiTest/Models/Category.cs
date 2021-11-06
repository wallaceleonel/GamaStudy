using System.Collections.Generic;

namespace GrenStockWebApi.Models
{
    public class Category
    {
       public int CategoryId { get; set; }
       public string Name { get; set; }
       public short  SizeTipe { get; set; }
       public List<Product> Product { get; set; }

    }
    
}   