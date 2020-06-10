using Microsoft.VisualStudio.TestTools.UnitTesting;

using BackendApp.Models;
using BackendApp.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/**
 * The Unit Test Class
 */

namespace BackendUnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        // Test controller to return correct values
        public async Task TestFirstElement()
        {
            var controller = new HomeController(null);
            var result = await controller.Get();
            Assert.IsTrue(result is IEnumerable<Course>);
            result.FirstOrDefault(c => { 
                Assert.AreEqual("Strategic Management Accounting", c.subject);
                return true; 
            });
        }

        [TestMethod]
        // Test controller to return correct values
        public async Task TestCertainElement()
        {
            var controller = new HomeController(null);
            var result = await controller.Get();
            Assert.IsTrue(result is IEnumerable<Course>);

            result.Where(c => c.subject.Equals("Advanced Audit and Assurance")).
                FirstOrDefault(c => {
                    Assert.AreEqual(c.results[0].year, 2015);
                    Assert.AreEqual(c.results[0].grade, Result.PASS);
                    return true;
                });
        }
    }
}
