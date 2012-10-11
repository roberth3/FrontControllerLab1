using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontControllerLab.Model
{
    public class PackageRepository
    {
        private gcutourswmEntities context = new gcutourswmEntities();

        //Return all the packages
        public IQueryable<Package> GetAll()
        {
            return context.Packages;
        }

        //Return a particular Package
        public Package GetByPackageId(int target)
        {
            return context.Packages.SingleOrDefault(p => p.packageID == target);
        }
    }
}