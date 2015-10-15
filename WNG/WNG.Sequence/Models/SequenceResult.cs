using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WNG.Sequence.Models
{
    public class SequenceResult
    {
        public int Number { get; set; }
        public List<int> NumberSequence { get; set; }
        public List<int> OddSequence { get; set; }
        public List<int> EvenSequence { get; set; }
        public List<string> CustomSequence { get; set; }
        public List<int> FibinachiSequence { get; set; }
    }
}