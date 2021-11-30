﻿namespace Entities.DTOs
{
    public class JuniorSoftwareDeveloperDto : IDto
    {
        public int Id { get; set; }
        public int SeniorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string SeniorName { get; set; }

        // public string Address { get; set; }
        // public long Phone { get; set; }
        // public string EmailAddress { get; set; }
        // public DateTime StartDate { get; set; }
        // public DateTime EndDate { get; set; }
        // public string WorkSituation { get; set; }
        public decimal Wage { get; set; }
    }
}