using System;
using System.Collections.Generic;
using System.Text;

namespace ECOAPP.Core.Interfaces.Common
{
    public interface IUtilsService
    {
        /// <summary>
        /// Convert to colombian time zome
        /// </summary>
        /// <returns></returns>
        DateTime ConvertToColombiaTimeZone(DateTime date);
    }
}
