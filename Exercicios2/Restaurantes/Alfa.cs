using System.Runtime.InteropServices.JavaScript;

namespace Exercicios2;

public class Alfa{
	public JSType.Date data;
	public float valorAlfa;
	public AlfaTotalDiario totDiario;
	public Restaurante rest;
	//
	public bool validate(){
		return valorAlfa > 0;
	}
}
/*
	
	context Alfa
		inv: self.valorAlfa > 0
*/