﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias.Application.Interfaces
{
    public interface IPermissionService
    {
        bool CheckPermission(int  permissionId , string userName);
    }
}
