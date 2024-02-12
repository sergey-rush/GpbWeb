using Newtonsoft.Json;

namespace GpbWeb.Models
{
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        [JsonProperty]
        public TKey Id { get; set; }
    }
}