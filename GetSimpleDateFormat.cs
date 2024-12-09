using System;

namespace DatedFileName
{
	public partial class CDatedFileName
	{
		/// <summary>
		/// Returns YYYYMMDD or YYYY(delim)MM{delim}DD 
		/// </summary>
		/// <param name="dtWhen">DateTime to use</param>
		/// <param name="strDelim">Delimiter to use or null</param>
		/// <returns></returns>
		public static string GetSimpleDateFormat(DateTime dtWhen, string strDelim = "")
		{
			return string.Format("{1}{0}{2}{0}{3}",
				strDelim,
				dtWhen.Year.ToString("D4"),
				dtWhen.Month.ToString("D2"),
				dtWhen.Day.ToString("D2")); // call this from the immediate window.
		}
	}
}