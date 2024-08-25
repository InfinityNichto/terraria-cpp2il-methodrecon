using System;
using System.IO;
using System.Text;

// Token: 0x02000055 RID: 85
public class CSVWriter
{
	// Token: 0x060001CE RID: 462 RVA: 0x00005530 File Offset: 0x00003730
	public CSVWriter(string file, string[] headers)
	{
		bool flag = File.Exists(file);
		File.SetAttributes(file, FileAttributes.Normal);
		File.Delete(file);
		this._outputFile = file;
		this.SetupStreams();
		this.WriteLine(headers);
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00005570 File Offset: 0x00003770
	public CSVWriter(string file, string[] headers, UTF8Encoding enc)
	{
		bool flag = File.Exists(file);
		File.SetAttributes(file, FileAttributes.Normal);
		File.Delete(file);
		this._outputFile = file;
		this.SetupStreams(enc);
		this.WriteLine(headers);
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x000055B0 File Offset: 0x000037B0
	public CSVWriter(string[] headers)
	{
		this.SetupStreams();
		this.WriteLine(headers);
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x000055D0 File Offset: 0x000037D0
	private void SetupStreams()
	{
		this._open = true;
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x000055E4 File Offset: 0x000037E4
	private void SetupStreams(UTF8Encoding enc)
	{
		this._open = true;
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x000055F8 File Offset: 0x000037F8
	private void CloseStreams()
	{
		if (this._open)
		{
			StreamWriter writer = this._writer;
			MemoryStream memoryStream = this._memoryStream;
			StreamWriter writer2 = this._writer;
			this.SaveData = memoryStream;
			string outputFile = this._outputFile;
			if (outputFile != null)
			{
				byte[] saveData = this.SaveData;
				File.WriteAllBytes(outputFile, saveData);
				return;
			}
		}
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00005644 File Offset: 0x00003844
	protected override void Finalize()
	{
		this.CloseStreams();
		base.Finalize();
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00005680 File Offset: 0x00003880
	private string EncodeValue(string stringValue)
	{
		string text = stringValue.Replace("\"", "\"\"");
		return "\"" + text + "\"";
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x000056B0 File Offset: 0x000038B0
	public void WriteLine(string[] values)
	{
		string text2;
		string text = "" + text2 + ",";
		StreamWriter writer = this._writer;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x000056E0 File Offset: 0x000038E0
	public void Close()
	{
		this.CloseStreams();
	}

	// Token: 0x0400013A RID: 314
	public byte[] SaveData;

	// Token: 0x0400013B RID: 315
	private string _outputFile;

	// Token: 0x0400013C RID: 316
	private bool _open;

	// Token: 0x0400013D RID: 317
	private StreamWriter _writer;

	// Token: 0x0400013E RID: 318
	private MemoryStream _memoryStream;
}
