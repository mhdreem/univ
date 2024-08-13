using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;


namespace Univ.Hi_Student_Affairs.Domain.StdPunishment
{
    public class StdAbolition : Entity<int>
    {
        //رقم قرار لجنة التظلم
        public int No { get; private set; }
        //تاريخه
        public DateTime Date { get; private set; }

        public string? Result { get; private set; }


        [ForeignKey("PunishmentId")]
        public int? PunishmentId { get; private set; }



        StdAbolition(int id, int no, DateTime date, string? result, int? punishmentId)
        {
            if (no <= 0)
            {
                throw new ArgumentException("Invalid no ", nameof(no));
            }

            if (date == null)
            {
                throw new ArgumentException("Invalid date ", nameof(date));
            }


            SetNo(no);
            SetDate(date);
            SetPunishmentId(punishmentId);
            SetResult(result);
            Id = id;

        }

        StdAbolition(int no, DateTime date, string? result, int? punishmentId)
        {
            if (no <= 0)
            {
                throw new ArgumentException("Invalid no ", nameof(no));
            }

            if (date == null)
            {
                throw new ArgumentException("Invalid date ", nameof(date));
            }


            SetNo(no);
            SetDate(date);
            SetPunishmentId(punishmentId);
            SetResult(result);
        }


        public void SetNo(int no)
        {
            if (no < 0)
            {
                throw new ArgumentException("no cannot be negative", nameof(no));
            }

            No = no;
        }

        public void SetDate(DateTime date)
        {
            if (Date == null)
            {
                throw new ArgumentException("Date cannot be null", nameof(Date));
            }

            Date = date;
        }

        public void SetResult(string? result)
        {
            if (string.IsNullOrEmpty(result))
            {
                throw new ArgumentException("result cannot be null", nameof(Date));
            }

            Result = result;
        }




        public void SetPunishmentId(int? punishmentId)
        {


            PunishmentId = PunishmentId;
        }






        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (StdAbolition)obj;
            return EqualityComparer<int>.Default.Equals(Id, other.Id) &&
                   No == other.No &&
                   Date == other.Date &&
                   Result == other.Result &&
                   PunishmentId == other.PunishmentId;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, No, Date, Result, PunishmentId);
        }

        public override string ToString()
        {
            return $"[Deprivation: Id={Id},No={No},Date={Date},Result={Result},PunishmentId={PunishmentId}]";
        }
    }


}
