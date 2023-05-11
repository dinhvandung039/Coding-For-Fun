namespace Mediator
{
    public class ProductPage
    {
        ICartInteraction cart;
        public ProductPage(ICartInteraction cart)
        {
            this.cart = cart;
        }
        public void DisplayProducts(List<Product> products)
        {
            // do something
        }

        public void AddToCart(int id) => cart.AddToCart(id);
    }
}