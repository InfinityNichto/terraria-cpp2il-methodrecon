using System;

namespace UnityEngineInternal
{
	// Token: 0x02000005 RID: 5
	[AttributeUsage(AttributeTargets.Method)]
	[Serializable]
	public class TypeInferenceRuleAttribute : Attribute
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00000278
		public TypeInferenceRuleAttribute(TypeInferenceRules rule)
		{
			string text;
			this._rule = text;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002094 File Offset: 0x00000294
		public TypeInferenceRuleAttribute(string rule)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020A8 File Offset: 0x000002A8
		public override string ToString()
		{
			return this._rule;
		}

		// Token: 0x04000006 RID: 6
		private readonly string _rule;
	}
}
