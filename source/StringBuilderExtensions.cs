using System;
using System.Text;

// Token: 0x020002FF RID: 767
public static class StringBuilderExtensions
{
	// Token: 0x060011C4 RID: 4548 RVA: 0x00056F8C File Offset: 0x0005518C
	public static void AppendInt(this StringBuilder stringBuilder, int value)
	{
		StringBuilderExtensions.AppendIntCharacter(stringBuilder, value);
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00056FA0 File Offset: 0x000551A0
	private static void AppendIntCharacter(StringBuilder stringBuilder, int value)
	{
		StringBuilderExtensions.AppendIntCharacter(stringBuilder, value);
		StringBuilder stringBuilder2 = stringBuilder.Append((char)value);
	}
}
