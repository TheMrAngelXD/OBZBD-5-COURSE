// <copyright file="ClientMap.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DAL
{
    using FluentNHibernate.Mapping;
    using PhotoStudio;

    internal class ClientMap : ClassMap<Client>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMap"/> class.
        /// </summary>
        public ClientMap()
        {
            this.Table("Clients");
            this.Id(x => x.Id);
            this.Map(x => x.NumClient).Not.Nullable().Length(255);
            this.Map(x => x.Fullname).Not.Nullable().Length(255);
            this.Map(x => x.Address).Not.Nullable().Length(255);
            this.Map(x => x.Email).Not.Nullable().Length(255).Unique();
            this.HasManyToMany(x => x.Order)
                .Cascade.Delete()
                .Not.Inverse();
        }
    }
}
