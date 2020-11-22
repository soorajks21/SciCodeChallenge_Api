using LoginApplicationAPI.Store;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LoginPasstest()
        {
            UserStore userStore = new UserStore();
            var login = userStore.login("Sooraj", "Password");
            Assert.IsTrue(login);
        }

        [Test]
        public void LoginFailTest()
        {
            UserStore userStore = new UserStore();
            var login = userStore.login("Sooraj", "test");
            Assert.IsFalse(login);
        }
    }
}