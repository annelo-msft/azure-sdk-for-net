using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Azure.Core
{
    internal interface IUtf8JsonDeserializable<T> where T : new()
    {
        void Read(ref Utf8JsonReader reader);
    }
}
