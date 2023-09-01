using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluno
{
    public class Disciplina
    {
        private string nomeDisciplina;
        private int cargaHoraria;
        private double limiteFaltas;


        public Disciplina()
        {
            
        }
        public Disciplina(string nomeDisciplina, int cargaHoraria)
        {
            this.nomeDisciplina = nomeDisciplina;
            this.cargaHoraria = cargaHoraria;
            
        }

           public void AtribuirNomeDisciplina (string nomeDisciplina)
        {
            this.nomeDisciplina = nomeDisciplina;
        }

           public void AtribuirCargaHoraria (int cargaHoraria)
        {
            this.cargaHoraria = cargaHoraria;
        }
           public void AtribuirLimiteFalta()
        {
            limiteFaltas = 0.25 * cargaHoraria;      
            
         }
    }
}
