using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexaoDllMaster;
using System.Data;

namespace matriculasControl
{
    class clsMatriculas_Disciplinas
    {
        private int _id;
        private int _idMatriculas;
        private int _idDisciplinas;

        public int id_matricula_disciplina
        {
            get { return _id; }
            set { _id = value; }
        }
        public int matriculas_id_matricula
        {
            get { return _idMatriculas; }
            set { _idMatriculas = value; }
        }
        public int disciplinas_id_disciplina
        {
            get { return _idDisciplinas; }
            set { _idDisciplinas = value; }
        }

        //select max(id_matricula) from matriculas
        public static int pegarIdMatricula()
        {
            StringBuilder selec = new StringBuilder();
            selec.Append("select max(id_matricula) ");
            selec.Append(" from matriculas");
            return clsPostgres.SqlCommand(selec.ToString());
        }

        public static IDataAdapter cadastrar(int CidDisciplina)
        {
            StringBuilder cadastra = new StringBuilder();
            string id = pegarIdMatricula().ToString();
            cadastra.Append("insert into matriculas_disciplinas");
            cadastra.Append(" values(DEFAULT, "+id+", "+CidDisciplina+");");
            return clsPostgres.setDataAdapter(cadastra.ToString());
        }

        public static DataTable listar()
        {
            StringBuilder select = new StringBuilder();
            select.Append("select *");
            select.Append(" from matriculas_disciplinas");
            return clsPostgres.getDataTable(select.ToString());
        }

        public static IDataAdapter editar(int codMatricula, int codDisciplina)
        {
            StringBuilder edit = new StringBuilder();
            edit.Append(" update matriculas_disciplinas");
            edit.Append(" set disciplinas_id_disciplina=" + codDisciplina);
            edit.Append(" where matriculas_id_matricula=" + codMatricula + ";");
            return clsPostgres.setDataAdapter(edit.ToString());
        }

        //Método excluir desnecessário devido a configuração do banco estar com a 
        //opção "ON DELETE CASCADE", pela referência do id da matricula da tabela "matriculas"
    }
}
