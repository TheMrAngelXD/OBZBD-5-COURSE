// <copyright file="ServiceMap.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DAL
{
    using FluentNHibernate.Mapping;
    using PhotoStudio;

    internal class ServiceMap : ClassMap<Service>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMap"/> class.
        /// </summary>
        public ServiceMap()
        {
            this.Table("Services");
            this.Id(x => x.Id);
            this.Map(x => x.NumService).Not.Nullable().Length(255);
            this.Map(x => x.NameService).Not.Nullable().Length(255);
            this.Map(x => x.Quantity).Not.Nullable().Length(255);
            this.Map(x => x.Price).Not.Nullable().Length(255).Unique();
            this.HasManyToMany(x => x.order)
               .Inverse();
        }
    }
}
