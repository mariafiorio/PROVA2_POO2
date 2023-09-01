namespace Aluno
{
    internal class Aluno
    {
        private string nomeAluno;
        private double nota1Bimestre;
        private double nota2Bimestre;
        private double media;
        private int faltas;
        private string status;
        private bool isSemestreFinalizado;
        private Disciplina disciplina;


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


