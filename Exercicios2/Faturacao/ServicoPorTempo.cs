namespace Faturacao;

public class ServicoPorTempo : Servico{
	//
	public float precoPorHora{ get; set; }
	public HashSet<LinhaServicoTempo> faturas;
	
}