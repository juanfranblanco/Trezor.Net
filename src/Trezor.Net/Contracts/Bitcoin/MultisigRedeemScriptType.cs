// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-bitcoin.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace Trezor.Net.Contracts.Bitcoin
{

    [ProtoBuf.ProtoContract()]
    public class MultisigRedeemScriptType : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"pubkeys")]
        public System.Collections.Generic.List<HDNodePathType> Pubkeys { get; } = new System.Collections.Generic.List<HDNodePathType>();

        [ProtoBuf.ProtoMember(2, Name = @"signatures")]
        public System.Collections.Generic.List<byte[]> Signatures { get; } = new System.Collections.Generic.List<byte[]>();

        [ProtoBuf.ProtoMember(3, Name = @"m")]
        public uint M
        {
            get => __pbn__M.GetValueOrDefault();
            set => __pbn__M = value;
        }
        public bool ShouldSerializeM() => __pbn__M != null;
        public void ResetM() => __pbn__M = null;
        private uint? __pbn__M;

        [ProtoBuf.ProtoContract()]
        public class HDNodePathType : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"node", IsRequired = true)]
            public Common.HDNodeType Node { get; set; }

            [ProtoBuf.ProtoMember(2, Name = @"address_n")]
            public uint[] AddressNs { get; set; }

        }

    }
}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
