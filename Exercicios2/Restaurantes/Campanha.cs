namespace Exercicios2;

public class Campanha{
	public String nome;
	public float valorGasto;
	public List<Restaurante> rests;

	public bool validate(){
		return valorGasto > 0;
	}
}
/*
 	context Campanha
		inv: self.valorGasto >= 0
 */