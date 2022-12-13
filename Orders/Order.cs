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

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Order"/>.
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="id">Айди</param>
        /// <param name="numOrder">Номер заказа</param>
        /// <param name="client">Клиент</param>
        public Order(string numOrder, ISet<Client> client)
        {
            if (string.IsNullOrEmpty(numOrder))
            {
                throw new ArgumentNullException(nameof(numOrder));
            }
            this.NumOrder = numOrder;
            this.client = client;
            this.Id = Guid.NewGuid();
            this.service = service;
        }

        public virtual bool AddService(Service service)
        {
            return service is null
                ? throw new ArgumentNullException(nameof(service))
                : this.service.Add(service);
        }

        public Order(string numOrder, params Client[] client)
            : this(numOrder, new HashSet<Client>(client))
        {
        }

        [Obsolete("For ORM only", true)]
        protected Order()
        {
        }

        public virtual string NumOrder { get; }

        public virtual ISet<Client> client { get; } = new HashSet<Client>();

        public virtual Guid Id { get; }

        public virtual ISet<Service> service { get; } = new HashSet<Service>();

        public override string ToString()
        {
            return $"{this.NumOrder},{string.Join(", ", this.client)}";
        }
    }
}