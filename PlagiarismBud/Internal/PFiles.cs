using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiarismBud.Internal
{
    public class PFiles
    {
        // Plagiarised file list.

        public PFiles()
        {
            PlagiarisedFiles = new List<PFile>();
        }

        public List<PFile> PlagiarisedFiles { get; set; }

        public void AddFile(PFile ItemPlagiarised)
        {
            PlagiarisedFiles.Add(ItemPlagiarised);
        }
    }
}
