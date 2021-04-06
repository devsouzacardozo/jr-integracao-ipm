using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class EstornoEmpenho
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int LoaAnoEmp { get; set; }
        public int EmpNro { get; set; }
        public int EmpSup { get; set; }
        public int EstSequencia { get; set; }
        public string EstHistorico { get; set; }
        public int EstTipoCancResto { get; set; }
        public DateTime EstData { get; set; }
        public double EstValor { get; set; }
        public int CtlSequencia { get; set; }
        }
    }
