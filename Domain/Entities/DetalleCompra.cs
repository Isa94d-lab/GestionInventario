using System;

namespace GestionInventario.Domain.Entities;

public class DetalleCompra
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string? Producto_id { get; set; }
    public int Cantidad { get; set; }
    public decimal Valor { get; set; }
    public int Compra_id { get; set; }
}