using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp;
using Univ.Hi_Student_Affairs.Domain.Nationality.Exception;

namespace Univ.Hi_Student_Affairs
{
    public class StudentManager : DomainService
    {

        private readonly IRepository<Student, Guid> _Repository;


        public StudentManager(IRepository<Student, Guid> Repository)
        {
            _Repository = Repository;

        }


        public async Task<Student> CreateAsync(
            Student input
       
         )
        {
          

          


            return input;
        }

        public async Task<Student> UpdateAsync(
            [NotNull] Guid id,
            [NotNull] Student input
            )
        {
            //Check.NotNullOrWhiteSpace(input.NameAr, nameof(input.NameAr));
            //Check.NotNullOrWhiteSpace(input.NameEn, nameof(input.NameEn));


            var Old = await _Repository.FindAsync(x => x.Id == id);
            if (Old == null)
            {
                throw new NationalityNotExistsException();
            }

           




            return Old;
        }

    }
}