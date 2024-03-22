using System.Runtime.InteropServices.JavaScript;

namespace Exercicios2;

public class Venda{
	public JSType.Date data;
	public float valorTotal;
	public Restaurante rest;
	public List<Cliente> cli;
	public List<Pedido> pedidos;

	public bool validate(){
		return valorTotal > 0 && pedidos.Sum(p => p.preocTotal) == valorTotal;
	}
}
/*
	context Venda
		inv: self.valorTotal = self.pedidos->collect(p : Pedido | p.precoTotal )->sum()
		inv self.valorTotal > 0
*/