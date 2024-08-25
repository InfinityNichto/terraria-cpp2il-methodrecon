using System;

namespace System.Reflection
{
	// Token: 0x020004F5 RID: 1269
	[Flags]
	public enum TypeAttributes
	{
		// Token: 0x0400141E RID: 5150
		VisibilityMask = 7,
		// Token: 0x0400141F RID: 5151
		NotPublic = 0,
		// Token: 0x04001420 RID: 5152
		Public = 1,
		// Token: 0x04001421 RID: 5153
		NestedPublic = 2,
		// Token: 0x04001422 RID: 5154
		NestedPrivate = 3,
		// Token: 0x04001423 RID: 5155
		NestedFamily = 4,
		// Token: 0x04001424 RID: 5156
		NestedAssembly = 5,
		// Token: 0x04001425 RID: 5157
		NestedFamANDAssem = 6,
		// Token: 0x04001426 RID: 5158
		NestedFamORAssem = 7,
		// Token: 0x04001427 RID: 5159
		LayoutMask = 24,
		// Token: 0x04001428 RID: 5160
		AutoLayout = 0,
		// Token: 0x04001429 RID: 5161
		SequentialLayout = 8,
		// Token: 0x0400142A RID: 5162
		ExplicitLayout = 16,
		// Token: 0x0400142B RID: 5163
		ClassSemanticsMask = 32,
		// Token: 0x0400142C RID: 5164
		Class = 0,
		// Token: 0x0400142D RID: 5165
		Interface = 32,
		// Token: 0x0400142E RID: 5166
		Abstract = 128,
		// Token: 0x0400142F RID: 5167
		Sealed = 256,
		// Token: 0x04001430 RID: 5168
		SpecialName = 1024,
		// Token: 0x04001431 RID: 5169
		Import = 4096,
		// Token: 0x04001432 RID: 5170
		Serializable = 8192,
		// Token: 0x04001433 RID: 5171
		WindowsRuntime = 16384,
		// Token: 0x04001434 RID: 5172
		StringFormatMask = 196608,
		// Token: 0x04001435 RID: 5173
		AnsiClass = 0,
		// Token: 0x04001436 RID: 5174
		UnicodeClass = 65536,
		// Token: 0x04001437 RID: 5175
		AutoClass = 131072,
		// Token: 0x04001438 RID: 5176
		CustomFormatClass = 196608,
		// Token: 0x04001439 RID: 5177
		CustomFormatMask = 12582912,
		// Token: 0x0400143A RID: 5178
		BeforeFieldInit = 1048576,
		// Token: 0x0400143B RID: 5179
		RTSpecialName = 2048,
		// Token: 0x0400143C RID: 5180
		HasSecurity = 262144,
		// Token: 0x0400143D RID: 5181
		ReservedMask = 264192
	}
}
