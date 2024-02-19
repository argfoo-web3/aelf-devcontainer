using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.ACS404
{
    // The state class is access the blockchain state
    public partial class ACS404State : ContractState 
    {
        // A state that holds string value
        public StringState Message { get; set; }
    }
}