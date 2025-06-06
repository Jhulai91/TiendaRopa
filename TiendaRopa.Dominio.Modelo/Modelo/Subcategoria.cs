﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TiendaRopa.Infraestructura.AccesoDatos;

/// <summary>
/// Almacena subcategorías específicas dentro de cada categoría (ej: “Camisas” en “Ropa”).
/// </summary>
public partial class Subcategoria
{
    public int id_subcategoria { get; set; }

    public string nombre { get; set; }

    public int id_categoria { get; set; }

    public virtual ICollection<Producto> Producto { get; set; } = new List<Producto>();

    public virtual Categoria id_categoriaNavigation { get; set; }
}