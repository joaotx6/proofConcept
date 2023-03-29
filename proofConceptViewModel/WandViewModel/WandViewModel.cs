using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proofConceptViewModel.WandViewModel
{
    public class WandViewModel 
    {
        public string wandId { get; set; }
        public string core { get; set; }
        public string wood { get; set; }
        public string flexibility { get; set; }
        public int length { get; set; }
        public float size { get; set; }
        public string imgUrl { get; set; }

    }
}
