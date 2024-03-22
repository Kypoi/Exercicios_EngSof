using System.Runtime.InteropServices.JavaScript;

namespace TV;

public class GrelhaProgramacao{
	//
	private JSType.Date data{ get; set; }
	public HashSet<Programa> programas;
	
	
	//
	public GrelhaProgramacao(JSType.Date data){
		this.data = data;
	}

	//
	public void addPrograma(Programa prog){
		this.programas.Add(prog);
		
	}

	public bool validate(){
		float total = 0;
		
		foreach (Programa programa in this.programas){
			total += programa.Duracao;
		}

		return total <= 24;
	}
}
/*
 Context GrelhaProgramacao
	inv: self.programas->collect(p : Programas | p.getDuracao())->sum() <= 24 
	
*/