// <copyright file="Client.cs" company="Костенко Станислав Александрович">
// Copyright (c) Костенко Станислав Александрович. All rights reserved.
// </copyright>

namespace PhotoStudio
{
    public class Client : IEquatable<Client>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="numClient">Номер Клиента</param>
        /// <param name="fullName">ФИО</param>
        /// <param name="address">Адрес</param>
        /// <param name="email">Е-мэил</param>
        public Client(int numClient, string fullName, string address, string email)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentNullException(fullName);
            }

            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentNullException(address);
            }

            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException(email);
            }
            
            this.Id = Guid.NewGuid();
            this.NumClient = numClient;
            this.Fullname = fullName;
            this.Address = address;
            this.Email = email;
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual Guid Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int NumClient { get; }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual string Fullname { get; }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual string Address { get; }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual string Email { get; }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual ISet<Order> Order { get; } = new HashSet<Order>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        [Obsolete("For ORM only", true)]
        protected Client()
        {
        }

        /// <inheritdoc/>
        public virtual bool Equals(Client? other)
        {
            return other is not null && (ReferenceEquals(this, other) || this.Id == other.Id);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)

        {

            return (obj is Client other)
                && string.Equals(this.Email, other.Email, StringComparison.InvariantCulture);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{this.NumClient},{this.Fullname},{this.Address},{this.Email}";
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Email.GetHashCode();
        }
    }
}
