using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment
{
    public class Deprivation : Entity<int>
    {
        public string? Name { get; private set; }

        public int? Number { get; private set; }

        public DeprivationType DeprivationType { get; private set; }


        Deprivation(int id, string name, int? number, DeprivationType deprivationType)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }

            SetName(name);
            SetNumber(number);
            SetDeprivationType(deprivationType);
            Id = id;

        }

        Deprivation(string name, int? number, DeprivationType deprivationType)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }

            SetName(name);
            SetNumber(number);
            SetDeprivationType(deprivationType);
        }




        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(" name cannot be empty", nameof(name));
            }

            Name = name;
        }


        public void SetNumber(int? number)
        {
            if (number.HasValue && number < 0)
            {
                throw new ArgumentException("Number cannot be negative", nameof(number));
            }

            Number = number;
        }

        public void SetDeprivationType(DeprivationType deprivationType)
        {
            if (deprivationType < 0)
            {
                throw new ArgumentException("deprivationType cannot be negative", nameof(deprivationType));
            }

            DeprivationType = deprivationType;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Deprivation)obj;
            return EqualityComparer<int>.Default.Equals(Id, other.Id) &&
                   Name == other.Name &&
                   Number == other.Number &&
                   DeprivationType == other.DeprivationType;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Number);
        }

        public override string ToString()
        {
            return $"[Deprivation: Id={Id},Name={Name},Number={Number},DeprivationType={DeprivationType}]";
        }
    }


}
