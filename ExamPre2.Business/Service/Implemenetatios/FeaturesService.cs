using ExamPre2.Business.CustomExceptions;
using ExamPre2.Business.Service.Interfaces;
using ExamPre2.Core.Models;
using ExamPre2.Core.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPre2.Business.Service.Implemenetatios
{
    
    public class FeaturesService : IFeaturesService
    {
        private readonly IFeaturesRepository _featuresRepository;

        public FeaturesService(IFeaturesRepository featuresRepository)
        {
            _featuresRepository = featuresRepository;
        }
        public async Task CreateAsync(Features features)
        {
            if (features is null) throw new FeaturesNullException("","features is null");
            await _featuresRepository.CreateAsync(features);
            await _featuresRepository.CommitAsync();    
        }

        public async Task DeleteAsync(int id)
        {
            var features = await _featuresRepository.GetByIdAsync(x=>x.Id==id);
            if (features is null)  throw new FeaturesNullException("", "features is null");
            _featuresRepository.Delete(features);

        }

        public async Task<List<Features>> GetAllAsync()
        {
             return await _featuresRepository.GetAllAsync();
        }

        public async Task<Features> GetByIdAsync(int id)
        {
            return await _featuresRepository.GetByIdAsync(x=>x.Id == id);
        }

        public async Task UpdateAsync(Features features)
        {
            var ftu = await _featuresRepository.GetByIdAsync(x=>x.Id == features.Id);
            if (ftu is null) throw new FeaturesNullException("", "features is null");


            ftu.Name = features.Name;
            ftu.Description = features.Description;
            ftu.IconUrl = features.IconUrl;

            await _featuresRepository.CommitAsync();
        }
    }
}
