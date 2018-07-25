using System;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
//using Newtonsoft.Json.Bson;
//using Newtonsoft.Json.Converters;
//using Newtonsoft.Json.Schema;
//using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace TrainingProjects
{

    public class ParsingJSON
    {
        public int Parser(Course C1)
        {
            string json = JsonConvert.SerializeObject(C1, Formatting.Indented);

            Course C2 = JsonConvert.DeserializeObject<Course>(json);

            return C2.Id;
        }
    }

    

}
