// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.getBotCallbackAnswer.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesBotCallbackAnswer"/>
	/// </summary>
	public partial class TLMessagesGetBotCallbackAnswer : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Game = (1 << 1),
			Data = (1 << 0),
		}

		public bool IsGame { get { return Flags.HasFlag(Flag.Game); } set { Flags = value ? (Flags | Flag.Game) : (Flags & ~Flag.Game); } }
		public bool HasData { get { return Flags.HasFlag(Flag.Data); } set { Flags = value ? (Flags | Flag.Data) : (Flags & ~Flag.Data); } }

		public Flag Flags { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public Int32 MsgId { get; set; }
		public Byte[] Data { get; set; }

		public TLMessagesGetBotCallbackAnswer() { }
		public TLMessagesGetBotCallbackAnswer(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetBotCallbackAnswer; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			MsgId = from.ReadInt32();
			if (HasData) Data = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x810A9FEC);
			to.Write((Int32)Flags);
			to.WriteObject(Peer);
			to.Write(MsgId);
			if (HasData) to.WriteByteArray(Data);
		}

		private void UpdateFlags()
		{
			HasData = Data != null;
		}
	}
}