namespace OpenClosedPrinciple.Interface
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T t);
    }
}