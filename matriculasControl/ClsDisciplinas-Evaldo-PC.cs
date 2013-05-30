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
        private string _descricao;

        public int idDisciplina
        {
            get { return idDisciplina; }
            set { _idDisciplina = value; }
        }
        public string descricao
        {
            get { return descricao; }
            set { _descricao = value; }
        }

        public static IDataAdapter inserir(string descricao)
        {
            StringBuilder insert = new StringBuilder();
            insert.Append("insert into disciplinas");
            insert.Append(" values ('"+descricao+"')");
            return clsPostgres.setDataAdapter(insert.ToString());
                
        }

        public static DataTable listar()
        {
            StringBuilder select = new StringBuilder();
            select.Append("select *");
            select.Append(" from disciplinas");
            return clsPostgres.getDataTable(select.ToString());
            
        }

        public static IDataAdapter editar(int codigoAnt, int codigo, string descricao)
        {
            StringBuilder edit = new StringBuilder();
            edit.Append("delete from disciplinas");
            edit.Append(" where id_disciplina = " + codigoAnt + ";");
            edit.Append("insert into disciplinas");
            edit.Append(" values ('" + codigo + "','" + descricao + "')");
            return clsPostgres.setDataAdapter(edit.ToString());
        }

        public static IDataAdapter excluir(int codigo)
        {
            StringBuilder delete = new StringBuilder();
            delete.Append("delete from disciplinas");
            delete.Append(" where id_disciplina = " + codigo + ";");
            return clsPostgres.setDataAdapter(delete.ToString());
        }

    }   
}
