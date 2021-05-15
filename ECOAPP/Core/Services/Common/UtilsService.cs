using System;
using System.Collections.Generic;
using System.Text;
using ECOAPP.Core.Interfaces.Common;

namespace ECOAPP.Core.Services.Common
{
    public class UtilsService : IUtilsService
    {
        public DateTime ConvertToColombiaTimeZone(DateTime date)
        {
            return date.AddHours(-5);
        }
    }
}
