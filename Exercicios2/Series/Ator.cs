namespace Series;

public class Ator{
	//
	public String nome;
	public String shortBio;
	public HashSet<Filme> participa_em_filme;
	public HashSet<Serie> participa_em_serie;
	
	//
	public String Nome{
		get { return nome; }
		set { nome = value; }
	}
	public String ShortBio{
		get { return shortBio; }
		set { shortBio = value; }
	}
}