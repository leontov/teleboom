// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getFeaturedStickers
	/// </summary>
	public partial class TLMessagesGetFeaturedStickers : TLObject
	{
		public Int32 Hash { get; set; }

		public TLMessagesGetFeaturedStickers() { }
		public TLMessagesGetFeaturedStickers(TLBinaryReader from, TLType type = TLType.MessagesGetFeaturedStickers)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesGetFeaturedStickers; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesGetFeaturedStickers)
		{
			Hash = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2DACCA4F);
			to.Write(Hash);
		}
	}
}