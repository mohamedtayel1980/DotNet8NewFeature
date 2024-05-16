using System.ComponentModel.DataAnnotations;

namespace Net8DataAnnotations.Models
{
    public class AlertAllowedModel
    {

        [DeniedValues("Red", "Yellow", "Green")]
        public string? AlertValue { get; set; }

    }
}
