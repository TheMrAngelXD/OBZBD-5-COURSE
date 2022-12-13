/// <summary>
/// Фотостудия.
/// </summary>
namespace PhotoStudio
{
    /// <summary>
    ///  Услуги.
    /// </summary>
    public class Service
    {
        public Service(string numService, string nameService, string quantity, string price)
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

            this.Id = Guid.NewGuid();
            this.NumService = numService;
            this.NameService = nameService;
            this.Quantity = quantity;
            this.Price = price;
        }

        [Obsolete("For ORM only", true)]
        protected Service()
        {
        }

        public virtual string NumService { get; }

        public virtual string NameService { get; }

        public virtual string Quantity { get; }

        public virtual string Price { get; }

        public virtual Guid Id { get; }

        public virtual ISet<Order> order { get; } = new HashSet<Order>();

        public override string ToString()
        {
            return $"{NumService},{NameService},{Quantity},{Price}";
        }
    }
}
