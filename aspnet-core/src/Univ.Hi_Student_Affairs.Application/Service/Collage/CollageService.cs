using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Volo.Abp.Application.Dtos;
using Univ.Hi_Student_Affairs.Base;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service
{
    public class CollageService :GenericAppService<Collage, CollageDto, int, PagedResultRequestDto, CreateCollageDto, UpdateCollageDto>
    {
        public CollageService(IRepository<Collage, int> repository, IMapper mapper)
            : base(repository)
        {
            // You can use the injected repository and mapper here
        }


    }
}