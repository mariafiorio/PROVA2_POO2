using Aluno;

namespace Maria
{
    internal class Aluno
    {
        public string nomeAluno;
        public double nota1Bimestre;
        public double nota2Bimestre;
        public double media;
        public int faltas;
        public string status;
        public bool isSemestreFinalizado;
        public Disciplina disciplina;


        public Aluno(string nomeAluno)
        {
            isSemestreFinalizado = false;
            this.nomeAluno = nomeAluno;
             status = "";
            disciplina = new Disciplina();

        }

        public void AtribuirNota1(double nota1Bimestre)
        {
            this.nota1Bimestre = nota1Bimestre;
        }
        public void AtribuirNota2 (double nota2Bimestre)
        {
            this.nota2Bimestre = nota2Bimestre;
        }
        public void CalcularMedia()
        {
            media = (nota1Bimestre + nota2Bimestre) / 2;
        }

        public void AtribuirFalta()
        {
            faltas++;
        }

        public void AbonarFalta()
        {
            faltas--;
        }
            public void EscolherDisciplina (Disciplina disciplina)
        {
            this.disciplina = disciplina; 
        }


        public string VerificarStatus()
        {
            if (!isSemestreFinalizado)
            {
            
            // condição ? valorSeVerdadeiro : valorSeFalso;

            status = (faltas <= disciplina.limiteFaltas && media >= 7) ? "Aprovada" : "Reprovada";
            }

            return status;
        }
    }
}


