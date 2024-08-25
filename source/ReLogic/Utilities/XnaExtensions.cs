using System;

namespace ReLogic.Utilities
{
	// Token: 0x02000B0E RID: 2830
	public static class XnaExtensions
	{
		// Token: 0x06005301 RID: 21249 RVA: 0x00283C74 File Offset: 0x00281E74
		public static T Get<T>(this IServiceProvider A_0) where T : class
		{
			Type type;
			while (type != null)
			{
				if (type == null)
				{
					throw new InvalidCastException();
				}
			}
		}
	}
}
