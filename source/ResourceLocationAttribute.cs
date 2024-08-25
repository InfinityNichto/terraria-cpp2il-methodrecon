using System;

// Token: 0x02000062 RID: 98
[AttributeUsage(AttributeTargets.All)]
public class ResourceLocationAttribute : Attribute
{
	// Token: 0x06000208 RID: 520 RVA: 0x00005F88 File Offset: 0x00004188
	public ResourceLocationAttribute(string location)
	{
		this.Location = location;
	}

	// Token: 0x040001F6 RID: 502
	public readonly string Location = "";
}
