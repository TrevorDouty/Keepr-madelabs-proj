using System;
using Xunit;
using Keepr.Tests;

namespace Keepr.Tests
{
    public class KeepTests
    {
        [Fact]
        public void FakeRepoGetIsWorking()
        {
            var _repo = new FakeDb();

            var keep = _repo.GetKeep(19);

            Assert.Equal(keep.Id, 19);
        }

        [Fact]
        public void CanUpdateKeep()
        {
            var _repo = new FakeDb();
            var keep = _repo.GetKeep(22);
            keep.Name = "bananas";
            throw new NotImplementedException("I SHOULD TEST THIS");
        }

        [Fact]
        public void KeepCannotBeCreatedWithNullName()
        {
            throw new NotImplementedException("I SHOULD TEST THIS");
        }
    }
}
