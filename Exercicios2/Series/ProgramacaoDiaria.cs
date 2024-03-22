using System.Runtime.InteropServices.JavaScript;

namespace Series;

public class ProgramacaoDiaria{
	//
	public JSType.Date data{ get; set; }
	public HashSet<Filme> porgramacao;
	//
	public void addPrograma(Filme filme){
		this.porgramacao.Add(filme);
		
	}
}