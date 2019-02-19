using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGof.Strategy.Delegate
{
	public interface IParser
	{
		string Parser(int count);
	}
}
