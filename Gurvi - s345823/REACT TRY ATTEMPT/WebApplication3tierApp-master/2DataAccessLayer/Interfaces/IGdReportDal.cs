using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IGdReportDal
    {
        // Getters
        GdReportModel? GetById(int GdReportId);
        List<GdReportModel> GetAll();

        // Actions
        int CreateGdReport(GdReportModel GdReport);
        void UpdateGdReport(GdReportModel GdReport);
        void DeleteGdReport(int GdReportId);
    }
}
