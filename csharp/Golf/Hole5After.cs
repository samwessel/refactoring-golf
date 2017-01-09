using System;
using System.Collections.Generic;

namespace Golf
{
	public class Hole5After {

		public abstract class NumberSequence {

			public IEnumerable<int> take (int terms)
			{
				for (int i = 0; i < terms; i++)
					yield return term (i);
			}

			public abstract int term (int n);

		}

		public class FibonacciSequence : NumberSequence {
			
	        public override int term(int n) {
				if (n < 0)
					throw new ArgumentException ("Sequence undefined for negative index");
				if (n < 2)
					return 1;
	            return term(n - 2) + term(n - 1);
	        }

	    }

	    public class TriangularNumberSequence : NumberSequence {

			public override int term(int n) {
				if (n < 0)
					throw new ArgumentException ("Sequence undefined for negative index");
	            return (n + 2) * (n + 1) / 2;
	        }

	    }

	}

}