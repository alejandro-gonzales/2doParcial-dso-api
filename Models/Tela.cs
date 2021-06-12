using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTelas.Models
{
    public class Tela
    {
        [Key]
        public int id { get; set; }
        public string marcaTela { get; set; }
        public int dimAncho { get; set; }
        public int dimLargo { get; set; }
        public string tipoTela { get; set; }
        public string color { get; set; }
        public string paisProc { get; set; }
        public bool estado { get; set; }

    }
}
