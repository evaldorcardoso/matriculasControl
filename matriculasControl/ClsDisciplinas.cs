using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexaoDllMaster;
using System.Data;

namespace matriculasControl
{
    class ClsDisciplinas
    {
        private int _idDisciplina;
        private string _ddescricao;

        public int id_disciplina
        {
            get { return _idDisciplina; }
            set { _idDisciplina = value; }
        }
        public string ddescricao
        {
            get { return _ddescricao; }
            set { _ddescricao = value; }
        }

        public ClsDisciplinas(string Cdescricao)
        {
            ddescricao = Cdescricao;
        }
        public ClsDisciplinas(int id,string Cdescricao)
        {
            id_disciplina = id;
            ddescricao = Cdescricao;
        }
        public ClsDisciplinas(int id)
        {
            id_disciplina = id;
        }

        public static IDataAdapter inserir(string descricao)
        {
            StringBuilder insert = new StringBuilder();
            insert.Append("insert into disciplinas");
            insert.Append(" values (DEFAULT,'"+descricao+"')");
            return clsPostgres.setDataAdapter(insert.ToString());     
        }

        public static DataTable listar()
        {
            StringBuilder select = new StringBuilder();
            select.Append("select id_disciplina, ddescricao");
            select.Append(" from disciplinas");
            return clsPostgres.getDataTable(select.ToString());
        }

        public static IDataAdapter editar(int codigoAnt, string descricao)
        {
            StringBuilder edit = new StringBuilder();
            edit.Append("update disciplinas");
            edit.Append(" set ddescricao='" + descricao + "'");
            edit.Append(" where id_disciplina = " + codigoAnt + ";");
            return clsPostgres.setDataAdapter(edit.ToString());
        }

        public static IDataAdapter excluir(int codigo)
        {
            StringBuilder delete = new StringBuilder();
            delete.Append("delete from disciplinas");
            delete.Append(" where id_disciplina = " + codigo + ";");
            return clsPostgres.setDataAdapter(delete.ToString());
        }

        public static DataTable pesquisar(string nome)
        {
            StringBuilder pesquisa = new StringBuilder();
            pesquisa.Append("select id_disciplina, ddescricao from disciplinas");
            pesquisa.Append(" where ddescricao LIKE '%" + nome + "%'");
            return clsPostgres.getDataTable(pesquisa.ToString());
        }

    }   
}
