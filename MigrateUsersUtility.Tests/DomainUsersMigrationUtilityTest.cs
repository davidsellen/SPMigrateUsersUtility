using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MigrateUsersUtility.Tests
{
    /// <summary>
    /// Summary description for DomainUsersMigrationUtilityTest
    /// </summary>
    [TestClass]
    public class DomainUsersMigrationUtilityTest
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CantStartMigrationUtilityWithEmptyRequest()
        {
            var migrationTool = new DomainUsersMigrationUtility(new DomainUsersMigrationRequest());
            migrationTool.Start();
        }

        [TestMethod]
        public void CanStartMigrationUtility()
        {
            var migrationTool = new DomainUsersMigrationUtility(new DomainUsersMigrationRequest
            {
                SiteCollectionUrl = "http://siteName",
                NewDomainName = "NEWDOMAIN",
                OldDomainName = "OLDDOMAIN",
                EnforceSidHistory = true
            });
            migrationTool.Start();
        }
        
    }
}
