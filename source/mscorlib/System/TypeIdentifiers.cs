using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000199 RID: 409
	internal class TypeIdentifiers
	{
		// Token: 0x06000FC7 RID: 4039 RVA: 0x0000207A File Offset: 0x0000027A
		internal static TypeIdentifier FromDisplay(string displayName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0200019A RID: 410
		private class Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName>
		{
			// Token: 0x06000FC8 RID: 4040 RVA: 0x00021AC4 File Offset: 0x0001FCC4
			internal Display(string displayName)
			{
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00021AD8 File Offset: 0x0001FCD8
			public override string DisplayName
			{
				get
				{
					return this.displayName;
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00021AEC File Offset: 0x0001FCEC
			public string InternalName
			{
				get
				{
					string text;
					if (this.internal_name == null)
					{
						text = TypeSpec.UnescapeInternalName(this.displayName);
						this.internal_name = text;
					}
					return text;
				}
			}

			// Token: 0x06000FCB RID: 4043 RVA: 0x00021B18 File Offset: 0x0001FD18
			private string GetInternalName()
			{
				return TypeSpec.UnescapeInternalName(this.displayName);
			}

			// Token: 0x04000880 RID: 2176
			private string displayName = displayName;

			// Token: 0x04000881 RID: 2177
			private string internal_name;
		}
	}
}
