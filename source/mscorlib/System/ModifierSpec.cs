using System;
using System.Text;

namespace System
{
	// Token: 0x0200019B RID: 411
	internal interface ModifierSpec
	{
		// Token: 0x06000FCC RID: 4044
		Type Resolve(Type type);

		// Token: 0x06000FCD RID: 4045
		StringBuilder Append(StringBuilder sb);
	}
}
