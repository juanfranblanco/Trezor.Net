namespace Trezor.Net.Contracts.Ethereum
{
    [ProtoBuf.ProtoContract()]
    public class EthereumTxRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"data_length")]
        public uint DataLength
        {
            get { return __pbn__DataLength.GetValueOrDefault(); }
            set { __pbn__DataLength = value; }
        }
        public bool ShouldSerializeDataLength() => __pbn__DataLength != null;
        public void ResetDataLength() => __pbn__DataLength = null;
        private uint? __pbn__DataLength;

        [ProtoBuf.ProtoMember(2, Name = @"signature_v")]
        public uint SignatureV
        {
            get { return __pbn__SignatureV.GetValueOrDefault(); }
            set { __pbn__SignatureV = value; }
        }
        public bool ShouldSerializeSignatureV() => __pbn__SignatureV != null;
        public void ResetSignatureV() => __pbn__SignatureV = null;
        private uint? __pbn__SignatureV;

        [ProtoBuf.ProtoMember(3, Name = @"signature_r")]
        public byte[] SignatureR
        {
            get { return __pbn__SignatureR; }
            set { __pbn__SignatureR = value; }
        }
        public bool ShouldSerializeSignatureR() => __pbn__SignatureR != null;
        public void ResetSignatureR() => __pbn__SignatureR = null;
        private byte[] __pbn__SignatureR;

        [ProtoBuf.ProtoMember(4, Name = @"signature_s")]
        public byte[] SignatureS
        {
            get { return __pbn__SignatureS; }
            set { __pbn__SignatureS = value; }
        }
        public bool ShouldSerializeSignatureS() => __pbn__SignatureS != null;
        public void ResetSignatureS() => __pbn__SignatureS = null;
        private byte[] __pbn__SignatureS;

    }
}