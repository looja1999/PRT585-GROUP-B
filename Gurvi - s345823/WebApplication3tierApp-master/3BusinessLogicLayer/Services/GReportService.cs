

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class GReportService : IGReportService
    {
        private readonly IGReportDal _GReportDal;
        //private readonly IGReportDalService _GReportDalService;
        public GReportService(IGReportDal GReportDal
        //ILoggingService loggingService,
        //IGReportDal GReportDal,
        //IAuditDal auditDal
        // IGReportBalanceService balsvc
        )
        {
            _GReportDal = GReportDal;
            // _GReportDalService = balsvc;
        }

        public async Task<GReportModel?> GetById(int GReportId)
        {
            return _GReportDal.GetById(GReportId);
        }

        public async Task<List<GReportModel>> GetAll()
        {
            return _GReportDal.GetAll();
        }

        public async Task<int> CreateGReport(GReportModel GReport)
        {
            //write validations here
            var newGReportId = _GReportDal.CreateGReport(GReport);
            return newGReportId;
        }

        public async Task UpdateGReport(GReportModel GReport)
        {
            //write validations here 
            _GReportDal.UpdateGReport(GReport);
        }

        public async Task DeleteGReport(int GReportId)
        {
            try
            {
                //if(balservice.getDal(GReportId) = 0)
                _GReportDal.DeleteGReport(GReportId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete GReport Id:{GReportId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
