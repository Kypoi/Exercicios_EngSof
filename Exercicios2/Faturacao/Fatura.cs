using System.Runtime.InteropServices.JavaScript;

namespace Faturacao;

public class Fatura{
	//
	public float valorTotal{ get; set; }
	public JSType.Date data{ get; set; }
	public Cliente cliente{ get; set; }
	public HashSet<LinhaFatura> linhas{ get; set; }
	//

}