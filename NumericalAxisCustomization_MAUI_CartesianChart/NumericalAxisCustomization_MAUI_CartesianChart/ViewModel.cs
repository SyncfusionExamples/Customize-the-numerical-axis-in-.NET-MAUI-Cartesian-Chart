using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalAxisCustomization_MAUI_CartesianChart
{
	public class ViewModel
	{
		public List<Model> Data { get; set; }

		public ViewModel()
		{
			Data = new List<Model>()
			{
				new Model(){Hour = 9, Sales = 15},
				new Model(){Hour = 10, Sales = 12},
				new Model(){Hour = 11, Sales = 20},
				new Model(){Hour = 12, Sales = 18},
				new Model(){Hour = 13, Sales = 25},
				new Model(){Hour = 14, Sales = 22},
				new Model(){Hour = 15, Sales = 30},
				new Model(){Hour = 16, Sales = 28},
				new Model(){Hour = 17, Sales = 35},
				new Model(){Hour = 18, Sales = 32},
			};

		}
	}
}
