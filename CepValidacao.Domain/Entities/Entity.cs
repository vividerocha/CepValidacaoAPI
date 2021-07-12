namespace CepValidacao.Domain.Entities
{
    public abstract class Entity<TId>
    {
        #region Properties
        public TId Id { get; set; }
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity<TId>;

            if (ReferenceEquals(this, compareTo)) return true;
            if (compareTo is null) return false;

            return Id.Equals(compareTo.Id);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() + Id.GetHashCode());
        }

        public static bool operator ==(Entity<TId> entityA,
                                       Entity<TId> entityB)
        {
            if (entityA is null && entityB is null)
                return true;

            if ((entityA is null && entityB != null) || (entityA != null && entityB is null))
                return false;

            return entityA.Equals(entityB);
        }

        public static bool operator !=(Entity<TId> entityA, Entity<TId> entityB)
        {
            return !(entityA == entityB);
        }
        #endregion
    }
}