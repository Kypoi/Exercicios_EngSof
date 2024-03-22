namespace Series;

public class Serie{
	//
	public String titulo{ get; set; }
	public int numTemporadas{ get; set; }
	public String realizador{ get; set; }
	public HashSet<Ator> elenco;
	public List<Episodio> Episodios;
	//

	public bool validate(){
		return numTemporadas == Episodios.Max(e => e.temporada);
	}
}
/*
 Context Serie
	inv: self.numTemporadas = self.Episodios->collect(e : Episodio | e.temporada)->max()
 */
