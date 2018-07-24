using System;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TrainingProjects
{
    public class ParsingJSON
    {
        public int Parser(Course C1, Course C2)
        {
            return ((dynamic)(JsonConvert.DeserializeObject(JsonConvert.SerializeObject(C1)))).Id;
        }
    }


}
