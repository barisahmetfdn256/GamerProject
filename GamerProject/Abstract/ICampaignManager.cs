using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Abstract
{
    public interface ICampaignManager
    {
        public void Add(Campaign campaign);
        public void Delete(Campaign campaign);
        public void UpDate(Campaign campaign);
    }
}
