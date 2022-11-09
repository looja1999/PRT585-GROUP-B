

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class GdReportService : IGdReportService
    {
        private readonly IGdReportDal _GdReportDal;
        //private readonly IGdReportDalService _GdReportDalService;
        public GdReportService(IGdReportDal GdReportDal
        //ILoggingService loggingService,
        //IGdReportDal GdReportDal,
        //IAuditDal auditDal
        // IGdReportBalanceService balsvc
        )
        {
            _GdReportDal = GdReportDal;
            // _GdReportDalService = balsvc;
        }

        public async Task<GdReportModel?> GetById(int GdReportId)
        {
            return _GdReportDal.GetById(GdReportId);
        }

        public async Task<List<GdReportModel>> GetAll()
        {
            return _GdReportDal.GetAll();
        }

        public async Task<int> CreateGdReport(GdReportModel GdReport)
        {
            //write validations here
            var newGdReportId = _GdReportDal.CreateGdReport(GdReport);
            return newGdReportId;
        }

        public async Task UpdateGdReport(GdReportModel GdReport)
        {
            //write validations here 
            _GdReportDal.UpdateGdReport(GdReport);
        }

        public async Task DeleteGdReport(int GdReportId)
        {
            try
            {
                //if(balservice.getDal(GdReportId) = 0)
                _GdReportDal.DeleteGdReport(GdReportId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete GdReport Id:{GdReportId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
