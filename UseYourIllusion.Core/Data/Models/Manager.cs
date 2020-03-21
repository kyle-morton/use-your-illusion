namespace UseYourIllusion.Core.Data.Models
{
    public class Manager : Base
    {
        public string Name { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
