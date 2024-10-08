﻿namespace HRMatrix.Domain.Entities;

public class UserProfile
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public ICollection<UserEducation> UserEducations { get; set; }

    public ICollection<WorkExperience> WorkExperiences { get; set; }

    public FamilyStatus FamilyStatus { get; set; }

    public ICollection<Language> UserLanguages { get; set; }

    public string AdditionalSkills { get; set; }

    public string AdditionalCompetences { get; set; }

    public string ProfilePhotoPath { get; set; }

    public string VideoPath { get; set; }
}