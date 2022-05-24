using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tablet_blazor.Models;

namespace tablet_blazor.Services
{
    interface IAbout_Table_Service
    {
        public Task<List<Table>> getTables();
    }
}
