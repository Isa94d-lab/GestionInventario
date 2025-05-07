using System;

namespace GestionInventario.Domain.Entities;


public class Plan
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public int Dscto { get; set; }
}