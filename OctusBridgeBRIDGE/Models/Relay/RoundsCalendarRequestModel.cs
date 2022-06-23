using System.ComponentModel.DataAnnotations;

namespace OctusBridgeBRIDGE.Models.Relay
{
#pragma warning disable CS1591
    public class RoundsCalendarRequestModel
    {
        [Required]
        public int fromRoundNum { get; set; }
        [Required]
        public int toRoundNum { get; set; }
    }
}
