using System;

namespace GestionInventario.Domain.Entities;

public class Empresa
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime FechaReg { get; set; }
    public int Ciudad_id { get; set; }
}