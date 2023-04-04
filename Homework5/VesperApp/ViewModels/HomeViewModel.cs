using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using VesperApp.Models;

namespace VesperApp.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }
        public List<Team> TeamMembers { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }

    }
}
