using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsEmModelos
{
    class Curso
    {
		private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
		{ 
			get
			{
				return new ReadOnlyCollection<Aluno>(alunos.ToList());
			} 
		}

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

		public int TempoTotal
		{
			get
			{
				//int total = 0;
				//foreach(var aula in aulas)
				//{
				//	total += aula.Tempo;
				//}
				//return total;

				return aulas.Sum(aula => aula.Tempo);
			}
		}

        internal void Adiciona(Aula aula)
        {
            aulas.Add(aula);
        }

        public override string ToString()
        {
			return $"Curso: {nome}, Tempo: {TempoTotal},\n Aulas: {string.Join(",\n", aulas)}";
        }

        internal void Matricula(Aluno aluno)
        {
			alunos.Add(aluno);
        }
    }
}
