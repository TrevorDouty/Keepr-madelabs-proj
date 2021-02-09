using System.Linq;
using Keepr.Web.Interfaces;
using Keepr.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Keepr.Web.Data
{
    public class KeepRepo : IKeepRepo
    {
        private readonly KeeprContext _db;



        public KeepRepo(KeeprContext db)
        {
            _db = db;
        }

        public Keep GetKeep(int id)
        {
            var keep = _db.Keeps.Where(k => k.Id == id).FirstOrDefault();
            return keep;
        }
    }
}