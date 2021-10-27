using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
    public interface IContactUsService
    {
        List<ContactUs> ContactUs_Get(int? SiteID);
        bool ContactUs_Insert(ContactUs oContactUs);
        bool ContactUs_Delete(int contactID);
    }
}
