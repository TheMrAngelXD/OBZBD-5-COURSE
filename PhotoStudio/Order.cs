/// <summary>
/// Фотостудия.
/// </summary>
namespace PhotoStudio
{
    /// <summary>
    ///  Заказы.
    /// </summary>
    public class Order
    {
        public Order(string numOrder, ISet<Clients> clients)
        {
            if (string.IsNullOrWhiteSpace(numOrder))
            {
                throw new ArgumentNullException(nameof(numOrder));
            }
            this.NumOrder = numOrder;
            this.Clients = clients;
           
        }
        public Order(string numOrder, params Clients[] clients)
            : this(numOrder, new HashSet<Clients>(clients))
        { 
        }
        public string NumOrder { get; }
        public ISet<Clients> Clients { get; } = new HashSet<Clients>();

        public override string ToString()
        {
            return $"{this.NumOrder} {string.Join(", ",this.Clients)}";
        }
    }
}