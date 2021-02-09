using Keepr.Web.Interfaces;
using Keepr.Web.Models;

namespace Keepr.Tests
{
    public class FakeDb : IKeepRepo
    {
        public Keep GetKeep(int id)
        {
            return new Keep()
            {
                Id = id,
                Name = "Test Keep",
                Views = 14
            };
        }


    }
}