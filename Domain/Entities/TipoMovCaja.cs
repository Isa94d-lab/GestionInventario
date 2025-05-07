using System;

namespace GestionInventario.Domain.Entities;
public enum TipoMovimiento 
{
    Salida =0 ,
    Entrada = 1
}
public class TipoMovCaja
{
    public int Id { get; set; }
    public int Nombre { get; set; }
    public TipoMovimiento Tipo_movimiento { get; set; }
}