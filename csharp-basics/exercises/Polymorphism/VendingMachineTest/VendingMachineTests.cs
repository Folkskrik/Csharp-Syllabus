using VendingMachine;
using VendingMachine = VendingMachine.VendingMachine;

namespace VendingMachineTest
{
    public class VendingMachineTests
    {
        private IVendingMachine _machine;

        [SetUp]
        public void Setup()
        {
            _machine = new VendingMachine("yes");
        }
    }
}
