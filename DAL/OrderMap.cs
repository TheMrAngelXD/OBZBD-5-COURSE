// <copyright file="OrderMap.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DAL
{
    using FluentNHibernate.Mapping;
    using PhotoStudio;

    internal class OrderMap : ClassMap<Order>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMap"/> class.
        /// </summary>
        public OrderMap()
        {
            this.Table("Orders");
            this.Id(x => x.Id);
            this.Map(x => x.NumOrder).Not.Nullable().Length(255);
            //this.References(x => x.client);
            this.HasManyToMany(x => x.service)
                .Cascade.Delete()
                .Not.Inverse();
        }
    }
}
