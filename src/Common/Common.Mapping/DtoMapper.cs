using System.Text.Json;

namespace Common.Mapping
{
    public static class DtoMapper
    {
        public static T MapTo<T>(this object obj) => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(obj));
    }
}
