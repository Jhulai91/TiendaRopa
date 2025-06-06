﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TiendaRopa.Infraestructura.AccesoDatos;

/// <summary>
/// Registra los productos individuales que forman parte de un pedido: cantidades y precios unitarios.
/// </summary>
public partial class DetallePedido
{
    public int id_detallepedido { get; set; }

    public int id_pedido { get; set; }

    public int id_producto { get; set; }

    public int cantidad { get; set; }

    public decimal precio_unitario { get; set; }

    public virtual Pedido id_pedidoNavigation { get; set; }

    public virtual Producto id_productoNavigation { get; set; }
}