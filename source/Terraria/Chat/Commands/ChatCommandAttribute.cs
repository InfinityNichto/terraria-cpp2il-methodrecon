using System;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200079C RID: 1948
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
	public sealed class ChatCommandAttribute : Attribute
	{
		// Token: 0x06003FB3 RID: 16307 RVA: 0x00241104 File Offset: 0x0023F304
		public ChatCommandAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x04007DCB RID: 32203
		public readonly string Name;
	}
}
