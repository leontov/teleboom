// <auto-generated/>
using System;
using Telegram.Api.TL.Storage;

namespace Telegram.Api.TL.Upload
{
	public partial class TLUploadFile : TLUploadFileBase 
	{
		public TLStorageFileTypeBase Type { get; set; }
		public Int32 Mtime { get; set; }
		public Byte[] Bytes { get; set; }

		public TLUploadFile() { }
		public TLUploadFile(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UploadFile; } }

		public override void Read(TLBinaryReader from)
		{
			Type = TLFactory.Read<TLStorageFileTypeBase>(from);
			Mtime = from.ReadInt32();
			Bytes = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x96A18D5);
			to.WriteObject(Type);
			to.Write(Mtime);
			to.WriteByteArray(Bytes);
		}
	}
}