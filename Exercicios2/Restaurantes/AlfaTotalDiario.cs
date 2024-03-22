using System.Runtime.InteropServices.JavaScript;

namespace Exercicios2;

public class AlfaTotalDiario{
	public JSType.Date data;
	public float valorAlfa;
	public HashSet<Alfa> alfas;

	public bool validate(){
		return this.valorAlfa > 0 && alfas.Sum(a => a.valorAlfa) == valorAlfa;
	}
}
/*
	context AlfaTotalDiario
		inv: self.valorAlfa = self.alfas-›collect(a: Alfa | a.valorAlfa) -›sum()
		inv: self.valorAlfa > 0
		inv: self.alfas-›forAll(a: Alfa | a.data = self.data)
*/
	