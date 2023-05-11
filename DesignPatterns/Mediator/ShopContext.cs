namespace Mediator
{
    public class ShopContext : ICartInteraction
    {
        Cart cart;
        Catalog catalog;
        ProductPage page;

        public ShopContext(Cart cart, Catalog catalog, ProductPage page)
        {
            this.cart = cart;
            this.catalog = catalog;
            this.page = page;

            this.page.DisplayProducts(catalog.GetProducts());
        }

        public void AddToCart(int id)
        {
            cart.AddProduct(catalog.GetProducts().First(t => t.Id == id));
        }
    }
}
