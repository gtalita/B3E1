using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3E1
{
    public class Curso
    {
        string nomeCurso;
        string siglaCurso;
        Periodicidade periodicidade;
        int numeroModulos; // Número de semestres ou anos (para o CTTI o valor é 4)
        public List<Periodo> lperiodos = new List<Periodo>();

        public Curso(string nomeCurso, string siglaCurso, Periodicidade periodicidade, int numeroModulos)
        {
            this.nomeCurso = nomeCurso;
            this.siglaCurso = siglaCurso;
            this.periodicidade = periodicidade;
            this.numeroModulos = numeroModulos;
            for (int i = 1; i <= numeroModulos; i++)
            {
                lperiodos.Add(new Periodo(i, this));
            }
        }
    }

    public class Periodo
    {
        int numeroModulo; // Número do semestre ou do ano (e.g.: 1, 2, 3 ou 4)
        Curso curso;
        public List<Disciplina> ldisciplinas = new List<Disciplina>();

        public Periodo(int numeroModulo,  Curso curso)
        {
            this.numeroModulo = numeroModulo;
            this.curso = curso;
        }
    }


    public class Disciplina
    {
        string nomeDisciplina;
        string siglaDisciplina;
        AreaConhecimento areaConhecimento;
        NucleoEstruturante nucleoEstruturante;
        int periodo;
        int numeroTotalAulas;
        int numeroAulasSemanais;

        public Disciplina(string nomeDisciplina, string siglaDisciplina, AreaConhecimento areaConhecimento, NucleoEstruturante nucleoEstruturante, int numeroTotalAulas, int numeroAulasSemanais, int periodo)
        {
            this.nomeDisciplina = nomeDisciplina;
            this.siglaDisciplina = siglaDisciplina;
            this.areaConhecimento = areaConhecimento;
            this.nucleoEstruturante = nucleoEstruturante;
            this.numeroTotalAulas = numeroTotalAulas;
            this.numeroAulasSemanais = numeroAulasSemanais;
            this.periodo = periodo;
        }
    }

}
