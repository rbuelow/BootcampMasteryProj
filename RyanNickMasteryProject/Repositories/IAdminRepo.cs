﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanNickMasteryProject.Repositories
{
    interface IAdminRepo
    {
        LmsUserSelectUnassigned_Result LmsUserSelectUnassigned(int userId);
    }
}
