using System;
using System.Collections.Generic;

namespace ProyectoDeGrado.Models;

public partial class Valvula
{
    public int? Id { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? Descripcion { get; set; }

    public double? Caudal { get; set; }

    public int? Diametro { get; set; }

    public double? Area { get; set; }

    public double? VSalida { get; set; }
}
