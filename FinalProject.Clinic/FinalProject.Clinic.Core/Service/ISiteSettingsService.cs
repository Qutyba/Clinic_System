using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
    public interface ISiteSettingsService
    {
        SiteSettings SiteSettings_Get(int? SiteID);
        bool SiteSettings_Update(SiteSettings oSiteSettings);
    }
}
