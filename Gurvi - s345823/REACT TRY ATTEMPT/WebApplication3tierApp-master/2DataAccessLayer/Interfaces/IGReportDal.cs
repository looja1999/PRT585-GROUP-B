using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IGReportDal
    {
        // Getters
        GReportModel? GetById(int GReportId);
        List<GReportModel> GetAll();

        // Actions
        int CreateGReport(GReportModel GReport);
        void UpdateGReport(GReportModel GReport);
        void DeleteGReport(int GReportId);
    }
}
