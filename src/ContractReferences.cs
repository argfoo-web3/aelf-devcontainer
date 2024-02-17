using AElf.Contracts.Consensus.AEDPoS;
using AElf.Contracts.MultiToken;
using AElf.Standards.ACS6;

namespace AElf.Contracts.ACS404
{
    public partial class WispContractState
    {
        internal TokenContractContainer.TokenContractReferenceState TokenContract { get; set; }
    }
}