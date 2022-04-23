using ClasesPA.Data;
using ClasesPA.Models;
using ClasesPA.Services;
using Microsoft.EntityFrameworkCore;

namespace ClasesPA.Repository
{
    public class EnrrollementsRepository : IEnrrollements
    {
        private ApplicationDBContext _Db;
        public EnrrollementsRepository(ApplicationDBContext db) {
            _Db = db;
        }

        public IEnumerable<Enrrollements> GetInnerJoin()
        {
            var Join = _Db.Enrrollements.Include(e => e.Student).Include(c => c.Course).ToList();

            return Join;
        }


        //public IEnumerable<IEnrrollements> GetInnerJoin()
        //{
        //    var Join = _DB.Enrrollements.Include(e => e.Students).Include(c => c.Course).ToList();

        //    return Join;
        //}
    }
}
