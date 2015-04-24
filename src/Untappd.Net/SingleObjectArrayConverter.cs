using System;
using Newtonsoft.Json;
using Untappd.Net.Request;

namespace Untappd.Net
{
    /// <summary>
    /// Created to fix bad json results.
    /// Object expected but sometimes it comes as an empty array.
    /// 
    /// Deserialize json as T if json schema defines an object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class SingleObjectArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var retval = new object();

            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var instance = (T)serializer.Deserialize(reader, typeof(T));
                    retval = instance;
                    break;
                case JsonToken.StartArray:
                    reader.Read();
                    retval = null;
                    break;
            }

            return retval;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
