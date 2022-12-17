﻿using CrowdfundingSite.Domain.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.Service
{
    public interface IUserService
    {
        string GetUserId();
        bool IsAuthenticated();
    }
}
