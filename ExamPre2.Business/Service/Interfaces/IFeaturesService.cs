using ExamPre2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPre2.Business.Service.Interfaces
{
    public interface IFeaturesService 
    {
        Task CreateAsync(Features features);
        Task DeleteAsync(int id);

        Task UpdateAsync(Features features);
        Task<Features> GetByIdAsync(int id);
        Task<List<Features>> GetAllAsync();
    }
}
