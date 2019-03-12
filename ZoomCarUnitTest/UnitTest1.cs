using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;


namespace ZoomCarUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        readonly Repository<ZoomCarUser> _repo;
        [TestMethod]
        public void CheckById()
        {
            _repo = new UserDbMgmt();
            ZoomCarUser zum = _repo.readById(1);
            Assert.AreEqual(vikasdubey, zum.Password);

        }
        [TestMethod]
        public void CheckByCompanyName()
        {


        }
        [TestMethod]
        public void CheckByOrderId()
        {


        }
    }
}
