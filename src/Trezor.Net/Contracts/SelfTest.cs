namespace Trezor.Net.Contracts.Bootloader
{
    [ProtoBuf.ProtoContract()]
    public class SelfTest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"payload")]
        public byte[] Payload
        {
            get { return __pbn__Payload; }
            set { __pbn__Payload = value; }
        }
        public bool ShouldSerializePayload() => __pbn__Payload != null;
        public void ResetPayload() => __pbn__Payload = null;
        private byte[] __pbn__Payload;

    }
}