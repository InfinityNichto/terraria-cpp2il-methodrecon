using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000480 RID: 1152
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	[CLSCompliant(false)]
	public sealed class TupleElementNamesAttribute : Attribute
	{
		// Token: 0x0600222A RID: 8746 RVA: 0x0004D040 File Offset: 0x0004B240
		public TupleElementNamesAttribute(string[] transformNames)
		{
			do
			{
				base..ctor();
			}
			while (transformNames == null);
			this._transformNames = transformNames;
		}

		// Token: 0x040012B7 RID: 4791
		private readonly string[] _transformNames;
	}
}
