using System;

namespace BayotMetric.Helpers
{
	public class ConvertHelper
	{
		public ConvertHelper()
		{
		}
		
		public static int ToInt32(object value)
		{
			return ToInt32(value, 0);
		}
		
		public static int ToInt32(object value, int @default)
		{
			int i = @default;
			try {
				i = Convert.ToInt32(value);
			} catch {}
			return i;
		}
	}
}
