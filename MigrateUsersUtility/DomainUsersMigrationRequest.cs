using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MigrateUsersUtility
{
    public class DomainUsersMigrationRequest
    {
        public string SiteCollectionUrl { get; set; }

        public string OldDomainName { get; set; }

        public string NewDomainName { get; set; }

        public bool EnforceSidHistory { get; set; }

        public void Validate()
        {
            if (!IsSiteCollectionValid)
                throw new ArgumentException("Site Url must start with http:// or https://");
            if (!IsOldDomainNameValid)
                throw new ArgumentException("Old Domain Name can not be empty");
            if (!IsNewDomainNameValid)
                throw new ArgumentException("Old Domain Name can not be empty");
        }

        private bool IsSiteCollectionValid
        {
            get
            {
                return IsAStringInputValid(SiteCollectionUrl) && IsAUrlValid(SiteCollectionUrl);
            }
        }

        private bool IsOldDomainNameValid
        {
            get
            {
                return IsAStringInputValid(OldDomainName);
            }

        }

        private bool IsNewDomainNameValid
        {
            get
            {
                return IsAStringInputValid(NewDomainName);
            }

        }

        private bool IsAStringInputValid(string input)
        {
            return !string.IsNullOrEmpty(input) && input.Length > 0;
        }

        private bool IsAUrlValid(string siteUrl)
        {
            return siteUrl.StartsWith("http://") || siteUrl.StartsWith("https://");            
        }
    }
}
