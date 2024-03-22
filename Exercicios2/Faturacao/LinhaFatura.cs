using System.Net.Mail;
using System.Runtime.InteropServices.JavaScript;

namespace Faturacao;

public class LinhaFatura{
	//
	public float valorLinha{ get; set; }
	public JSType.Date data{ get; set; }
	public String descricao{ get; set; }
	public Fatura fatura;
	

	//duvida
	public bool validate(){
		if (this.GetType() == typeof(LinhaFatServico) && this.GetType().IsSubclassOf(typeof(LinhaServicoTempo))){
			if (this is LinhaServicoTempo tempoLine){
				valorLinha = tempoLine.precoPorHora * tempoLine.tempo;
				return true;
			}
		}
		else if (this is LinhaFatProduto produtoLine){
			valorLinha = produtoLine.precoUnitario * produtoLine.quantidade;
			return true;
		}
		return false; 
	}


}
/*
 Context LinhaFatura
	inv if (self.oclIsTypeOf(LinhaFatServico) and self.oclIsKindOf(LinhaServicoTempo)) then self.valorLinha = self.oclAsType(LinhaServicoTempo).precoPorHora * self.oclAsType(LinhaServicoTempo).tempo endif
			or
			if (self.oclIsTypeOf(LinhaFatProduto))then self.valorLinha = self.oclAsType(LinhaFatProduto).precoUnitario * self.oclAsType(LinhaFatProduto).quantidade endif
			or
			if (self.oclIsTypeOf(LinhaFatServico) and self.oclIsKindOf(LinhaServicoFixo)) then self.valorLinha = self.oclAsType(LinhaServicoFixo).precoFixo endif
*/