using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IMajorService
    {
        Task<MajorModel?> GetById(int MajorId);
        Task<List<MajorModel>> GetAll();

        Task<int> CreateMajor(MajorModel Major);
        Task UpdateMajor(MajorModel Major);
        Task DeleteMajor(int MajorId);
    }
}
