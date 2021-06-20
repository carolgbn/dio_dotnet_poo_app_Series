using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class CartoonRepositorio : IRepositorio<Cartoon>
	{
        private List<Cartoon> listaCartoon = new List<Cartoon>();
		public void Atualiza(int id, Cartoon objeto)
		{
			listaCartoon[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaCartoon[id].Excluir();
		}

		public void Insere(Cartoon objeto)
		{
			listaCartoon.Add(objeto);
		}

		public List<Cartoon> Lista()
		{
			return listaCartoon;
		}

		public int ProximoId()
		{
			return listaCartoon.Count;
		}

		public Cartoon RetornaPorId(int id)
		{
			return listaCartoon[id];
		}
	}
}