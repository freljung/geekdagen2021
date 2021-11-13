namespace Demo.NetAnalyzers.SomeOther.Namespace
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SomeOtherMessyClass {

        private bool someFlag;
        private readonly int _someReadonlyValue;


        public const string SomeConstValue = "SomeConst";

        private void PrivateFunktion() {
            someFlag = true;
        }

        public SomeOtherMessyClass() {
            someFlag = false;
            _someReadonlyValue = 0;
        }

        internal MessyClass? MessyClass { get; set; } = default(MessyClass);

        public void UsingCanBeSimplified() {
            using (var disposable = new DisposableClass()) {
                Console.WriteLine("Using kan förenklas.");
            }
        }
    }
}