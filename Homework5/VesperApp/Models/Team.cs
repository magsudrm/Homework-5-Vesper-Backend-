using System.Collections.Generic;

namespace VesperApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }

        public List<SocialMedia> SocialMedias { get; set; }


    }
}
