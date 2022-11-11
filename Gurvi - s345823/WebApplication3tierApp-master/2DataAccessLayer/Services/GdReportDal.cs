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
    public class GdReportDal : IGdReportDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public GdReportDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<GdReportModel> GetAll()
        {
            var result = _db.GdReports.ToList();

            var returnObject = new List<GdReportModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToGdReportModel());
            }

            return returnObject;
        }

        public GdReportModel? GetById(int GdReportId)
        {
            var result = _db.GdReports.SingleOrDefault(x => x.GdReportId == GdReportId);
            return result?.ToGdReportModel();
        }


        public int CreateGdReport(GdReportModel GdReport)
        {
            var newGdReport = GdReport.ToGdReport();
            _db.GdReports.Add(newGdReport);
            _db.SaveChanges();
            return newGdReport.GdReportId;
        }


        public void UpdateGdReport(GdReportModel GdReport)
        {
            var existingGdReport = _db.GdReports
                .SingleOrDefault(x => x.GdReportId == GdReport.GdReportId);

            if (existingGdReport == null)
            {
                throw new ApplicationException($"GdReport {GdReport.GdReportId} does not exist.");
            }
            GdReport.ToGdReport(existingGdReport);

            _db.Update(existingGdReport);
            _db.SaveChanges();
        }

        public void DeleteGdReport(int GdReportId)
        {
            var efModel = _db.GdReports.Find(GdReportId);
            _db.GdReports.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
