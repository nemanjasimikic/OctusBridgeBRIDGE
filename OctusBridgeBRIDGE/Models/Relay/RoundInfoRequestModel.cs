using System.ComponentModel.DataAnnotations;

namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class RoundInfoRequestModel
    {
        [Required]
        public int roundNum { get; set; }
    }
}
