using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
    public class SiteSettingsService : ISiteSettingsService
    {
        private readonly ISiteSettingsRepository oSiteSettingsRepository;
        public SiteSettingsService(ISiteSettingsRepository _oSiteSettingsRepository)
        {
            this.oSiteSettingsRepository = _oSiteSettingsRepository;
        }
        public SiteSettings SiteSettings_Get(int? SiteID)
        {
            return this.oSiteSettingsRepository.SiteSettings_Get(SiteID);
        }

        public bool SiteSettings_Update(SiteSettings oSiteSettings)
        {
            return this.oSiteSettingsRepository.SiteSettings_Update(oSiteSettings);
        }
    }
}
