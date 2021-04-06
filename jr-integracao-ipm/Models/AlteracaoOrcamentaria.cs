using jrintegracaoipm.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace jrintegracaoipm.Models
    {
    public class AlteracaoOrcamentaria
        { 
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int AloNumero { get; set; }
        public DataType AloData { get; set; }
        public int FaoSequencia { get; set; }
        public FaoTipo FaoTipo { get; set; }
        public FaoTipoFonte FaoTipoFonte { get; set; }
        public FaoTipoCredito  FaoTipoCredito { get; set; }
        public double FaoValor { get; set; }
        public int Orgcodigo { get; set; }
        public int Undcodigo { get; set; }
        public int TfcCodigo { get; set; }
        public int TsfCodigo { get; set; }
        public int PgrCodigo { get; set; }
        public AcoTipo AcoTipo { get; set; }
        public int AcoCodigo { get; set; }

        }
    }
