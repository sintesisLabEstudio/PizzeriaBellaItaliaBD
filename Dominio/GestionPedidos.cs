using System;
using System.Collections.Generic;

namespace PizzeriaBellaItalia.Dominio;

public class GestionPedidos
{
    // Lista global de pedidos en memoria
    //public List<PedidoPizza> pedidos = new();
    public List<PedidoPizza> pedidos = [];

    public void AgregarPedido(PedidoPizza pedido)
    {
        pedidos.Add(pedido);
    }
}