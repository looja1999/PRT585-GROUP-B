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
    public class GReportDal : IGReportDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public GReportDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<GReportModel> GetAll()
        {
            var result = _db.GReports.ToList();

            var returnObject = new List<GReportModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToGReportModel());
            }

            return returnObject;
        }

        public GReportModel? GetById(int GReportId)
        {
            var result = _db.GReports.SingleOrDefault(x => x.GReportId == GReportId);
            return result?.ToGReportModel();
        }


        public int CreateGReport(GReportModel GReport)
        {
            var newGReport = GReport.ToGReport();
            _db.GReports.Add(newGReport);
            _db.SaveChanges();
            return newGReport.GReportId;
        }


        public void UpdateGReport(GReportModel GReport)
        {
            var existingGReport = _db.GReports
                .SingleOrDefault(x => x.GReportId == GReport.GReportId);

            if (existingGReport == null)
            {
                throw new ApplicationException($"GReport {GReport.GReportId} does not exist.");
            }
            GReport.ToGReport(existingGReport);

            _db.Update(existingGReport);
            _db.SaveChanges();
        }

        public void DeleteGReport(int GReportId)
        {
            var efModel = _db.GReports.Find(GReportId);
            _db.GReports.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
