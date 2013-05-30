using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexaoDllMaster;
using System.Data;
using System.Windows.Forms;


namespace matriculasControl
{
    
    class ClsAlunos
    {
        public static string status=null;
        public static int cod = 0;
        
        private int _id_aluno;
        private string _nome;
        private string _data_nasc;

        public int id_aluno
        {
            get { return id_aluno; }
            set { _id_aluno = value; }
        }
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string data_nasc
        {
            get { return _data_nasc; }
            set { _data_nasc = value; }
        }

        public ClsAlunos(string Cnome, string Cdata_nasc)
        {
            
            nome = Cnome;
            data_nasc = Cdata_nasc;
        }

        public static DataTable listar()
        {
            StringBuilder select = new StringBuilder();
            select.Append("select id_aluno, nome, data_nasc");
            select.Append(" from alunos");
            return clsPostgres.getDataTable(select.ToString());
            
            
        }
        
        public static IDataAdapter inserir(string nome, string data_nasc)
        {
            StringBuilder insert = new StringBuilder();
            insert.Append("insert into alunos");
            insert.Append(" values (DEFAULT,'"+nome+"','"+data_nasc+"')");
            return clsPostgres.setDataAdapter(insert.ToString());          
        }

        public static DataTable pesquisar(string nome)
        {
            StringBuilder pesquisa = new StringBuilder();
            pesquisa.Append("select id_aluno, nome, data_nasc from alunos");
            pesquisa.Append(" where nome LIKE '%" + nome + "%'");
            return clsPostgres.getDataTable(pesquisa.ToString());
        }

        public static IDataAdapter editar(int codigoAnt, string nome, string data_nasc)
        {
            StringBuilder edit = new StringBuilder();
            edit.Append("update alunos");
            edit.Append(" set nome='" + nome + "', data_nasc='" + data_nasc + "'");
            edit.Append(" where id_aluno = "+codigoAnt+";");
            return clsPostgres.setDataAdapter(edit.ToString());
        }

        public static IDataAdapter excluir(int codigo)
        {
            StringBuilder delete = new StringBuilder();
            delete.Append("delete from alunos");
            delete.Append(" where id_aluno = " + codigo + ";");
            return clsPostgres.setDataAdapter(delete.ToString());
        }

        public static DataTable pesquisarPorId(int id)
        {
            StringBuilder pesquisa = new StringBuilder();
            pesquisa.Append("select id_aluno, nome, data_nasc from alunos");
            pesquisa.Append(" where id_aluno = " + id);
            return clsPostgres.getDataTable(pesquisa.ToString());
        }

    }
}
