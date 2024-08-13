using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.CivilReg
{
    public class CivilRegDto : EntityDto<int>
    {
        public string NameAr { get; set; }
        public string? NameEn { get; set; }

        public int CountryId { get; set; }

        public int CityId { get; set; }

    }

    public class CreateCivilRegDto
    {
        [Required]
        public string NameAr { get; set; }

        public string? NameEn { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public int CityId { get; set; }

    }

    public class UpdateCivilRegDto : CreateCivilRegDto
    {
        public int Id { get; set; }
    }


    public class CheckCivilRegDto : EntityDto<int>
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
    }


    public class CivilRegPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        public int? CountryId { get; set; }

        public int? CityId { get; set; }

    }

}
