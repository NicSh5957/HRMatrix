﻿namespace HRMatrix.Domain.Entities;

public class Language
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<LanguageTranslation> Translations { get; set; }
}