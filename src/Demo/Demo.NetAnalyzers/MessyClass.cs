namespace Demo.NetAnalyzers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Demo.NetAnalyzers.SomeOther.Namespace;

    public class MessyClass {

        private bool someFlag;
        private readonly Int32? _someReadonlyValue;
        private int? _aNullValue;

        private readonly string _notUsed = string.Empty;

        public const String SomeConstValue = "SomeConst";

        int _value;
        public int Value {
            get {
                return _value;
            }
        }

        private void PrivateFunktion() {
            this.someFlag = true;
        }

        public MessyClass() {
            this.someFlag = false;
            _someReadonlyValue = 0;
        }

        public SomeOtherMessyClass? SomeOtherClass { get; set; } = default(SomeOtherMessyClass);

        public void UsingCanBeSimplified() {
            using (var disposable = new DisposableClass()) {
                
                if (someFlag)
                    Console.WriteLine("Using kan förenklas.");
            }
        }

        public void  PoorlySpacedMethod ( string  someString ) {


            var  location = "space";
            var occupation= "scream";

            if ( string.IsNullOrEmpty (someString) && someFlag)

            {
                
                 Console.WriteLine( "In {0} no one can hear you {1}." ,location ,  occupation);
            }

        }

        public void Throw(int? input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            _aNullValue = input;
        }
    }
}