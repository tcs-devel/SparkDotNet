using System;
using Newtonsoft.Json;

namespace SparkDotNet {
    public class Person
    {
        public string id { get; set; }
        public string[] emails { get; set; }
        public string displayName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string orgId { get; set; }
        public string[] roles { get; set; }
        public string[] licenses { get; set; }
        public DateTime created { get; set; }
        public string timeZone { get; set; }


        public override string ToString() {
            return JsonConvert.SerializeObject(this);
        }
    }

    
}