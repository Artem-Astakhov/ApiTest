
using System.Collections.Generic;


namespace ApiTestLibrary
{
    public class RootObject
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public string status { get; set; }
    }
}
