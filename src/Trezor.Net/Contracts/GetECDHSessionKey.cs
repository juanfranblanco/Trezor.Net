namespace Trezor.Net.Contracts.Crypto
{
    [ProtoBuf.ProtoContract()]
    public class GetECDHSessionKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"identity")]
        public IdentityType Identity { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"peer_public_key")]
        public byte[] PeerPublicKey
        {
            get { return __pbn__PeerPublicKey; }
            set { __pbn__PeerPublicKey = value; }
        }
        public bool ShouldSerializePeerPublicKey() => __pbn__PeerPublicKey != null;
        public void ResetPeerPublicKey() => __pbn__PeerPublicKey = null;
        private byte[] __pbn__PeerPublicKey;

        [ProtoBuf.ProtoMember(3, Name = @"ecdsa_curve_name")]
        [System.ComponentModel.DefaultValue("")]
        public string EcdsaCurveName
        {
            get { return __pbn__EcdsaCurveName ?? ""; }
            set { __pbn__EcdsaCurveName = value; }
        }
        public bool ShouldSerializeEcdsaCurveName() => __pbn__EcdsaCurveName != null;
        public void ResetEcdsaCurveName() => __pbn__EcdsaCurveName = null;
        private string __pbn__EcdsaCurveName;

    }
}