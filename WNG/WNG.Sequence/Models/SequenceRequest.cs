using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WNG.Sequence.Models
{
    public class SequenceRequest
    {
        [Required, Range(1, int.MaxValue)]
        public int Number { get; set; }

    }
}