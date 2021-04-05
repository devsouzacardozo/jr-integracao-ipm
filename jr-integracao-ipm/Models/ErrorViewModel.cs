using System;

namespace jr_integracao_ipm.Models
    {
    public class ErrorViewModel
        {
        public string RequestId { get; set; }
        
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        }
    }