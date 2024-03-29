﻿
using BLOG_MODELS.Account;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BLOG_REPOSITORY
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> CreateAsync(ApplicationUserIdentity user, CancellationToken cancellationToken);
        public Task<ApplicationUserIdentity> GetByUsernameAsync(string normalizedUsername,CancellationToken cancellationToken);

    }
}
