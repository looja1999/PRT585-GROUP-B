using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IReportDal
    {
        // Getters
        ReportModel? GetById(int ReportId);
        List<ReportModel> GetAll();

        // Actions
        int CreateReport(ReportModel Report);
        void UpdateReport(ReportModel Report);
        void DeleteReport(int ReportId);
    }
}
