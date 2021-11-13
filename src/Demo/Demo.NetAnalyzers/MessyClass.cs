namespace Demo.NetAnalyzers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Demo.NetAnalyzers.SomeOther.Namespace;

    internal class MessyClass {

        private bool someFlag;
        private readonly int _someReadonlyValue;


        public const string SomeConstValue = "SomeConst";

        int _value;
        public int Value {
            get {
                return _value;
            }
        }

        private void PrivateFunktion() {
            someFlag = true;
        }

        public MessyClass() {
            someFlag = false;
            _someReadonlyValue = 0;
        }

        public SomeOtherMessyClass? SomeOtherClass { get; set; } = default(SomeOtherMessyClass);

        public void UsingCanBeSimplified() {
            using (var disposable = new DisposableClass()) {
                Console.WriteLine("Using kan förenklas.");
            }
        }

        public void  PoorlySpacedMethod ( string  someString ) {


            var  location = "space";
            var occupation= "scream";

            if ( string.IsNullOrEmpty (someString))

            {
                
                 Console.WriteLine( "In {0} no one can {1}" ,location ,  occupation);
            }

        }
    }
}