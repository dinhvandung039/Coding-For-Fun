namespace Mediator
{
    public class Cart
    {
        List<Product> products;

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
