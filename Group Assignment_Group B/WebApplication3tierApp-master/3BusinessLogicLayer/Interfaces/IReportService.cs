using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IReportService
    {
        Task<ReportModel?> GetById(int ReportId);
        Task<List<ReportModel>> GetAll();

        Task<int> CreateReport(ReportModel Report);
        Task UpdateReport(ReportModel Report);
        Task DeleteReport(int ReportId);
    }
}
