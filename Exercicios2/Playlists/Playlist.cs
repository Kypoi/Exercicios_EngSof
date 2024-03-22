namespace Playlists;

public class Playlist{
	//
	public String nome;
	public float duracao;
	public Utilizador owner;
	public HashSet<Utilizador> subscritores;
	public HashSet<ItemStream> ItensPlaylist;

	public bool validate(){
		return duracao == ItensPlaylist.Sum(i => i.duracao);
	}
}
/*
 *Context Playlist :: duracao : float
 derive: self.ItensPlayList->collect(i : ItemStream | i.duracao)->sum()
*/