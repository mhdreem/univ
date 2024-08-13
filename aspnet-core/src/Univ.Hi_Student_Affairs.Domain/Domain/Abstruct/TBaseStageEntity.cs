using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.Abstruct
{
    public class TBaseStageEntity<TKey> : Entity<TKey>
    {
        protected TBaseStageEntity(TKey id, string name, int? ord, StageState stageState)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }
            if (stageState < 0)
            {
                throw new ArgumentException("Invalid stageState", nameof(name));
            }
            SetName(name);
            SetStageState(stageState);
            SetOrd(ord);
            Id = id;

        }

        protected TBaseStageEntity(string name, int? ord, StageState stageState)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }

            SetName(name);
            SetStageState(stageState);
            SetOrd(ord);

        }

        public string Name { get; private set; }
        public StageState StageState { get; private set; }
        public int? Ord { get; private set; }


        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(" name cannot be empty", nameof(name));
            }

            Name = name;
        }

        public void SetStageState(StageState stageState)
        {
            if (stageState < 0)
            {
                throw new ArgumentException("stageState cannot be negative", nameof(stageState));
            }

            StageState = stageState;
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

            var other = (TBaseStageEntity<TKey>)obj;
            return EqualityComparer<TKey>.Default.Equals(Id, other.Id) &&
                   Name == other.Name &&
                   StageState == other.StageState &&
                   Ord == other.Ord;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Ord);
        }

        public override string ToString()
        {
            return $"[TBaseStageEntity: Id={Id},StageState={StageState}, Ord={Ord}]";
        }
    }


}
