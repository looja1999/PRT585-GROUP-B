using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IMajorDal
    {
        // Getters
        MajorModel? GetById(int MajorId);
        List<MajorModel> GetAll();

        // Actions
        int CreateMajor(MajorModel Major);
        void UpdateMajor(MajorModel Major);
        void DeleteMajor(int MajorId);
    }
}
