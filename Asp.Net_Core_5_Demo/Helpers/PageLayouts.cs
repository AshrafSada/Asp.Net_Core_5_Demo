namespace Asp.Net_Core_5_Demo.Helpers
{
	public static class PageLayouts
	{
		public static short PageIndex { get; set; }

		public static short PageSize { get; set; }

		public static string PaperSize { get; set; }

		public static bool Portrait { get; set; }

		public static bool Landscape { get; set; }

		// TODO: These values should be set by user in options or preferences controller
		public static short[] GetPaging()
		{
			PageIndex = 1; PageSize = 15;
			short[] paging = new short[] { PageIndex, PageSize };
			return paging;
		}
	}
}