using System.ComponentModel.DataAnnotations;

namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class RelayInfoRequestModel
    {
        [Required]
        public string relayAddress { get; set; }
    }
}
