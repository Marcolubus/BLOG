using BLOG_MODELS.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLOG_SERVICES
{
    interface ITokenService
    {
        public string CreateToken(ApplicationUserIdentity user);
    }
}
