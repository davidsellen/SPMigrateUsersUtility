using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace MigrateUsersUtility
{
    public class DomainUsersMigrationUtility
    {
        private DomainUsersMigrationRequest request;
        private int totalUsers;
        private int migratedUsers;
        private int skipedUsers;
        private List<string> messages = new List<string>();
                 
        public DomainUsersMigrationUtility(DomainUsersMigrationRequest request)
        {
            this.request = request;
        }

        public void Start()
        {
            request.Validate();
            using (var site = new SPSite(request.SiteCollectionUrl))
            using (var web = site.OpenWeb())
            {
                var allUsers = web.AllUsers;
                messages.Clear();
                totalUsers = allUsers.Count;
                foreach (SPUser user in web.AllUsers)
                {
                    SPFarm farm = SPFarm.Local;
                    string oldLogin = user.LoginName;
                    string newLogin = user.LoginName.Replace(request.OldDomainName, request.NewDomainName);
                    bool enforceSidHistory = request.EnforceSidHistory;
                    try
                    {
                        farm.MigrateUserAccount(oldLogin, newLogin, enforceSidHistory);
                        migratedUsers++;
                        messages.Add(string.Format("Migrated User {0} to {1}", oldLogin, newLogin));
                    }
                    catch (SPException ex)
                    {
                        skipedUsers++;
                        messages.Add(ex.Message + " - " + oldLogin);
                        continue;
                    }
                }
            }
        }        
        public int MigratedUsers { get { return totalUsers; } }
        public int TotalUsers { get { return migratedUsers; } }
        public int SkipedUsers { get { return skipedUsers; } }
        public List<string> Messages { get { return messages; } }
        
    }
}
