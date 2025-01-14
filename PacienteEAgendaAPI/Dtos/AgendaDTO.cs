﻿using System.ComponentModel.DataAnnotations;

namespace PacienteEAgendaAPI.Dtos
{
    public class AgendaDTO
    {
            [Required]
            public string NomeAgenda { get; set; }
            [Required]
            public string ProfissionalAgenda { get; set; }
            [Required]
            public DateTime DataAgenda { get; set; }
            [Required]
            public TimeSpan HoraAgenda { get; set; }
        
    }

}

