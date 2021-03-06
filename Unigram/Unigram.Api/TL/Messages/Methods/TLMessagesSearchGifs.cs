// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.searchGifs.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesFoundGifs"/>
	/// </summary>
	public partial class TLMessagesSearchGifs : TLObject
	{
		public String Q { get; set; }
		public Int32 Offset { get; set; }

		public TLMessagesSearchGifs() { }
		public TLMessagesSearchGifs(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSearchGifs; } }

		public override void Read(TLBinaryReader from)
		{
			Q = from.ReadString();
			Offset = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xBF9A776B);
			to.Write(Q);
			to.Write(Offset);
		}
	}
}