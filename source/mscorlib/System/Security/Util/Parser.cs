using System;

namespace System.Security.Util
{
	// Token: 0x0200029E RID: 670
	internal sealed class Parser
	{
		// Token: 0x06001722 RID: 5922 RVA: 0x00030DB0 File Offset: 0x0002EFB0
		internal SecurityElement GetTopElement()
		{
			SecurityDocument doc = this._doc;
			SecurityElement securityElement;
			return securityElement;
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00030DC8 File Offset: 0x0002EFC8
		private void GetRequiredSizes(TokenizerStream stream, int index)
		{
			TokenizerShortBlock currentTokens = stream.m_currentTokens;
			int indexTokens = stream.m_indexTokens;
			short[] block = currentTokens.m_block;
			stream.m_lastTokens = currentTokens;
			TokenizerShortBlock next = currentTokens.m_next;
			stream.m_currentTokens = next;
			short[] block2 = next.m_block;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000311F0 File Offset: 0x0002F3F0
		private int DetermineFormat(TokenizerStream stream)
		{
			TokenizerShortBlock currentTokens = stream.m_currentTokens;
			int indexTokens = stream.m_indexTokens;
			short[] block = currentTokens.m_block;
			stream.m_lastTokens = currentTokens;
			TokenizerShortBlock next = currentTokens.m_next;
			long num = 0L;
			stream.m_currentTokens = next;
			short[] block2 = next.m_block;
			if (num == 0L)
			{
				stream.m_lastTokens = next;
				TokenizerShortBlock next2 = next.m_next;
				stream.m_currentTokens = next2;
				short[] block3 = next2.m_block;
				stream.m_indexTokens = next2;
				Tokenizer t = this._t;
				int num2 = 2;
				stream.GoToPosition(num2);
				TokenizerShortBlock currentTokens2 = stream.m_currentTokens;
				int indexTokens2 = stream.m_indexTokens;
				short[] block4 = currentTokens2.m_block;
				stream.m_lastTokens = currentTokens2;
				TokenizerShortBlock next3 = currentTokens2.m_next;
				stream.m_currentTokens = next3;
				short[] block5 = next3.m_block;
				stream.m_indexTokens = block3;
				TokenizerStringBlock currentStrings = stream.m_currentStrings;
				int indexStrings = stream.m_indexStrings;
				string[] block6 = currentStrings.m_block;
				TokenizerStringBlock next4 = currentStrings.m_next;
				long num3 = 0L;
				stream.m_currentStrings = next4;
				stream.m_indexStrings = (int)num3;
				TokenizerStringBlock next5 = currentStrings.m_next;
				stream.m_currentStrings = next5;
				string[] block7 = next5.m_block;
				stream.m_indexStrings = next5;
				TokenizerShortBlock currentTokens3 = stream.m_currentTokens;
				int indexTokens3 = stream.m_indexTokens;
				short[] block8 = currentTokens3.m_block;
				stream.m_lastTokens = currentTokens3;
				TokenizerShortBlock next6 = currentTokens3.m_next;
				long num4 = 0L;
				stream.m_currentTokens = next6;
				short[] block9 = next6.m_block;
				stream.m_indexTokens = (int)num4;
				int num5;
				return num5;
			}
			return 2;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x000313B8 File Offset: 0x0002F5B8
		private void ParseContents()
		{
			Tokenizer t = this._t;
			int num = 2;
			Tokenizer t2 = this._t;
			this._doc = -1073741824;
			this._doc.AppendString(" ", num);
			this._doc.AppendString(" ", num);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x000314C8 File Offset: 0x0002F6C8
		private Parser(Tokenizer t)
		{
			this._t = t;
			this.ParseContents();
			this._t.Recycle();
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00031520 File Offset: 0x0002F720
		internal Parser(string input)
		{
			int stringLength = input._stringLength;
		}

		// Token: 0x04000BB2 RID: 2994
		private SecurityDocument _doc;

		// Token: 0x04000BB3 RID: 2995
		private Tokenizer _t;
	}
}
