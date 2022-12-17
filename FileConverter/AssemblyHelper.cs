using System.Reflection;

namespace FileConverter
{
	public static class AssemblyHelper
	{
		public static Version GetAssemblyVersion()
		{
			return Assembly.GetExecutingAssembly().GetName().Version;
		}

		//public static string GetAssemblyVersion()
		//{
		//	// Returns in format [Major Version].[Minor Version].[Build Number].[Revision]
		//	return Assembly.GetExecutingAssembly().GetName().Version.ToString();
		//}

		public static DateTime GetAssemblyDate()
		{
			return File.GetCreationTime(Assembly.GetExecutingAssembly().Location);
		}

		public static string GetClrVersion()
		{
			return Environment.Version.ToString();
		}

		public static string GetMethodName(MethodInfo method)
		{
			return MethodBase.GetCurrentMethod().Name;
		}
	}

	public class VersionComparer : IComparer<Version>
	{
		public int Compare(Version? x, Version? y)
		{
			if (x?.Major > y?.Major)
				return 1;
			else if (x?.Major < y?.Major)
				return -1;
			else
			{
				if (x?.Minor > y?.Minor)
					return 1;
				else if (x?.Minor < y?.Minor)
					return -1;
				else
				{
					if (x?.Build > y?.Build)
						return 1;
					else if (x?.Build < y?.Build)
						return -1;
					else
					{
						if (x?.Revision > y?.Revision)
							return 1;
						else if (x?.Revision < y?.Revision)
							return -1;
						else
							return 0;
					}
				}
			}
		}
	}
}
