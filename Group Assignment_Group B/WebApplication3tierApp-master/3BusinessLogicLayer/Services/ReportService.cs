

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportDal _ReportDal;
        //private readonly IReportBalService _ReportBalService;
        public ReportService(IReportDal ReportDal
        //ILoggingService loggingService,
        //IReportDal ReportDal,
        //IAuditDal auditDal
        // IReportBalanceService balsvc
        )
        {
            _ReportDal = ReportDal;
            // _ReportBalService = balsvc;
        }

        public async Task<ReportModel?> GetById(int ReportId)
        {
            return _ReportDal.GetById(ReportId);
        }

        public async Task<List<ReportModel>> GetAll()
        {
            return _ReportDal.GetAll();
        }

        public async Task<int> CreateReport(ReportModel Report)
        {
            //write validations here
            var newReportId = _ReportDal.CreateReport(Report);
            return newReportId;
        }

        public async Task UpdateReport(ReportModel Report)
        {
            //write validations here 
            _ReportDal.UpdateReport(Report);
        }

        public async Task DeleteReport(int ReportId)
        {
            try
            {
                //if(balservice.getBal(ReportId) = 0)
                _ReportDal.DeleteReport(ReportId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Report Id:{ReportId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
