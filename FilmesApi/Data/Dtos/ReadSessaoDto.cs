﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class ReadSessaoDto
{
    [Required]
    [Key]
    public int FilmeId { get; set; }
    public int CinemaId { get; set; }
}
