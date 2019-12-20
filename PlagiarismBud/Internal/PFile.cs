using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiarismBud.Internal
{
    public class PFile
    {
        public PFile(string _name, string _location, DateTime _created, DateTime _modified)
        {
            FileName = _name;
            FileLocation = _location;
            FileCreated = _created;
            FileModified = _modified;

            FileCreatedS = _created.ToString();
            FileModifiedS = _modified.ToString();
        }

        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public DateTime FileCreated { get; set; }
        public DateTime FileModified { get; set; }

        public string FileCreatedS { get; set; }
        public string FileModifiedS { get; set; }
    }
}
