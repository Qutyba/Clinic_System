using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository oContactUsRepository;
        public ContactUsService(IContactUsRepository _oContactUsRepository)
        {
            this.oContactUsRepository = _oContactUsRepository;
        }
        public bool ContactUs_Delete(int contactID)
        {
            return this.oContactUsRepository.ContactUs_Delete(contactID);
        }

        public List<ContactUs> ContactUs_Get(int? SiteID)
        {
            return this.oContactUsRepository.ContactUs_Get(SiteID);
        }

        public bool ContactUs_Insert(ContactUs oContactUs)
        {
            return this.oContactUsRepository.ContactUs_Insert(oContactUs);
        }
    }
}
