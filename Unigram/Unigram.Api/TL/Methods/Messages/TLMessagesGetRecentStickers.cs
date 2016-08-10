// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getRecentStickers
	/// </summary>
	public partial class TLMessagesGetRecentStickers : TLObject
	{
		public Int32 Hash { get; set; }

		public TLMessagesGetRecentStickers() { }
		public TLMessagesGetRecentStickers(TLBinaryReader from, TLType type = TLType.MessagesGetRecentStickers)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesGetRecentStickers; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesGetRecentStickers)
		{
			Hash = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x99197C2C);
			to.Write(Hash);
		}
	}
}