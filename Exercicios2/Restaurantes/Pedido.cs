namespace Exercicios2;

public class Pedido{
	public float preocTotal;
	public Venda venda;
	public Sobremesa? sobremesa;
	public Acompanhamento? Acompanhamento;
	public Bebida? Bebida;
	public Menu menu;

	public bool validate(){
		return preocTotal == this.menu.preco + this.sobremesa.preco;
	}

}
/*
	context Pedido
		inv: self.precoTotal = self.menu.preco + if self.sobremesa->notEmpty() then self.sobremesa.valor else 0 endif
*/