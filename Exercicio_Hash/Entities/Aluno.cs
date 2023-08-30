namespace Entities {
    internal class Aluno {

        public int Codigo { get; set; }

        public Aluno(int codigo) {
            Codigo = codigo;
        }

        public override int GetHashCode() {
            return Codigo.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is Aluno)) return false;

            Aluno other = (Aluno)obj;   
            return Codigo.Equals(other.Codigo);
        }
    }
}
