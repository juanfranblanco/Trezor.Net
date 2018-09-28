// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-ontology.proto

namespace Trezor.Net.Contracts.Ontology
{

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
[global::ProtoBuf.ProtoContract()]
public partial class OntologyTransaction : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"version")]
    public uint Version
    {
        get => __pbn__Version.GetValueOrDefault();
        set => __pbn__Version = value;
    }
    public bool ShouldSerializeVersion()
    {
        return __pbn__Version != null;
    }

    public void ResetVersion()
    {
        __pbn__Version = null;
    }

    private uint? __pbn__Version;

    [global::ProtoBuf.ProtoMember(2, Name = @"type")]
    public uint Type
    {
        get => __pbn__Type.GetValueOrDefault();
        set => __pbn__Type = value;
    }
    public bool ShouldSerializeType()
    {
        return __pbn__Type != null;
    }

    public void ResetType()
    {
        __pbn__Type = null;
    }

    private uint? __pbn__Type;

    [global::ProtoBuf.ProtoMember(3, Name = @"nonce")]
    public uint Nonce
    {
        get => __pbn__Nonce.GetValueOrDefault();
        set => __pbn__Nonce = value;
    }
    public bool ShouldSerializeNonce()
    {
        return __pbn__Nonce != null;
    }

    public void ResetNonce()
    {
        __pbn__Nonce = null;
    }

    private uint? __pbn__Nonce;

    [global::ProtoBuf.ProtoMember(4, Name = @"gas_price")]
    public ulong GasPrice
    {
        get => __pbn__GasPrice.GetValueOrDefault();
        set => __pbn__GasPrice = value;
    }
    public bool ShouldSerializeGasPrice()
    {
        return __pbn__GasPrice != null;
    }

    public void ResetGasPrice()
    {
        __pbn__GasPrice = null;
    }

    private ulong? __pbn__GasPrice;

    [global::ProtoBuf.ProtoMember(5, Name = @"gas_limit")]
    public ulong GasLimit
    {
        get => __pbn__GasLimit.GetValueOrDefault();
        set => __pbn__GasLimit = value;
    }
    public bool ShouldSerializeGasLimit()
    {
        return __pbn__GasLimit != null;
    }

    public void ResetGasLimit()
    {
        __pbn__GasLimit = null;
    }

    private ulong? __pbn__GasLimit;

    [global::ProtoBuf.ProtoMember(6, Name = @"payer")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Payer
    {
        get => __pbn__Payer ?? "";
        set => __pbn__Payer = value;
    }
    public bool ShouldSerializePayer()
    {
        return __pbn__Payer != null;
    }

    public void ResetPayer()
    {
        __pbn__Payer = null;
    }

    private string __pbn__Payer;

    [global::ProtoBuf.ProtoMember(7, Name = @"tx_attributes")]
    public global::System.Collections.Generic.List<OntologyTxAttribute> TxAttributes { get; } = new global::System.Collections.Generic.List<OntologyTxAttribute>();

    [global::ProtoBuf.ProtoContract()]
    public partial class OntologyTxAttribute : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"usage")]
        public uint Usage
        {
            get => __pbn__Usage.GetValueOrDefault();
            set => __pbn__Usage = value;
        }
        public bool ShouldSerializeUsage()
        {
            return __pbn__Usage != null;
        }

        public void ResetUsage()
        {
            __pbn__Usage = null;
        }

        private uint? __pbn__Usage;

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data
        {
            get => __pbn__Data;
            set => __pbn__Data = value;
        }
        public bool ShouldSerializeData()
        {
            return __pbn__Data != null;
        }

        public void ResetData()
        {
            __pbn__Data = null;
        }

        private byte[] __pbn__Data;

    }

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologyGetPublicKey : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
    public uint[] AddressNs { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"show_display")]
    public bool ShowDisplay
    {
        get => __pbn__ShowDisplay.GetValueOrDefault();
        set => __pbn__ShowDisplay = value;
    }
    public bool ShouldSerializeShowDisplay()
    {
        return __pbn__ShowDisplay != null;
    }

    public void ResetShowDisplay()
    {
        __pbn__ShowDisplay = null;
    }

    private bool? __pbn__ShowDisplay;

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologyPublicKey : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"public_key")]
    public byte[] PublicKey
    {
        get => __pbn__PublicKey;
        set => __pbn__PublicKey = value;
    }
    public bool ShouldSerializePublicKey()
    {
        return __pbn__PublicKey != null;
    }

    public void ResetPublicKey()
    {
        __pbn__PublicKey = null;
    }

    private byte[] __pbn__PublicKey;

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologyGetAddress : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
    public uint[] AddressNs { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"show_display")]
    public bool ShowDisplay
    {
        get => __pbn__ShowDisplay.GetValueOrDefault();
        set => __pbn__ShowDisplay = value;
    }
    public bool ShouldSerializeShowDisplay()
    {
        return __pbn__ShowDisplay != null;
    }

    public void ResetShowDisplay()
    {
        __pbn__ShowDisplay = null;
    }

    private bool? __pbn__ShowDisplay;

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologyAddress : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"address")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Address
    {
        get => __pbn__Address ?? "";
        set => __pbn__Address = value;
    }
    public bool ShouldSerializeAddress()
    {
        return __pbn__Address != null;
    }

    public void ResetAddress()
    {
        __pbn__Address = null;
    }

    private string __pbn__Address;

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologySignTransfer : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
    public uint[] AddressNs { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"transaction")]
    public OntologyTransaction Transaction { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"transfer")]
    public OntologyTransfer Transfer { get; set; }

    [global::ProtoBuf.ProtoContract()]
    public partial class OntologyTransfer : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"asset")]
        [global::System.ComponentModel.DefaultValue(OntologyAsset.Ont)]
        public OntologyAsset Asset
        {
            get => __pbn__Asset ?? OntologyAsset.Ont;
            set => __pbn__Asset = value;
        }
        public bool ShouldSerializeAsset()
        {
            return __pbn__Asset != null;
        }

        public void ResetAsset()
        {
            __pbn__Asset = null;
        }

        private OntologyAsset? __pbn__Asset;

        [global::ProtoBuf.ProtoMember(2, Name = @"amount")]
        public ulong Amount
        {
            get => __pbn__Amount.GetValueOrDefault();
            set => __pbn__Amount = value;
        }
        public bool ShouldSerializeAmount()
        {
            return __pbn__Amount != null;
        }

        public void ResetAmount()
        {
            __pbn__Amount = null;
        }

        private ulong? __pbn__Amount;

        [global::ProtoBuf.ProtoMember(3, Name = @"from_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FromAddress
        {
            get => __pbn__FromAddress ?? "";
            set => __pbn__FromAddress = value;
        }
        public bool ShouldSerializeFromAddress()
        {
            return __pbn__FromAddress != null;
        }

        public void ResetFromAddress()
        {
            __pbn__FromAddress = null;
        }

        private string __pbn__FromAddress;

        [global::ProtoBuf.ProtoMember(4, Name = @"to_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ToAddress
        {
            get => __pbn__ToAddress ?? "";
            set => __pbn__ToAddress = value;
        }
        public bool ShouldSerializeToAddress()
        {
            return __pbn__ToAddress != null;
        }

        public void ResetToAddress()
        {
            __pbn__ToAddress = null;
        }

        private string __pbn__ToAddress;

        [global::ProtoBuf.ProtoContract()]
        public enum OntologyAsset
        {
            [global::ProtoBuf.ProtoEnum(Name = @"ONT")]
            Ont = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"ONG")]
            Ong = 2,
        }

    }

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologySignedTransfer : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
    public byte[] Signature
    {
        get => __pbn__Signature;
        set => __pbn__Signature = value;
    }
    public bool ShouldSerializeSignature()
    {
        return __pbn__Signature != null;
    }

    public void ResetSignature()
    {
        __pbn__Signature = null;
    }

    private byte[] __pbn__Signature;

    [global::ProtoBuf.ProtoMember(2, Name = @"payload")]
    public byte[] Payload
    {
        get => __pbn__Payload;
        set => __pbn__Payload = value;
    }
    public bool ShouldSerializePayload()
    {
        return __pbn__Payload != null;
    }

    public void ResetPayload()
    {
        __pbn__Payload = null;
    }

    private byte[] __pbn__Payload;

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologySignWithdrawOng : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
    public uint[] AddressNs { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"transaction")]
    public OntologyTransaction Transaction { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"withdraw_ong")]
    public OntologyWithdrawOng WithdrawOng { get; set; }

    [global::ProtoBuf.ProtoContract()]
    public partial class OntologyWithdrawOng : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"amount")]
        public ulong Amount
        {
            get => __pbn__Amount.GetValueOrDefault();
            set => __pbn__Amount = value;
        }
        public bool ShouldSerializeAmount()
        {
            return __pbn__Amount != null;
        }

        public void ResetAmount()
        {
            __pbn__Amount = null;
        }

        private ulong? __pbn__Amount;

        [global::ProtoBuf.ProtoMember(2, Name = @"from_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string FromAddress
        {
            get => __pbn__FromAddress ?? "";
            set => __pbn__FromAddress = value;
        }
        public bool ShouldSerializeFromAddress()
        {
            return __pbn__FromAddress != null;
        }

        public void ResetFromAddress()
        {
            __pbn__FromAddress = null;
        }

        private string __pbn__FromAddress;

        [global::ProtoBuf.ProtoMember(3, Name = @"to_address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ToAddress
        {
            get => __pbn__ToAddress ?? "";
            set => __pbn__ToAddress = value;
        }
        public bool ShouldSerializeToAddress()
        {
            return __pbn__ToAddress != null;
        }

        public void ResetToAddress()
        {
            __pbn__ToAddress = null;
        }

        private string __pbn__ToAddress;

    }

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologySignedWithdrawOng : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
    public byte[] Signature
    {
        get => __pbn__Signature;
        set => __pbn__Signature = value;
    }
    public bool ShouldSerializeSignature()
    {
        return __pbn__Signature != null;
    }

    public void ResetSignature()
    {
        __pbn__Signature = null;
    }

    private byte[] __pbn__Signature;

    [global::ProtoBuf.ProtoMember(2, Name = @"payload")]
    public byte[] Payload
    {
        get => __pbn__Payload;
        set => __pbn__Payload = value;
    }
    public bool ShouldSerializePayload()
    {
        return __pbn__Payload != null;
    }

    public void ResetPayload()
    {
        __pbn__Payload = null;
    }

    private byte[] __pbn__Payload;

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologySignOntIdRegister : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
    public uint[] AddressNs { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"transaction")]
    public OntologyTransaction Transaction { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"ont_id_register")]
    public OntologyOntIdRegister OntIdRegister { get; set; }

    [global::ProtoBuf.ProtoContract()]
    public partial class OntologyOntIdRegister : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"ont_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string OntId
        {
            get => __pbn__OntId ?? "";
            set => __pbn__OntId = value;
        }
        public bool ShouldSerializeOntId()
        {
            return __pbn__OntId != null;
        }

        public void ResetOntId()
        {
            __pbn__OntId = null;
        }

        private string __pbn__OntId;

        [global::ProtoBuf.ProtoMember(2, Name = @"public_key")]
        public byte[] PublicKey
        {
            get => __pbn__PublicKey;
            set => __pbn__PublicKey = value;
        }
        public bool ShouldSerializePublicKey()
        {
            return __pbn__PublicKey != null;
        }

        public void ResetPublicKey()
        {
            __pbn__PublicKey = null;
        }

        private byte[] __pbn__PublicKey;

    }

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologySignedOntIdRegister : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
    public byte[] Signature
    {
        get => __pbn__Signature;
        set => __pbn__Signature = value;
    }
    public bool ShouldSerializeSignature()
    {
        return __pbn__Signature != null;
    }

    public void ResetSignature()
    {
        __pbn__Signature = null;
    }

    private byte[] __pbn__Signature;

    [global::ProtoBuf.ProtoMember(2, Name = @"payload")]
    public byte[] Payload
    {
        get => __pbn__Payload;
        set => __pbn__Payload = value;
    }
    public bool ShouldSerializePayload()
    {
        return __pbn__Payload != null;
    }

    public void ResetPayload()
    {
        __pbn__Payload = null;
    }

    private byte[] __pbn__Payload;

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologySignOntIdAddAttributes : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
    public uint[] AddressNs { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"transaction")]
    public OntologyTransaction Transaction { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"ont_id_add_attributes")]
    public OntologyOntIdAddAttributes OntIdAddAttributes { get; set; }

    [global::ProtoBuf.ProtoContract()]
    public partial class OntologyOntIdAddAttributes : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"ont_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string OntId
        {
            get => __pbn__OntId ?? "";
            set => __pbn__OntId = value;
        }
        public bool ShouldSerializeOntId()
        {
            return __pbn__OntId != null;
        }

        public void ResetOntId()
        {
            __pbn__OntId = null;
        }

        private string __pbn__OntId;

        [global::ProtoBuf.ProtoMember(2, Name = @"public_key")]
        public byte[] PublicKey
        {
            get => __pbn__PublicKey;
            set => __pbn__PublicKey = value;
        }
        public bool ShouldSerializePublicKey()
        {
            return __pbn__PublicKey != null;
        }

        public void ResetPublicKey()
        {
            __pbn__PublicKey = null;
        }

        private byte[] __pbn__PublicKey;

        [global::ProtoBuf.ProtoMember(3, Name = @"ont_id_attributes")]
        public global::System.Collections.Generic.List<OntologyOntIdAttribute> OntIdAttributes { get; } = new global::System.Collections.Generic.List<OntologyOntIdAttribute>();

        [global::ProtoBuf.ProtoContract()]
        public partial class OntologyOntIdAttribute : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }

            [global::ProtoBuf.ProtoMember(1, Name = @"key")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Key
            {
                get => __pbn__Key ?? "";
                set => __pbn__Key = value;
            }
            public bool ShouldSerializeKey()
            {
                return __pbn__Key != null;
            }

            public void ResetKey()
            {
                __pbn__Key = null;
            }

            private string __pbn__Key;

            [global::ProtoBuf.ProtoMember(2, Name = @"type")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Type
            {
                get => __pbn__Type ?? "";
                set => __pbn__Type = value;
            }
            public bool ShouldSerializeType()
            {
                return __pbn__Type != null;
            }

            public void ResetType()
            {
                __pbn__Type = null;
            }

            private string __pbn__Type;

            [global::ProtoBuf.ProtoMember(3, Name = @"value")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Value
            {
                get => __pbn__Value ?? "";
                set => __pbn__Value = value;
            }
            public bool ShouldSerializeValue()
            {
                return __pbn__Value != null;
            }

            public void ResetValue()
            {
                __pbn__Value = null;
            }

            private string __pbn__Value;

        }

    }

}

[global::ProtoBuf.ProtoContract()]
public partial class OntologySignedOntIdAddAttributes : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
    {
        return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
    }

    [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
    public byte[] Signature
    {
        get => __pbn__Signature;
        set => __pbn__Signature = value;
    }
    public bool ShouldSerializeSignature()
    {
        return __pbn__Signature != null;
    }

    public void ResetSignature()
    {
        __pbn__Signature = null;
    }

    private byte[] __pbn__Signature;

    [global::ProtoBuf.ProtoMember(2, Name = @"payload")]
    public byte[] Payload
    {
        get => __pbn__Payload;
        set => __pbn__Payload = value;
    }
    public bool ShouldSerializePayload()
    {
        return __pbn__Payload != null;
    }

    public void ResetPayload()
    {
        __pbn__Payload = null;
    }

    private byte[] __pbn__Payload;

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
}
