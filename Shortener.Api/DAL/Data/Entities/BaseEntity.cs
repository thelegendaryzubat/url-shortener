namespace Shortener.Api.DAL.Data.Entities;

public class BaseEntity<TEntityPK>
{
    public TEntityPK Id { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
}