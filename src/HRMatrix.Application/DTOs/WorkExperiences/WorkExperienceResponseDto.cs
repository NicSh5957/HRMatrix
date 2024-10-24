﻿namespace HRMatrix.Application.DTOs.WorkExperiences
{
    public class WorkExperienceResponseDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Achievements { get; set; }
    }
}
