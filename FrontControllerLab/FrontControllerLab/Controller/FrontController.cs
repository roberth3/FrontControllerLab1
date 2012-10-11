using FrontControllerLab.Controller.Request;
using FrontControllerLab.Controller.ActionCommands;
using System;
using System.Web;

namespace FrontControllerLab.Controller
{
    public class FrontController
    {
        private CommandRegistry _commandRegistry = new CommandRegistry();

        public void Handle(WebRequest request)
        {
            IActionCommand command = _commandRegistry.GetCommandFor(request);

            //If the command requests doesn't match any registered commands return an error page.
            if (command != null)
            {
                command.Process(request);
            }
            else
            {
                HttpContext.Current.Server.Transfer("~/Views/Errors/NoAction.aspx");
            }
        }
    }
}