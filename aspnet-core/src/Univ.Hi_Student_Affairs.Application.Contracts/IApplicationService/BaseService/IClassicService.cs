using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.IApplicationService.BaseService
{
    public  interface IClassicService<TEntityDto,TPrimaryKey,TPageDto,TCreateDto, TUpdateDto> : ICrudAppService<TEntityDto, TPrimaryKey, TPageDto, TCreateDto,TUpdateDto>
    {

        public Task<RespondDto> FilterDataAsync(TPageDto input);

        public Task<RespondDto> PostDataAsync(TEntityDto input);
        
        public Task<RespondDto> ModifyDataAsync(TPrimaryKey id, TEntityDto input);

        public Task<RespondDto> RemoveDataAsync(TPrimaryKey id);
      
    }
}
