using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace Univ.Hi_Student_Affairs.Domain.TypeLic
{
    public class TypeLicManager : DomainService
    {
        private readonly IRepository<TypeLic, int> _TypeLicRepository;
        private readonly IRepository<TypeLicBranch, int> _TypeLicBranchRepository;

        public TypeLicManager(
            IRepository<TypeLic, int> typeLicRepository,
            IRepository<TypeLicBranch, int> typeLicBranchRepository)
        {
            _TypeLicRepository = typeLicRepository;
            _TypeLicBranchRepository = typeLicBranchRepository;
        }

        public async Task<TypeLic> CreateTypeLicAsync(
            string nameAr, string? nameEn, int? ord, string? barcode, ICollection<TypeLicBranch>? typeLicBranches)
        {
            var typeLic = new TypeLic(nameAr, nameEn, ord, barcode, typeLicBranches);
            await _TypeLicRepository.InsertAsync(typeLic);
            return typeLic;
        }

        public async Task<TypeLic> UpdateTypeLicAsync(
            int id, string nameAr, string? nameEn, int? ord, string? barcode)
        {
            var typeLic = await _TypeLicRepository.GetAsync(id);

            typeLic.SetNameAr(nameAr);
            typeLic.SetNameEn(nameEn);
            typeLic.UpdateBarcode(barcode);
            typeLic.SetOrd(ord);

            await _TypeLicRepository.UpdateAsync(typeLic);
            return typeLic;
        }

        public async Task<TypeLicBranch> AddTypeLicBranchAsync(
            int typeLicId, string nameAr, string? nameEn, int? ord, string? barcode)
        {
            var typeLic = await _TypeLicRepository.GetAsync(typeLicId);
            typeLic.AddTypeLicBranch(nameAr, nameEn, ord, barcode);

            await _TypeLicRepository.UpdateAsync(typeLic);
            return typeLic.TypeLicBranchs.FirstOrDefault(x => x.NameAr == nameAr && x.NameEn == nameEn);
        }

        public async Task<TypeLic> UpdateTypeLicBranchAsync(
            int typeLicId, int typeLicBranchId, string nameAr, string nameEn, int? ord, string? barcode)
        {
            var typeLic = await _TypeLicRepository.GetAsync(typeLicId);
            typeLic.UpdateTypeLicBranch(typeLicBranchId, nameAr, nameEn, ord, barcode);

            await _TypeLicRepository.UpdateAsync(typeLic);
            return typeLic;
        }

        public async Task RemoveTypeLicBranchAsync(int typeLicId, int typeLicBranchId)
        {
            var typeLic = await _TypeLicRepository.GetAsync(typeLicId);
            typeLic.RemoveTypeLicBranch(typeLicBranchId);

            await _TypeLicRepository.UpdateAsync(typeLic);
        }

        public async Task<TypeLicBranch> GetTypeLicBranchAsync(int typeLicId, int typeLicBranchId)
        {
            var typeLic = await _TypeLicRepository.GetAsync(typeLicId);
            return typeLic.GetTypeLicBranch(typeLicBranchId);
        }
    }

}
