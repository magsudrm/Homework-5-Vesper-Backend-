using System.ComponentModel.DataAnnotations;

namespace VesperApp.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int TeamMemberId { get; set; }
        public Team TeamMember { get; set; }
    }
}
