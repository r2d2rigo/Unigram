// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAuthCodeTypeCall : TLAuthCodeTypeBase 
	{
		public TLAuthCodeTypeCall() { }
		public TLAuthCodeTypeCall(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthCodeTypeCall; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x741CD3E3);
		}
	}
}