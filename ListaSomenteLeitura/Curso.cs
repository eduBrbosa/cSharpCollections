using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura
{
    class Curso
    {
		private List<Aula> aulas;

		public IList<Aula> Aulas
		{
			get { return new ReadOnlyCollection<Aula>(aulas); }
		}

		private string nome;
		private string instrutor;


        public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}


		public string Instrutor
		{
			get { return instrutor; }
			set { instrutor = value; }
		}

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
			aulas = new List<Aula>();
        }

        internal void Adiciona(Aula aula)
        {
            aulas.Add(aula);
        }
    }
}
