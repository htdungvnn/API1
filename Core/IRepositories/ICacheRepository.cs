namespace Core;

public interface ICacheRepository
{
    Task<T?> GetAsync<T>(string key);
    Task SetAsync<T>(string key, T data, TimeSpan expirationTime);
    Task RemoveAsync(string key);
}

