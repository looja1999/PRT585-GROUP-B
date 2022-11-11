using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IGdReportService
    {
        Task<GdReportModel?> GetById(int GdReportId);
        Task<List<GdReportModel>> GetAll();

        Task<int> CreateGdReport(GdReportModel GdReport);
        Task UpdateGdReport(GdReportModel GdReport);
        Task DeleteGdReport(int GdReportId);
    }
}
