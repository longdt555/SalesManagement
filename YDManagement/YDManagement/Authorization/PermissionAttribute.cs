﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace YDManagement.Authorization
{
    public class PermissionAttribute : ActionFilterAttribute
    {
        private string Roles { get; set; }
        public PermissionAttribute(string roles) { this.Roles = roles.Trim().Replace(" ", ""); }
        
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (string.IsNullOrEmpty(Roles)) return;
            try
            {
                //var lstRoleAllowed = Roles.Split(Constants.Comma).ToList();
                //if (lstRoleAllowed.Contains(LoggedOnUser.RoleName))
                //    return;
                //context.Result = new UnauthorizedObjectResult(StatusCodes.Status403Forbidden);
            }
            catch
            {
                context.Result = new UnauthorizedObjectResult(StatusCodes.Status401Unauthorized);
            }
        }
    }
}