using System;

namespace CodeExampleProject
{
    public class Adder
    {
        // Attributes
		private int _sum;
		
		// Constructors
		public Adder()
		{
			_sum = 0;
		}
		
		// Properties
		public int Total
		{ 
			get
			{
				return _sum;
			}
		}
		
		// Methods
		public void Add(int value)
		{
			_sum += value;
		}
		
		public void Reset()
		{
			_sum = 0;
		}
    }
}
