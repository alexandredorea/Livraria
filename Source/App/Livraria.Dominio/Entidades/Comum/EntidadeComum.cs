namespace Livraria.Dominio.Entidades.Comum
{
    public abstract class EntidadeComum<Tipo>
    {
        public virtual Tipo Id { get; set; }
    }
}
