﻿using System.Collections.Immutable;

namespace ReportGenerator2
{
    public sealed class City
    {
        public City(string name, ImmutableArray<Customer> customers)
        {
            Name = name;
            Customers = customers;
        }

        public string Name { get; }

        public ImmutableArray<Customer> Customers { get; }
    }
}