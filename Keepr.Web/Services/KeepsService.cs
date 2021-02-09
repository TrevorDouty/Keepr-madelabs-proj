using Keepr.Web.Interfaces;
using Keepr.Web.Models;

namespace Keepr.Web.Services
{
    public class KeepsService
    {
        public IKeepRepo _repo { get; }

        public Keep GetKeep(int id)
        {
            // business logic
            var keep = _repo.GetKeep(id);
            if (keep == null)
            {
                throw new System.Exception("Bad Id");
            }
            return keep;
        }

        public KeepsService(IKeepRepo keepsRepo)
        {
            _repo = keepsRepo;
        }

    }
}