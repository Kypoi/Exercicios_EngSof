namespace Faturacao;

public class Cliente{
	//
	public String nome{ get; set; }
	public String nif{ get; set; }
	public HashSet<Fatura> faturas{ get; set; }
	//
	
}