using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IGReportService
    {
        Task<GReportModel?> GetById(int GReportId);
        Task<List<GReportModel>> GetAll();

        Task<int> CreateGReport(GReportModel GReport);
        Task UpdateGReport(GReportModel GReport);
        Task DeleteGReport(int GReportId);
    }
}
