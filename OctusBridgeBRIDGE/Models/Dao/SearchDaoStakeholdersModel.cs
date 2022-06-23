using System.ComponentModel.DataAnnotations;

namespace OctusBridgeBRIDGE.Models.Dao
{
#pragma warning disable CS1591
    public class SearchDaoStakeholdersModel
    {
        [Required]
        public int limit { get; set; }
        [Required]
        public int offset { get; set; }
        public string? ordering { get; set; }
    }
}
