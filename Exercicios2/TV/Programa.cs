namespace TV;

public class Programa{
	//attributes
	private String titulo;
	private float duracao;
	private String realizador;
	public HashSet<Ator> elenco{ get; set; }
	public HashSet<GrelhaProgramacao> grelha{ get; set; }
	
	//
	public String Titulo{
		get { return titulo; }
		set { titulo = value; }
	}
	public float Duracao{
		get { return duracao; }
		set { duracao = value; }
	}
	public String Realizador{
		get { return realizador; }
		set { realizador = value; }
	}
	
	
	//methods
	public HashSet<String> getNomesElenco(){
		HashSet<String> nomesElenco = new HashSet<string>();
		foreach(Ator ator in this.elenco){
			nomesElenco.Add(ator.nome);
		}
		return nomesElenco;
	}
	
}