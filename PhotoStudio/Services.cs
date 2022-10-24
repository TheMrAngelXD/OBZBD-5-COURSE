/// <summary>
/// Фотостудия.
/// </summary>
namespace PhotoStudio
{
    /// <summary>
    ///  Услуги.
    /// </summary>
    public class Services
    {
        public Services(string numService, string nameService, string quantity, string price)
        {
            if (string.IsNullOrEmpty(numService))
            {
                throw new ArgumentNullException(numService);
            }
            if (string.IsNullOrEmpty(nameService))
            {
                throw new ArgumentNullException(nameService);
            }
            if (string.IsNullOrEmpty(quantity)) 
            {
                throw new ArgumentNullException(quantity);
            }
            if (string.IsNullOrEmpty(price)) 
            {
                throw new ArgumentNullException(price);
            }

            this.NumService = numService;
            this.NameService = nameService;
            this.Quantity = quantity;
            this.Price = price;
        }
        public string NumService { get; }
        public string NameService { get; }

        public string Quantity { get; }

        public string Price { get; }

        public override string ToString()
        {
            return $"{NumService} {NameService} {Quantity} {Price}";
        }
    }
}
