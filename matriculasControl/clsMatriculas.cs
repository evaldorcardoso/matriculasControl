using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexaoDllMaster;

namespace matriculasControl
{
    class clsMatriculas
    {
        private int _idMatricula;
        private int _idSemestre;
        private int _idAluno;
        private string _dataMatricula;
        private string _nome;
        private string _descricao;
        private string _ddescricao;
        private string _disciplinas_id_disciplina;
        
        public int id_matricula
        {
            get { return _idMatricula; }
            set { _idMatricula = value; }
        }
        public int semestres_id
        {
            get { return _idSemestre; }
            set { _idSemestre = value; }
        }
        public int alunos_id_aluno
        {
            get { return _idAluno; }
            set { _idAluno = value; }
        }
        public string data_matricula
        {
            get { return _dataMatricula; }
            set { _dataMatricula = value; }
        }
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public string ddescricao
        {
            get { return _ddescricao; }
            set { _ddescricao = value; }
        }
        public string disciplinas_id_disciplina
        {
            get { return _disciplinas_id_disciplina; }
            set { _disciplinas_id_disciplina = value; }
        }
        
        

        public clsMatriculas(string CdataMatricula, int CidAluno,int CidSemestre)
        {
            data_matricula=CdataMatricula;
            alunos_id_aluno = CidAluno;
            semestres_id=CidSemestre;
        }

        public static IDataAdapter matricular(string dataMatricula, int idAluno, int idSemestre)
        {
            StringBuilder matricula = new StringBuilder();
            matricula.Append("insert into matriculas");
            matricula.Append(" values(DEFAULT, " + idSemestre + ", " + idAluno + ", '" + dataMatricula + "')");
            return clsPostgres.setDataAdapter(matricula.ToString());
        }

        public static DataTable pesquisarAluno(string nome)
        {
            StringBuilder select = new StringBuilder();
            select.Append("select m.id_matricula, m.semestres_id ,m.alunos_id_aluno ,a.nome, s.descricao,m.data_matricula,");
            select.Append(" d.ddescricao, md.disciplinas_id_disciplina");
            select.Append(" from alunos a inner join matriculas m on m.alunos_id_aluno=a.id_aluno inner join semestres s");
            select.Append(" on s.id=m.semestres_id inner join matriculas_disciplinas md on");
            select.Append(" m.id_matricula=md.matriculas_id_matricula inner join disciplinas d on");
            select.Append(" md.disciplinas_id_disciplina=d.id_disciplina");
            select.Append(" where a.nome like '%"+nome+"%'");
            return clsPostgres.getDataTable(select.ToString());
        }

        public static DataTable pesquisarSemestre(string nome)
        {
            StringBuilder select = new StringBuilder();
            select.Append("select m.id_matricula, m.semestres_id ,m.alunos_id_aluno ,a.nome, s.descricao,m.data_matricula,");
            select.Append(" d.ddescricao, md.disciplinas_id_disciplina");
            select.Append(" from alunos a inner join matriculas m on m.alunos_id_aluno=a.id_aluno inner join semestres s");
            select.Append(" on s.id=m.semestres_id inner join matriculas_disciplinas md on");
            select.Append(" m.id_matricula=md.matriculas_id_matricula inner join disciplinas d on");
            select.Append(" md.disciplinas_id_disciplina=d.id_disciplina");
            select.Append(" where s.descricao like '%" + nome + "%'");
            return clsPostgres.getDataTable(select.ToString());
        }

        public static DataTable pesquisarDisciplina(string nome)
        {
            StringBuilder select = new StringBuilder();
            select.Append("select m.id_matricula, m.semestres_id ,m.alunos_id_aluno ,a.nome, s.descricao,m.data_matricula,");
            select.Append(" d.ddescricao, md.disciplinas_id_disciplina");
            select.Append(" from alunos a inner join matriculas m on m.alunos_id_aluno=a.id_aluno inner join semestres s");
            select.Append(" on s.id=m.semestres_id inner join matriculas_disciplinas md on");
            select.Append(" m.id_matricula=md.matriculas_id_matricula inner join disciplinas d on");
            select.Append(" md.disciplinas_id_disciplina=d.id_disciplina");
            select.Append(" where d.ddescricao like '%" + nome + "%'");
            return clsPostgres.getDataTable(select.ToString());
        }

        public static DataTable listar()
        {
            StringBuilder select = new StringBuilder();
            select.Append("select id_matricula, semestres_id, alunos_id_aluno, data_matricula");
            select.Append(" from matriculas");
            return clsPostgres.getDataTable(select.ToString());
        }

        public static DataTable listar2()
        {
            StringBuilder select = new StringBuilder();
            select.Append("select m.id_matricula, m.semestres_id ,m.alunos_id_aluno ,a.nome, s.descricao,m.data_matricula, d.ddescricao, md.disciplinas_id_disciplina");
            select.Append(" from alunos a inner join matriculas m on m.alunos_id_aluno=a.id_aluno inner join semestres s");
            select.Append(" on s.id=m.semestres_id inner join matriculas_disciplinas md on m.id_matricula=md.matriculas_id_matricula inner join disciplinas d on md.disciplinas_id_disciplina=d.id_disciplina");
            return clsPostgres.getDataTable(select.ToString());
        }

        public static IDataAdapter editar(int codigoAnt, int codSemestre, int codAluno, string dataMatricula)
        {
            StringBuilder edit = new StringBuilder();
            edit.Append("update matriculas");
            edit.Append(" set semestres_id="+codSemestre+",alunos_id_aluno="+codAluno+",data_matricula='"+dataMatricula+"'");
            edit.Append(" where id_matricula=" + codigoAnt + ";");
            //edit.Append(" update matriculas_disciplinas");
            //edit.Append(" set disciplinas_id_disciplina=" + codDisciplina);
            //edit.Append(" where matriculas_id_matricula=" + codigoAnt + ";");
            return clsPostgres.setDataAdapter(edit.ToString());
        }

        public static IDataAdapter excluir(int codigo)
        {
            StringBuilder delete = new StringBuilder();
            delete.Append("delete from matriculas");
            delete.Append(" where id_matricula = " + codigo + ";");
            return clsPostgres.setDataAdapter(delete.ToString());
        }
    }
}
