using System.IO;
using System.Runtime.Serialization.Json;
using IDataAccessLayer;

namespace BusinessLogicLayer
{
    public class JsonSerialization<T> : ISerializable<T>
    {
        public string path { get; set; }
        public T obj { get; set; }
        DataContractJsonSerializer jsonFormatter;
        public JsonSerialization(string path, T obj)
        {
            this.path = path;
            this.obj = obj;

            jsonFormatter = new DataContractJsonSerializer(typeof(T));
        }
        public bool Serialize()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, obj);
                return true;
            }
        }
        public T Deserialize()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                T newObject = (T)jsonFormatter.ReadObject(fs);
                return newObject;
            }
        }
    }
}
