using ExamPre2.Core.Models;
using ExamPre2.Core.Repository.Interfaces;
using ExamPre2.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPre2.Data.Repository.Implementations
{
    public class FeaturesRepository : GenericRepository<Features>, IFeaturesRepository
    {
        public FeaturesRepository(AppDbContext appDb) : base(appDb)
        {
        }
    }
}
