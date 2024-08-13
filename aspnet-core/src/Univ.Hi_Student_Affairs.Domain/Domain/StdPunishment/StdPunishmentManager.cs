using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Events;
using Univ.Hi_Student_Affairs.Domain.Student;
using Univ.Hi_Student_Affairs.Dtos.DomainPunishment;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.EventBus.Distributed;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Univ.Hi_Student_Affairs.Domain.StdPunishment
{


    public class StdPunishmentManager : DomainService
    {
        private readonly IRepository<StdPunishment, Guid> _stdPunishmentRepository;
        private readonly IRepository<StdPunishmentStage, Guid> _stdPunishmentStageRepository;
        private readonly IRepository<Punishment, int> _punishmentRepository;
        private readonly IRepository<PunishmentReason, int> _punishmentReasonRepository;
        private readonly IRepository<PunishmentStage, int> _punishmentStageRepository;
        private readonly IRepository<Deprivation, int> _deprivationRepository;
        private readonly IRepository<Semester, int> _semesterRepository;
        private readonly IRepository<Class, int> _classRepository;

        public StdPunishmentManager(
            IRepository<StdPunishment, Guid> stdPunishmentRepository,
            IRepository<StdPunishmentStage, Guid> stdPunishmentStageRepository,
            IRepository<Punishment, int> punishmentRepository,
            IRepository<PunishmentReason, int> punishmentReasonRepository,
            IRepository<PunishmentStage, int> punishmentStageRepository,
            IRepository<Deprivation, int> deprivationRepository,
            IRepository<Semester, int> semesterRepository,
            IRepository<Class, int> classRepository)
        {
            _stdPunishmentRepository = stdPunishmentRepository;
            _stdPunishmentStageRepository = stdPunishmentStageRepository;
            _punishmentRepository = punishmentRepository;
            _punishmentReasonRepository = punishmentReasonRepository;
            _punishmentStageRepository = punishmentStageRepository;
            _deprivationRepository = deprivationRepository;
            _semesterRepository = semesterRepository;
            _classRepository = classRepository;
        }


        private async Task ValidateStdPunishment(
            PunishmentState? punishmentState,
            int? punishmentId,
            Guid? studentId,
            int? punishmentReasonId,
            int? year,
            int? classId,
            int? semesterId,
            int? yearEnd,
            int? semesterEndId,
            string? note,
            bool? fixedStatus,
            bool? outside,
            bool? doublePunishment,
            Guid? id = null)
        {
            if (studentId == null || studentId == Guid.Empty)
            {
                throw new ArgumentException("Student ID is required.");
            }

            if (punishmentId == null || punishmentId <= 0)
            {
                throw new ArgumentException("Valid punishment ID is required.");
            }

            var punishmentExists = await _punishmentRepository.AnyAsync(p => p.Id == punishmentId);
            if (!punishmentExists)
            {
                throw new ArgumentException("Punishment ID does not exist.");
            }

            if (punishmentReasonId != null)
            {
                var punishmentReasonExists = await _punishmentReasonRepository.AnyAsync(pr => pr.Id == punishmentReasonId);
                if (!punishmentReasonExists)
                {
                    throw new ArgumentException("Punishment Reason ID does not exist.");
                }
            }

            if (semesterId != null)
            {
                var SemesterExists = await _semesterRepository.AnyAsync(pr => pr.Id == semesterId);
                if (!SemesterExists)
                {
                    throw new ArgumentException("Semester ID does not exist.");
                }
            }

            if (semesterEndId != null)
            {
                var SemesterEndExists = await _semesterRepository.AnyAsync(pr => pr.Id == semesterEndId);
                if (!SemesterEndExists)
                {
                    throw new ArgumentException("Semester End ID does not exist.");
                }
            }


            if (classId != null)
            {
                var ClassExists = await _classRepository.AnyAsync(pr => pr.Id == classId);
                if (!ClassExists)
                {
                    throw new ArgumentException("Class ID does not exist.");
                }
            }

            // Additional validations as necessary...
        }

        private async Task ValidateStdPunishmentStage(Guid stdPunishmentId,
            int punishmentStageId,
            int punishmentId,
            string? no,
            DateTime? date,
            string? note,
            Guid? id = null)
        {


            if (punishmentId <= 0)
            {
                throw new ArgumentException("Valid punishment ID is required.");
            }

            var punishmentExists = await _punishmentRepository.AnyAsync(p => p.Id == punishmentId);
            if (!punishmentExists)
            {
                throw new ArgumentException("Punishment ID does not exist.");
            }


            if (punishmentStageId <= 0)
            {
                throw new ArgumentException("Invalid punishment stage ID.");
            }

            var punishmentStageExists = await _punishmentStageRepository.AnyAsync(ps => ps.Id == punishmentStageId);
            if (!punishmentStageExists)
            {
                throw new ArgumentException("Punishment Stage ID does not exist.");
            }

            // Additional validations as necessary...
        }



        public async Task<StdPunishment> CreateAsync(
     PunishmentState? punishmentState,
     int? punishmentId,
     Guid? studentId,
     int? punishmentReasonId,
     int? year,
     int? classId,
     int? semesterId,
     int? yearEnd,
     int? semesterEndId,
     string? note,
     bool? fixedStatus,
     bool? outside,
     bool? doublePunishment,
     List<StdPunishmentStageDto>? stdPunishmentStageDtos = null)
        {
            // 1. Validate input
            await ValidateStdPunishment(punishmentState,
                punishmentId, studentId, punishmentReasonId,
                year, classId, semesterId, yearEnd, semesterEndId,
                note, fixedStatus, outside, doublePunishment);

            // 2. Create StdPunishment entity
            var stdPunishment = new StdPunishment(
                punishmentState, punishmentId, studentId,
                punishmentReasonId, year, classId, semesterId,
                yearEnd, semesterEndId, note, fixedStatus,
                outside, doublePunishment
            );

            // 3. Add stages if provided
            if (stdPunishmentStageDtos != null)
            {
                foreach (var stageDto in stdPunishmentStageDtos)
                {
                    await AddStdPunishmentStageAsync(stdPunishment,
                        stageDto.PunishmentStageId,
                        stageDto.PunishmentId,
                        stageDto.No,
                        stageDto.Date,
                        stageDto.Note);
                }
            }

            // 4. Persist the stdPunishment entity (ABP's UoW will ensure transactional consistency)
            await _stdPunishmentRepository.InsertAsync(stdPunishment);

            return stdPunishment;
        }


            public async Task<StdPunishment> UpdateAsync(
            Guid id, 
            PunishmentState? punishmentState,
            int? punishmentId,
            Guid? studentId,
            int? punishmentReasonId,
            int? year,
            int? classId,
            int? semesterId,
            int? yearEnd,
            int? semesterEndId,
            string? note,
            bool? fixedStatus,
            bool? outside,
            bool? doublePunishment,
            List<StdPunishmentStageDto>? stdPunishmentStageDtos = null)
        {
            //1 Validate
            await ValidateStdPunishment(punishmentState,
                punishmentId,
                studentId,
                punishmentReasonId,
                year,
                classId,
                semesterId,
                yearEnd,
                semesterEndId,
                note,
                fixedStatus,
                outside,
                doublePunishment);

            var stdPunishment = await _stdPunishmentRepository.GetAsync(id);



            stdPunishment.UpdatePunishment(punishmentState,
           punishmentId,
           studentId,
           punishmentReasonId,
           year,
           classId,
           semesterId,
           yearEnd,
           semesterEndId,
           note,
           fixedStatus,
           outside,
           doublePunishment);
            if (stdPunishmentStageDtos != null && stdPunishmentStageDtos.Count > 0)
            {
                stdPunishment.ClearPunishmentStage();
                foreach (var stdPunishmentStageDto in stdPunishmentStageDtos)
                    await AddStdPunishmentStageAsync(stdPunishment,
                stdPunishmentStageDto.PunishmentStageId,
                stdPunishmentStageDto.PunishmentId,
                stdPunishmentStageDto.No,
                stdPunishmentStageDto.Date,
                stdPunishmentStageDto.Note);
            }

            // 4. Save the stdPunishment entity 
            await _stdPunishmentRepository.UpdateAsync(stdPunishment);


            return stdPunishment;
        }


        public async Task DeleteAsync(Guid studentId,Guid stdPunshimentId)
        {
            var stdPunishment = await _stdPunishmentRepository.GetAsync(stdPunshimentId,true);
            // 4. Save the stdPunishment entity 
            await _stdPunishmentRepository.DeleteAsync(stdPunishment);

            return;

        }

        public async Task<StdPunishment> AddStdPunishmentStageAsync(
            Guid stdPunishmentId,
            int punishmentStageId,
            int punishmentId,
            string? no,
            DateTime? date,
            string? note)
        {
            await ValidateStdPunishmentStage(stdPunishmentId, punishmentStageId, punishmentId, no, date, note);


            var stdPunishment = await _stdPunishmentRepository.GetAsync(stdPunishmentId);

            stdPunishment.AddPunishmentStage(punishmentStageId, stdPunishmentId, punishmentId, no, date, note);

            await _stdPunishmentRepository.UpdateAsync(stdPunishment);
            return stdPunishment;
        }


        public async Task<StdPunishment> AddStdPunishmentStageAsync(
            StdPunishment @StdPunishment,
            int punishmentStageId,
            int punishmentId,
            string? no,
            DateTime? date,
            string? note)
        {
            await ValidateStdPunishmentStage(@StdPunishment.Id, punishmentStageId, punishmentId, no, date, note);
            @StdPunishment.AddPunishmentStage(punishmentStageId, @StdPunishment.Id, punishmentId, no, date, note);
            return @StdPunishment;
        }


        public async Task<StdPunishment> UpdateStdPunishmentStageAsync(
            StdPunishment @StdPunishment,
            Guid stdPunishmentStageId,
            int punishmentStageId,
            int punishmentId,
            string? no,
            DateTime? date,
            string? note)
        {
            await ValidateStdPunishmentStage(@StdPunishment.Id, punishmentStageId, punishmentId, no, date, note);

            @StdPunishment.UpdatePunishmentStage(stdPunishmentStageId, punishmentStageId, @StdPunishment.Id, punishmentId, no, date, note);
            return @StdPunishment;
        }

        public async Task<StdPunishment> UpdateStdPunishmentStageAsync(
            Guid stdPunishmentId,
          Guid stdPunishmentStageId,
          int punishmentStageId,
          int punishmentId,
          string? no,
          DateTime? date,
          string? note)
        {
            await ValidateStdPunishmentStage(stdPunishmentId, punishmentStageId, punishmentId, no, date, note);
            var @StdPunishment = await _stdPunishmentRepository.GetAsync(stdPunishmentId);
            @StdPunishment.UpdatePunishmentStage(stdPunishmentStageId, punishmentStageId, @StdPunishment.Id, punishmentId, no, date, note);
            return @StdPunishment;
        }


        public async Task<StdPunishment> RemovePunishmentStageAsync(
              StdPunishment @StdPunishment, Guid stdPunishmentStageId)
        {
            @StdPunishment.RemovePunishmentStage(stdPunishmentStageId);




            return @StdPunishment;
        }

        public async Task<StdPunishment> RemovePunishmentStageAsync(
               Guid stdPunishmentId, Guid stdPunishmentStageId)
        {
            var @StdPunishment = await _stdPunishmentRepository.GetAsync(stdPunishmentId);
            @StdPunishment.RemovePunishmentStage(stdPunishmentStageId);




            return @StdPunishment;
        }


      


    }

}
