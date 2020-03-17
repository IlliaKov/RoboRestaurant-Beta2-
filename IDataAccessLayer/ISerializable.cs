using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccessLayer
{
    public interface ISerializable <T>
    {
        string path { get; set; }
        T obj { get; set; }
        bool Serialize();
        T Deserialize();
    }
}
