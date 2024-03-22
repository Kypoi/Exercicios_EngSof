namespace Faturacao;

public class ServicoPrecoFixo{
	//
	public float precoTotal{ get; set; }
	public HashSet<LinhaServicoFixo> faturas;
}