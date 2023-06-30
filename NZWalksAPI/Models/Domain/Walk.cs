namespace NZWalksAPI.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; } // can have null values so use ?
        public Guid DifficultyId { get; set; }
        public Guid RedionId { get; set; }

        // Navigation Property
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}
