using System.Reflection;

namespace FileConverter
{
	public static class AssemblyHelper
	{
		public static string GetAssemblyVersion()
		{
			// Returns in format [Major Version].[Minor Version].[Build Number].[Revision]
			return Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}

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
}
