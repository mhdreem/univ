using System;
using System.Linq;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.StdPunishment;
using Univ.Hi_Student_Affairs.Dtos.DomainPunishment;
using Univ.Hi_Student_Affairs.Dtos.Respond;
using Univ.Hi_Student_Affairs.Service.BaseService;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Univ.Hi_Student_Affairs.Service.DomainPunishment
{

    public class StdPunishmentAppService : CustomCrudAppService<StdPunishment, StdPunishmentDto, Guid, CreateStdPunishmentDto, UpdateStdPunishmentDto>, IStdPunishmentAppService
    {
        private readonly StdPunishmentManager manager;


        public StdPunishmentAppService(
            IRepository<StdPunishment, Guid> repository,
            StdPunishmentManager _Manager
            ) : base(repository)
        {
            manager = _Manager;

        }

       


        public override async Task<RespondDto> CreateCustomAsync(CreateStdPunishmentDto input)
        {
            try
            {

                var stdPunishment = await manager.CreateAsync(
              input.PunishmentState,
              input.PunishmentId,
              input.StudentId,
              input.PunishmentReasonId,
              input.Year,
              input.ClassId,
              input.SemesterId,
              input.YearEnd,
              input.SemesterEndId,
              input.Note,
              input.Fixed,
              input.Outside,
              input.DoublePunishment
          );

                if (input.StdPunishmentStages != null && input.StdPunishmentStages.Count() > 0)
                {

                    foreach (var StdPunishmentStage in input.StdPunishmentStages)
                    {

                        manager.AddStdPunishmentStageAsync(
                            stdPunishment,
                            StdPunishmentStage.PunishmentStageId,
                            StdPunishmentStage.PunishmentId,
                            StdPunishmentStage.No,
                            StdPunishmentStage.Date,
                            StdPunishmentStage.Note);

                    }


                }

                Repository.InsertAsync(stdPunishment);


                return new RespondDto
                {
                    IsSuccess = true,
                    Result = stdPunishment,
                    Total_Result_Count = 1
                };

            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }


        }

        public async Task<RespondDto> UpdateCustomAsync(UpdateStdPunishmentDto input)
        {
            try
            {

                var stdPunishment = await manager.UpdateAsync(
               input.Id,
               input.PunishmentId,
               input.PunishmentState,
               input.StudentId,
               input.PunishmentReasonId,
               input.Year,
               input.ClassId,
               input.SemesterId,
               input.YearEnd,
               input.SemesterEndId,
               input.Note,
               input.Fixed,
               input.Outside,
               input.DoublePunishment
           );

                if (input.StdPunishmentStages != null && input.StdPunishmentStages.Count() > 0)
                {
                    stdPunishment.ClearPunishmentStage();

                    foreach (var StdPunishmentStage in input.StdPunishmentStages)
                    {

                        manager.AddStdPunishmentStageAsync(
      stdPunishment,
      StdPunishmentStage.PunishmentStageId,
      StdPunishmentStage.PunishmentId,
      StdPunishmentStage.No,
      StdPunishmentStage.Date,
      StdPunishmentStage.Note);

                    }


                }



                Repository.UpdateAsync(stdPunishment);


                return new RespondDto
                {
                    IsSuccess = true,
                    Result = stdPunishment,
                    Total_Result_Count = 1
                };

            }
            catch (Exception ex)
            {
                return new RespondDto
                {
                    IsSuccess = false,
                    Error = ex.Message
                };
            }


        }



        public async Task<RespondDto> AddStdPunishmentStageAsync(StdPunishmentStageDto input)
        {


            var stdPunishment = await manager.AddStdPunishmentStageAsync(
                input.StdPunishmentId.Value,
                input.PunishmentStageId,
                input.PunishmentId,
                input.No,
                input.Date,
                input.Note
            );

            return new RespondDto
            {
                IsSuccess = true,
                Result = stdPunishment,
                Total_Result_Count = 1
            };
        }

        public async Task<RespondDto> UpdateStdPunishmentStageAsync(UpdateStdPunishmentStageDto input)
        {
            var stdPunishment = await manager.UpdateStdPunishmentStageAsync(
                input.StdPunishmentId.Value, input.Id,
                input.PunishmentStageId,
                input.PunishmentId,
                input.No,
                input.Date,
                input.Note
            );

            return new RespondDto
            {
                IsSuccess = true,
                Result = stdPunishment,
                Total_Result_Count = 1
            };
        }

      
        public async Task<RespondDto> GetPunishmentStageAsync(Guid stdPunishmentId, Guid stdPunishmentStageId)
        {
            if (stdPunishmentId == Guid.Empty || stdPunishmentStageId == Guid.Empty)
            {
                throw new ArgumentException("Invalid punishment stage ID or standard punishment ID.");
            }
            var stdPunishment = await Repository.GetAsync(stdPunishmentId);


            var stdPunishmentStage = stdPunishment.GetPunishmentStage(stdPunishmentStageId);

            return new RespondDto
            {
                IsSuccess = true,
                Result = ObjectMapper.Map<StdPunishmentStage, StdPunishmentStageDto>(stdPunishmentStage),
                Total_Result_Count = 1
            };

        }

        public async Task<RespondDto> RemovePunishmentStageAsync(Guid stdPunishmentId, Guid stdPunishmentStageId)
        {
            if (stdPunishmentId == Guid.Empty || stdPunishmentId == Guid.Empty)
            {
                throw new ArgumentException("Invalid punishment stage ID or standard punishment ID.");
            }
            var stdPunishment = await Repository.GetAsync(stdPunishmentId);


            var stdPunishmentStage = stdPunishment.GetPunishmentStage(stdPunishmentStageId);

            return new RespondDto
            {
                IsSuccess = true,
                Result = ObjectMapper.Map<StdPunishment, StdPunishmentDto>(stdPunishment),
                Total_Result_Count = 1
            };

        }



    }

}


