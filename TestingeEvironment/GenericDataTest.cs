using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using UniversityAppData.DbContext;

namespace TestingeEvironment
{
    [TestClass]
    public class GenericDataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            UnitOfWork UOW = new UnitOfWork();
            //GenericDataBaseClass<Courses> Model = new GenericDataBaseClass<Courses>(Context);
            //Act

            //IEnumerable List = UOW.GenericDataHandler.GetAllRecords();
            IEnumerable List = UOW.TermRep.GetAllRecords();

            //Assert
            int i = 0;
            foreach (var item in List)
            {
                i++;
            }
            Assert.IsNull(List, "Count: " + i.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            UnitOfWork work = new UnitOfWork();

            //IEnumerable List  = work.Term.GetAllRecords();
            //string Typemsg = work.Term.GetType().ToString();

            //IEnumerable List2 = work.Group.GetAllRecords();
            //string Typemsg2 = work.Group.GetType().ToString();

            Assert.Fail();
        }
    }
}