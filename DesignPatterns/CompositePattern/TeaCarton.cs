namespace CompositePattern
{
    public abstract class TeaCarton
    {
        public abstract int GetNumberOfServings();

        public virtual void Add(TeaCarton carton)
        {
            throw new NotImplementedException("Override in concrete TeaCarton classes");
        }

        public virtual void BuildBundle(Dictionary<TeaCarton, int> order)
        {
            throw new NotImplementedException("Override in concrete TeaCarton classes");
        }

        public virtual void Remove(TeaCarton carton)
        {
            throw new NotImplementedException("Override in concrete TeaCarton classes");
        }
        public virtual bool ContainsSubCarton()
        {
            return true;
        }
    }
}
