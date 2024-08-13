using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.Abstruct
{
    public abstract class TBaseEntity<TKey> : Entity<TKey>
    {
        protected TBaseEntity(TKey id, string name, int? ord)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }

            SetName(name);
            SetOrd(ord);
            Id = id;

        }

        protected TBaseEntity(string name, int? ord)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }

            SetName(name);
            SetOrd(ord);

        }

        public string Name { get; private set; }

        public int? Ord { get; private set; }


        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(" name cannot be empty", nameof(name));
            }

            Name = name;
        }


        public void SetOrd(int? ord)
        {
            if (ord.HasValue && ord < 0)
            {
                throw new ArgumentException("Order cannot be negative", nameof(ord));
            }

            Ord = ord;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (TBaseEntity<TKey>)obj;
            return EqualityComparer<TKey>.Default.Equals(Id, other.Id) &&
                   Name == other.Name &&
                   Ord == other.Ord;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Ord);
        }

        public override string ToString()
        {
            return $"[TBaseEntity: Id={Id},Ord={Ord}]";
        }
    }


}
