using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Maria");
            aluno1.AtribuirNota1(10);
            aluno1.AtribuirNota2(8);
            aluno1.CalcularMedia();
            aluno1.AtribuirFalta();
            aluno1.AtribuirFalta();
            aluno1.AtribuirFalta();

            Disciplina disciplina1 = new Disciplina();
            disciplina1.AtribuirNomeDisciplina("POO 2");
            disciplina1.AtribuirCargaHoraria(20);
            aluno1.EscolherDisciplina(disciplina1);
            disciplina1.AtribuirLimiteFalta();
            aluno1.VerificarStatus();
            

            Console.WriteLine($"\nA aluna {aluno1.nomeAluno} está {aluno1.status} na disciplina {aluno1.disciplina.nomeDisciplina}.");
            Console.WriteLine(
                "\n--------------HISTÓRICO ESCOLAR---------------" +
                "\nFaltas: " + aluno1.faltas + 
                "\nLimite de Faltas: " + aluno1.disciplina.limiteFaltas + 
                "\nNota do 1º bimestre: " + aluno1.nota1Bimestre + 
                "\nNota do 2º bimestre: " + aluno1.nota2Bimestre +
                "\nMédia: " + aluno1.media + 
                "\nStatus: " + aluno1.status);
        }
    }
}
