namespace Faturacao;

public class Produto{
	//
	public String nome{ get; set; }
	public float precoUnit{ get; set; }
	public HashSet<LinhaFatProduto> faturas{ get; set; }
}