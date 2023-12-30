namespace Datiov2test.Models
{
    public class CategoryModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
