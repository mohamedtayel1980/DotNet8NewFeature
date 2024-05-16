using System.ComponentModel.DataAnnotations;

namespace Net8DataAnnotations.Models
{
    public class AlertDiendModel
    {
          
            [DeniedValues("Black", "White")]
            public string? AlertValue { get; set; }
        
    }
}
