using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000243 RID: 579
	[Serializable]
	public class EndpointPermission
	{
		// Token: 0x06000E95 RID: 3733 RVA: 0x0002E570 File Offset: 0x0002C770
		internal EndpointPermission(string hostname, int port, TransportType transport)
		{
			do
			{
				base..ctor();
			}
			while (hostname == null);
			this.hostname = hostname;
			this.port = port;
			this.resolved = transport != (TransportType)0;
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0002E59C File Offset: 0x0002C79C
		public string Hostname
		{
			get
			{
				return this.hostname;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0002E5B0 File Offset: 0x0002C7B0
		public int Port
		{
			get
			{
				return this.port;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0002E5C4 File Offset: 0x0002C7C4
		public TransportType Transport
		{
			get
			{
				return this.transport;
			}
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				int num = this.port;
				TransportType transportType = this.transport;
				string text = this.hostname;
				return;
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00002050 File Offset: 0x00000250
		public override int GetHashCode()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0002E600 File Offset: 0x0002C800
		public override string ToString()
		{
			string text = this.hostname;
			string text2;
			if ((text == null || text != null) && ("#" == null || "#" != null) && (text2 == null || text2 != null) && ("#" == null || "#" != null))
			{
				TransportType transportType = this.transport;
				string text3;
				if (text3 == null || text3 != null)
				{
					string text4;
					return text4;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0002E658 File Offset: 0x0002C858
		internal bool IsSubsetOf(EndpointPermission perm)
		{
			if (perm == null)
			{
				return;
			}
			int num = perm.port;
			int num2 = this.port;
			TransportType transportType = perm.transport;
			TransportType transportType2 = this.transport;
			this.Resolve();
			perm.Resolve();
			if (this.hasWildcard)
			{
				if (perm.hasWildcard)
				{
					string text = this.hostname;
					string text2 = perm.hostname;
					return this.IsSubsetOf(text, text2);
				}
				return;
			}
			else
			{
				IPAddress[] array = this.addresses;
				if (array == null)
				{
					return;
				}
				if (perm.hasWildcard)
				{
					ushort[] numbers = array._numbers;
					string text3 = perm.hostname;
				}
				IPAddress[] array2 = perm.addresses;
				if (array2 != null)
				{
					ushort[] numbers2 = array2._numbers;
					string text4 = this.hostname;
					return;
				}
				return;
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0002E710 File Offset: 0x0002C910
		private bool IsSubsetOf(string addr1, string addr2)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0002E728 File Offset: 0x0002C928
		internal EndpointPermission Intersect(EndpointPermission perm)
		{
			while (perm != null)
			{
				int num = this.port;
				int num2 = perm.port;
				TransportType transportType = this.transport;
				TransportType transportType2 = perm.transport;
				if (this.IntersectHostname(perm) == null || (this.hasWildcard && perm.hasWildcard))
				{
					return;
				}
			}
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0002E770 File Offset: 0x0002C970
		private string IntersectHostname(EndpointPermission perm)
		{
			string text5;
			for (;;)
			{
				string text = this.hostname;
				string text2 = perm.hostname;
				bool flag = text == text2;
				string text3 = this.hostname;
				this.Resolve();
				perm.Resolve();
				bool flag2 = this.hasWildcard;
				if (perm.hasWildcard)
				{
					break;
				}
				IPAddress[] array = perm.addresses;
				if (array == null)
				{
					return;
				}
				ushort[] numbers = array._numbers;
				string toString = array._toString;
				string text4 = this.hostname;
				if (text5 == null)
				{
					goto Block_2;
				}
			}
			string text6 = this.hostname;
			string text7 = perm.hostname;
			return perm.Intersect(text6, text7);
			Block_2:
			IPAddress[] array2 = perm.addresses;
			return text5;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0002E880 File Offset: 0x0002CA80
		private string Intersect(string addr1, string addr2)
		{
			if (!true)
			{
			}
			if ("*" == null)
			{
				int num;
				string text = num.ToString();
				string text2;
				if (text2 == null)
				{
					return text2;
				}
			}
			string text3;
			if (text3 == null)
			{
				return text3;
			}
			if ("." != null && ("." == null || "." == null || "." == null))
			{
				throw new ArrayTypeMismatchException();
			}
			string text4;
			return text4;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0002E8E8 File Offset: 0x0002CAE8
		private int ToNumber(string value)
		{
			bool flag = value == "*";
			return 256;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0002E924 File Offset: 0x0002CB24
		internal void Resolve()
		{
			bool flag = this.resolved;
			if (!flag)
			{
				string text = this.hostname;
				if (!flag)
				{
				}
				return;
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0002E99C File Offset: 0x0002CB9C
		internal void UndoResolve()
		{
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0002E9AC File Offset: 0x0002CBAC
		// Note: this type is marked as 'beforefieldinit'.
		static EndpointPermission()
		{
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0002E9BC File Offset: 0x0002CBBC
		internal EndpointPermission()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000BE2 RID: 3042
		private static char[] dot_char;

		// Token: 0x04000BE3 RID: 3043
		private string hostname;

		// Token: 0x04000BE4 RID: 3044
		private int port;

		// Token: 0x04000BE5 RID: 3045
		private TransportType transport;

		// Token: 0x04000BE6 RID: 3046
		private bool resolved;

		// Token: 0x04000BE7 RID: 3047
		private bool hasWildcard;

		// Token: 0x04000BE8 RID: 3048
		private IPAddress[] addresses;
	}
}
