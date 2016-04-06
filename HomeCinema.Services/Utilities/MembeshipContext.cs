using HomeCinema.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Services.Utilities
{
    public class MembershipContext
    {
        public IPrincipal Principal { get; set; }
        public User User { get; set; }
        public bool IsValid()
        {
            return Principal != null;
        }

        //public MembershipContext ValidateUser(string username, string password)
        //{
        //    var membershipCtx = new MembershipContext();

        //    var user = _userRepository.GetSingleByUsername(username);
        //    if (user != null && isUserValid(user, password))
        //    {
        //        var userRoles = GetUserRoles(user.Username);
        //        membershipCtx.User = user;

        //        var identity = new GenericIdentity(user.Username);
        //        membershipCtx.Principal = new GenericPrincipal(
        //            identity,
        //            userRoles.Select(x => x.Name).ToArray());
        //    }

        //    return membershipCtx;
        //}
    }
}
