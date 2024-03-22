namespace Exercicios2;

public class Restaurante{
	private Boolean isFranchisado;
	public String nome;
	public float royalties;
	public HashSet<Campanha> campanhas;
	public HashSet<Despesa> despesas;
	public HashSet<Alfa> alfas;
	public HashSet<Venda> vendas;

	public bool isvalid(){
		if (!isFranchisado){
			return alfas.Count <= 0;
			
		}
		else{
			var profit = vendas.Sum(s => s.valorTotal)
			             - alfas.Sum(a => a.valorAlfa)
			             - despesas.Sum(d => d.valor)
			             - campanhas.Sum(c => c.valorGasto);
			return profit > 0;
		}
	}
/*
 * context Restaurantes
		inv: not self.isFranchisado implies self.alfas-›isEmpty 
		inv: self.royalties = self. vendas-›collectv: Venda | v.valorTotal) -›sum)
					self.alfas-›collect(a: Alfa | a.valorAlfa) -›sum()
					self.despesas-›collect(d: Despesa | d. valor) -›sum()
					self.campanhas-›collect(c: Campanha | d. valor) -›sum()
		inv: self.name.size() > 0

 */
}