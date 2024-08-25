using System;

namespace Mono
{
	// Token: 0x0200001A RID: 26
	internal static class RuntimeStructs
	{
		// Token: 0x0200001B RID: 27
		internal struct RemoteClass
		{
			// Token: 0x04000091 RID: 145
			internal IntPtr default_vtable;

			// Token: 0x04000092 RID: 146
			internal IntPtr xdomain_vtable;

			// Token: 0x04000093 RID: 147
			internal unsafe RuntimeStructs.MonoClass* proxy_class;

			// Token: 0x04000094 RID: 148
			internal IntPtr proxy_class_name;

			// Token: 0x04000095 RID: 149
			internal uint interface_count;
		}

		// Token: 0x0200001C RID: 28
		internal struct MonoClass
		{
		}

		// Token: 0x0200001D RID: 29
		internal struct GenericParamInfo
		{
			// Token: 0x04000096 RID: 150
			internal unsafe RuntimeStructs.MonoClass* pklass;

			// Token: 0x04000097 RID: 151
			internal IntPtr name;

			// Token: 0x04000098 RID: 152
			internal ushort flags;

			// Token: 0x04000099 RID: 153
			internal uint token;

			// Token: 0x0400009A RID: 154
			internal unsafe RuntimeStructs.MonoClass** constraints;
		}

		// Token: 0x0200001E RID: 30
		internal struct GPtrArray
		{
			// Token: 0x0400009B RID: 155
			internal unsafe IntPtr* data;

			// Token: 0x0400009C RID: 156
			internal int len;
		}
	}
}
