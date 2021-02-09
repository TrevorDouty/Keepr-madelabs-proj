using Keepr.Web.Models;

namespace Keepr.Web.Interfaces
{
    public interface IKeepRepo
    {
        Keep GetKeep(int id);
        // Keep SaveKeep(int id);
        // Keep CreateKeep(int id);
    }
}