namespace OctusBridgeBRIDGE.Models.Dao
{
#pragma warning disable CS1591
    public class StakeholdersDaoResponseModel
    {
        public int TotalCount { get; set; }
        public List<StakeholderDaoHelperModel> Stakeholders { get; set; }
    }

    public class StakeholderDaoHelperModel
    {
        public int ProposalVotesCount { get; set; }
        public string UserAddress { get; set; }
        public string VoteWeight { get; set; }
        public string Votes { get; set; }
    }
}
