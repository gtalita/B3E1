namespace B3E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Curso curso = new Curso("Curso Técnico de Informática Integrado ao Ensino Médio", "CTII", Periodicidade.Anual, 4);


            curso.lperiodos[0].ldisciplinas.Add(new Disciplina("Matemática", "CBTMA1", AreaConhecimento.Matematica, NucleoEstruturante.Comum, 114, 3, 1));
            

            foreach (Curso.Periodo item in CTII.periodos)
            { 
                switch(periodo1)
                    case 1:
                    CTII.periodos.Contains(item);
                    break;
            }

        }
    }
}