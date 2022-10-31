namespace Shortener.Api.DAL.Data.Entities;

public class ShortedUrl
{
    public Uri ShortUrl { get; set; }
    public Uri FullUrl { get; set; }
    public Guid CreatedBy { get; set; }
}