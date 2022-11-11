using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class ReportDal : IReportDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public ReportDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<ReportModel> GetAll()
        {
            var result = _db.Reports.ToList();

            var returnObject = new List<ReportModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToReportModel());
            }

            return returnObject;
        }

        public ReportModel? GetById(int ReportId)
        {
            var result = _db.Reports.SingleOrDefault(x => x.ReportId == ReportId);
            return result?.ToReportModel();
        }


        public int CreateReport(ReportModel Report)
        {
            var newReport = Report.ToReport();
            _db.Reports.Add(newReport);
            _db.SaveChanges();
            return newReport.ReportId;
        }


        public void UpdateReport(ReportModel Report)
        {
            var existingReport = _db.Reports
                .SingleOrDefault(x => x.ReportId == Report.ReportId);

            if (existingReport == null)
            {
                throw new ApplicationException($"Report {Report.ReportId} does not exist.");
            }
            Report.ToReport(existingReport);

            _db.Update(existingReport);
            _db.SaveChanges();
        }

        public void DeleteReport(int ReportId)
        {
            var efModel = _db.Reports.Find(ReportId);
            _db.Reports.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
