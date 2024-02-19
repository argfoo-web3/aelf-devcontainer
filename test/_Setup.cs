using AElf.Cryptography.ECDSA;
using AElf.Testing.TestBase;

namespace AElf.Contracts.ACS404
{
    // The Module class load the context required for unit testing
    public class Module : ContractTestModule<ACS404>
    {
        
    }
    
    // The TestBase class inherit ContractTestBase class, it defines Stub classes and gets instances required for unit testing
    public class TestBase : ContractTestBase<Module>
    {
        // The Stub class for unit testing
        internal readonly ACS404Container.ACS404Stub ACS404Stub;
        // A key pair that can be used to interact with the contract instance
        private ECKeyPair DefaultKeyPair => Accounts[0].KeyPair;

        public TestBase()
        {
            ACS404Stub = GetACS404ContractStub(DefaultKeyPair);
        }

        private ACS404Container.ACS404Stub GetACS404ContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<ACS404Container.ACS404Stub>(ContractAddress, senderKeyPair);
        }
    }
    
}