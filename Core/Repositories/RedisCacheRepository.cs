namespace Core;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

public class RedisCacheRepository : ICacheRepository
{
    private readonly ConnectionMultiplexer _redisConnection;

    public RedisCacheRepository(string connectionString)
    {
        _redisConnection = ConnectionMultiplexer.Connect(connectionString);
    }

    public async Task<T?> GetAsync<T>(string key)
    {
        IDatabase cache = _redisConnection.GetDatabase();
        RedisValue cachedValue = await cache.StringGetAsync(key);

        if (!cachedValue.IsNullOrEmpty)
        {
            string serializedData = cachedValue.ToString();
            return JsonConvert.DeserializeObject<T>(serializedData);
        }

        return default(T);
    }

    public async Task SetAsync<T>(string key, T data, TimeSpan expirationTime)
    {
        IDatabase cache = _redisConnection.GetDatabase();
        string serializedData = JsonConvert.SerializeObject(data);
        await cache.StringSetAsync(key, serializedData, expirationTime);
    }

    public async Task RemoveAsync(string key)
    {
        IDatabase cache = _redisConnection.GetDatabase();
        await cache.KeyDeleteAsync(key);
    }

}
