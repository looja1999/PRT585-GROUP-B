

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class MajorService : IMajorService
    {
        private readonly IMajorDal _MajorDal;
        //private readonly IMajorBalService _MajorBalService;
        public MajorService(IMajorDal MajorDal
        //ILoggingService loggingService,
        //IMajorDal MajorDal,
        //IAuditDal auditDal
        // IMajorBalanceService balsvc
        )
        {
            _MajorDal = MajorDal;
            // _MajorBalService = balsvc;
        }

        public async Task<MajorModel?> GetById(int MajorId)
        {
            return _MajorDal.GetById(MajorId);
        }

        public async Task<List<MajorModel>> GetAll()
        {
            return _MajorDal.GetAll();
        }

        public async Task<int> CreateMajor(MajorModel Major)
        {
            //write validations here
            var newMajorId = _MajorDal.CreateMajor(Major);
            return newMajorId;
        }

        public async Task UpdateMajor(MajorModel Major)
        {
            //write validations here 
            _MajorDal.UpdateMajor(Major);
        }

        public async Task DeleteMajor(int MajorId)
        {
            try
            {
                //if(balservice.getBal(MajorId) = 0)
                _MajorDal.DeleteMajor(MajorId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Major Id:{MajorId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
