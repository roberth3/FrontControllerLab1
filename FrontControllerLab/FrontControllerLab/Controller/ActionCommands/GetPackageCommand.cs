using FrontControllerLab.Controller.Storage;
using FrontControllerLab.Controller.Request;
using FrontControllerLab.Controller.Navigation;
using FrontControllerLab.Model;
using System.Collections.Specialized;
using System;

namespace FrontControllerLab.Controller.ActionCommands
{
    public class GetPackageCommand : IActionCommand
    {
        private ViewStorage _storage = new ViewStorage();
        private PageNavigator _pageNavigator = new PageNavigator();
        private PackageRepository _repository = new PackageRepository();


        public void Process(WebRequest webRequest)
        {
            //Get the request parameter
            int id = Convert.ToInt32(webRequest.QueryArguments.GetValues("packageID")[0]);

            //Get the specific Package from the repository
            _storage.Add(ViewStorageKeys.Package, _repository.GetByPackageId(id));
            _pageNavigator.NavigateTo(PageDirectory.Package);
        }

        //Check the current command can handle the request
        public bool CanHandle(WebRequest webRequest)
        {
            return webRequest.RequestedUrl.ToLower().Contains("package");
        }
    }
}