using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexaoDllMaster;

namespace matriculasControl
{
    class clsSemestres
    {
        private int _id;
        private string _descricao;

        public int id
        {
            get { return id; }
            set { _id = value; }
        }
        public string descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public clsSemestres(string Cdescricao)
        {
            
            descricao = Cdescricao;
        }

        public static IDataAdapter inserir(string descricao)
        {
            StringBuilder insert = new StringBuilder();
            insert.Append("insert into semestres");
            insert.Append(" values (DEFAULT,'"+descricao+"')");
            return clsPostgres.setDataAdapter(insert.ToString());
        }

        public static DataTable listar()
        {
            StringBuilder select = new StringBuilder();
            select.Append("select id, descricao");
            select.Append(" from semestres");
            return clsPostgres.getDataTable(select.ToString());

        }

        public static IDataAdapter excluir(int codigo)
        {
            StringBuilder delete = new StringBuilder();
            delete.Append("delete from semestres");
            delete.Append(" where id = " + codigo + ";");
            return clsPostgres.setDataAdapter(delete.ToString());
        }

        public static IDataAdapter editar(int codigoAnt, string descricao)
        {
            StringBuilder edit = new StringBuilder();
            edit.Append("update semestres");
            edit.Append(" set descricao='" + descricao + "'");
            edit.Append(" where id = " + codigoAnt + ";");
            return clsPostgres.setDataAdapter(edit.ToString());
        }

        public static DataTable pesquisar(string nome)
        {
            StringBuilder pesquisa = new StringBuilder();
            pesquisa.Append("select id, descricao from semestres");
            pesquisa.Append(" where descricao LIKE '%" + nome + "%'");
            return clsPostgres.getDataTable(pesquisa.ToString());
        }
    }
}
