using System;
using System.Collections.Generic;
using FrontControllerLab.Controller.Storage;
using FrontControllerLab.Model;

namespace FrontControllerLab.Views.Packages
{
    public partial class PackageDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Create an instance of the ViewStorage
            //Get the package from it and apply the properties to view fields
            var storage = new ViewStorage();
            var package = (Package)storage.Get(ViewStorageKeys.Package);
            LabelPackageName.Text = package.packagename;
            LabelDiscription.Text = package.description;
            LabelAdultPrice.Text = package.adultprice.ToString();

        }
    }
}