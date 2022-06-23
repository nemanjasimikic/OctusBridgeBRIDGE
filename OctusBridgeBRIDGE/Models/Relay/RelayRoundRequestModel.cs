using System.ComponentModel.DataAnnotations;

namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class RelayRoundRequestModel
    {
        [Required]
        public string relayAddress { get; set; }
        [Required]
        public int? roundNum { get; set; }
    }
}
