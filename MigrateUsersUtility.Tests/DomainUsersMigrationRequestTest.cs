using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MigrateUsersUtility.Tests
{
    [TestClass]
    public class DomainUsersMigrationRequestTest
    {
        [TestMethod]
        public void CanCreateMigrationUsersRequest()
        {
            var migrateRequest = new DomainUsersMigrationRequest
            {
                SiteCollectionUrl = @"http://sitename",
                OldDomainName = @"OLD",
                NewDomainName = @"NEW",
                EnforceSidHistory = true
            };
            Assert.IsNotNull(migrateRequest);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SiteCollectionUrlCantBeEmpty()
        {
            var migrateRequest = new DomainUsersMigrationRequest
            {
                OldDomainName = @"OLD",
                NewDomainName = @"NEW",
                EnforceSidHistory = true
            };
            migrateRequest.Validate();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SiteCollectionUrlMustStartWithHttpOrHttps()
        {
            var migrateRequest = new DomainUsersMigrationRequest
            {
                SiteCollectionUrl = "siteName",
                OldDomainName = @"OLD",
                NewDomainName = @"NEW",
                EnforceSidHistory = true
            };
            migrateRequest.Validate();
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OldDomainNameCantBeEmpty()
        {
            var migrateRequest = new DomainUsersMigrationRequest
            {
                SiteCollectionUrl = "http://siteName",
                OldDomainName = @"",
                NewDomainName = @"NEW",
                EnforceSidHistory = true
            };
            migrateRequest.Validate();
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NewDomainNameCantBeEmpty()
        {
            var migrateRequest = new DomainUsersMigrationRequest
            {
                SiteCollectionUrl = "http://siteName",
                OldDomainName = @"Old",
                NewDomainName = @"",
                EnforceSidHistory = true
            };
            migrateRequest.Validate();
        }
    }
}
