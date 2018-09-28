// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-tezos.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace Trezor.Net.Contracts.Tezos
{

    [global::ProtoBuf.ProtoContract()]
    public partial class TezosGetAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"show_display")]
        public bool ShowDisplay
        {
            get { return __pbn__ShowDisplay.GetValueOrDefault(); }
            set { __pbn__ShowDisplay = value; }
        }
        public bool ShouldSerializeShowDisplay() => __pbn__ShowDisplay != null;
        public void ResetShowDisplay() => __pbn__ShowDisplay = null;
        private bool? __pbn__ShowDisplay;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TezosAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address
        {
            get { return __pbn__Address ?? ""; }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private string __pbn__Address;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TezosGetPublicKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"show_display")]
        public bool ShowDisplay
        {
            get { return __pbn__ShowDisplay.GetValueOrDefault(); }
            set { __pbn__ShowDisplay = value; }
        }
        public bool ShouldSerializeShowDisplay() => __pbn__ShowDisplay != null;
        public void ResetShowDisplay() => __pbn__ShowDisplay = null;
        private bool? __pbn__ShowDisplay;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TezosPublicKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"public_key")]
        [global::System.ComponentModel.DefaultValue("")]
        public string PublicKey
        {
            get { return __pbn__PublicKey ?? ""; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private string __pbn__PublicKey;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TezosSignTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"branch")]
        public byte[] Branch
        {
            get { return __pbn__Branch; }
            set { __pbn__Branch = value; }
        }
        public bool ShouldSerializeBranch() => __pbn__Branch != null;
        public void ResetBranch() => __pbn__Branch = null;
        private byte[] __pbn__Branch;

        [global::ProtoBuf.ProtoMember(3, Name = @"reveal")]
        public TezosRevealOp Reveal { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"transaction")]
        public TezosTransactionOp Transaction { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"origination")]
        public TezosOriginationOp Origination { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"delegation")]
        public TezosDelegationOp Delegation { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class TezosContractID : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"tag")]
            [global::System.ComponentModel.DefaultValue(TezosContractType.Implicit)]
            public TezosContractType Tag
            {
                get { return __pbn__Tag ?? TezosContractType.Implicit; }
                set { __pbn__Tag = value; }
            }
            public bool ShouldSerializeTag() => __pbn__Tag != null;
            public void ResetTag() => __pbn__Tag = null;
            private TezosContractType? __pbn__Tag;

            [global::ProtoBuf.ProtoMember(2, Name = @"hash")]
            public byte[] Hash
            {
                get { return __pbn__Hash; }
                set { __pbn__Hash = value; }
            }
            public bool ShouldSerializeHash() => __pbn__Hash != null;
            public void ResetHash() => __pbn__Hash = null;
            private byte[] __pbn__Hash;

            [global::ProtoBuf.ProtoContract()]
            public enum TezosContractType
            {
                Implicit = 0,
                Originated = 1,
            }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class TezosRevealOp : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"source")]
            public TezosSignTx.TezosContractID Source { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [global::ProtoBuf.ProtoMember(3, Name = @"counter")]
            public ulong Counter
            {
                get { return __pbn__Counter.GetValueOrDefault(); }
                set { __pbn__Counter = value; }
            }
            public bool ShouldSerializeCounter() => __pbn__Counter != null;
            public void ResetCounter() => __pbn__Counter = null;
            private ulong? __pbn__Counter;

            [global::ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
            public ulong GasLimit
            {
                get { return __pbn__GasLimit.GetValueOrDefault(); }
                set { __pbn__GasLimit = value; }
            }
            public bool ShouldSerializeGasLimit() => __pbn__GasLimit != null;
            public void ResetGasLimit() => __pbn__GasLimit = null;
            private ulong? __pbn__GasLimit;

            [global::ProtoBuf.ProtoMember(5, Name = @"storage_limit")]
            public ulong StorageLimit
            {
                get { return __pbn__StorageLimit.GetValueOrDefault(); }
                set { __pbn__StorageLimit = value; }
            }
            public bool ShouldSerializeStorageLimit() => __pbn__StorageLimit != null;
            public void ResetStorageLimit() => __pbn__StorageLimit = null;
            private ulong? __pbn__StorageLimit;

            [global::ProtoBuf.ProtoMember(6, Name = @"public_key")]
            public byte[] PublicKey
            {
                get { return __pbn__PublicKey; }
                set { __pbn__PublicKey = value; }
            }
            public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
            public void ResetPublicKey() => __pbn__PublicKey = null;
            private byte[] __pbn__PublicKey;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class TezosTransactionOp : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"source")]
            public TezosSignTx.TezosContractID Source { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [global::ProtoBuf.ProtoMember(3, Name = @"counter")]
            public ulong Counter
            {
                get { return __pbn__Counter.GetValueOrDefault(); }
                set { __pbn__Counter = value; }
            }
            public bool ShouldSerializeCounter() => __pbn__Counter != null;
            public void ResetCounter() => __pbn__Counter = null;
            private ulong? __pbn__Counter;

            [global::ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
            public ulong GasLimit
            {
                get { return __pbn__GasLimit.GetValueOrDefault(); }
                set { __pbn__GasLimit = value; }
            }
            public bool ShouldSerializeGasLimit() => __pbn__GasLimit != null;
            public void ResetGasLimit() => __pbn__GasLimit = null;
            private ulong? __pbn__GasLimit;

            [global::ProtoBuf.ProtoMember(5, Name = @"storage_limit")]
            public ulong StorageLimit
            {
                get { return __pbn__StorageLimit.GetValueOrDefault(); }
                set { __pbn__StorageLimit = value; }
            }
            public bool ShouldSerializeStorageLimit() => __pbn__StorageLimit != null;
            public void ResetStorageLimit() => __pbn__StorageLimit = null;
            private ulong? __pbn__StorageLimit;

            [global::ProtoBuf.ProtoMember(6, Name = @"amount")]
            public ulong Amount
            {
                get { return __pbn__Amount.GetValueOrDefault(); }
                set { __pbn__Amount = value; }
            }
            public bool ShouldSerializeAmount() => __pbn__Amount != null;
            public void ResetAmount() => __pbn__Amount = null;
            private ulong? __pbn__Amount;

            [global::ProtoBuf.ProtoMember(7, Name = @"destination")]
            public TezosSignTx.TezosContractID Destination { get; set; }

            [global::ProtoBuf.ProtoMember(8, Name = @"parameters")]
            public byte[] Parameters
            {
                get { return __pbn__Parameters; }
                set { __pbn__Parameters = value; }
            }
            public bool ShouldSerializeParameters() => __pbn__Parameters != null;
            public void ResetParameters() => __pbn__Parameters = null;
            private byte[] __pbn__Parameters;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class TezosOriginationOp : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"source")]
            public TezosSignTx.TezosContractID Source { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [global::ProtoBuf.ProtoMember(3, Name = @"counter")]
            public ulong Counter
            {
                get { return __pbn__Counter.GetValueOrDefault(); }
                set { __pbn__Counter = value; }
            }
            public bool ShouldSerializeCounter() => __pbn__Counter != null;
            public void ResetCounter() => __pbn__Counter = null;
            private ulong? __pbn__Counter;

            [global::ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
            public ulong GasLimit
            {
                get { return __pbn__GasLimit.GetValueOrDefault(); }
                set { __pbn__GasLimit = value; }
            }
            public bool ShouldSerializeGasLimit() => __pbn__GasLimit != null;
            public void ResetGasLimit() => __pbn__GasLimit = null;
            private ulong? __pbn__GasLimit;

            [global::ProtoBuf.ProtoMember(5, Name = @"storage_limit")]
            public ulong StorageLimit
            {
                get { return __pbn__StorageLimit.GetValueOrDefault(); }
                set { __pbn__StorageLimit = value; }
            }
            public bool ShouldSerializeStorageLimit() => __pbn__StorageLimit != null;
            public void ResetStorageLimit() => __pbn__StorageLimit = null;
            private ulong? __pbn__StorageLimit;

            [global::ProtoBuf.ProtoMember(6, Name = @"manager_pubkey")]
            public byte[] ManagerPubkey
            {
                get { return __pbn__ManagerPubkey; }
                set { __pbn__ManagerPubkey = value; }
            }
            public bool ShouldSerializeManagerPubkey() => __pbn__ManagerPubkey != null;
            public void ResetManagerPubkey() => __pbn__ManagerPubkey = null;
            private byte[] __pbn__ManagerPubkey;

            [global::ProtoBuf.ProtoMember(7, Name = @"balance")]
            public ulong Balance
            {
                get { return __pbn__Balance.GetValueOrDefault(); }
                set { __pbn__Balance = value; }
            }
            public bool ShouldSerializeBalance() => __pbn__Balance != null;
            public void ResetBalance() => __pbn__Balance = null;
            private ulong? __pbn__Balance;

            [global::ProtoBuf.ProtoMember(8, Name = @"spendable")]
            public bool Spendable
            {
                get { return __pbn__Spendable.GetValueOrDefault(); }
                set { __pbn__Spendable = value; }
            }
            public bool ShouldSerializeSpendable() => __pbn__Spendable != null;
            public void ResetSpendable() => __pbn__Spendable = null;
            private bool? __pbn__Spendable;

            [global::ProtoBuf.ProtoMember(9, Name = @"delegatable")]
            public bool Delegatable
            {
                get { return __pbn__Delegatable.GetValueOrDefault(); }
                set { __pbn__Delegatable = value; }
            }
            public bool ShouldSerializeDelegatable() => __pbn__Delegatable != null;
            public void ResetDelegatable() => __pbn__Delegatable = null;
            private bool? __pbn__Delegatable;

            [global::ProtoBuf.ProtoMember(10, Name = @"delegate")]
            public byte[] Delegate
            {
                get { return __pbn__Delegate; }
                set { __pbn__Delegate = value; }
            }
            public bool ShouldSerializeDelegate() => __pbn__Delegate != null;
            public void ResetDelegate() => __pbn__Delegate = null;
            private byte[] __pbn__Delegate;

            [global::ProtoBuf.ProtoMember(11, Name = @"script")]
            public byte[] Script
            {
                get { return __pbn__Script; }
                set { __pbn__Script = value; }
            }
            public bool ShouldSerializeScript() => __pbn__Script != null;
            public void ResetScript() => __pbn__Script = null;
            private byte[] __pbn__Script;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class TezosDelegationOp : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"source")]
            public TezosSignTx.TezosContractID Source { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [global::ProtoBuf.ProtoMember(3, Name = @"counter")]
            public ulong Counter
            {
                get { return __pbn__Counter.GetValueOrDefault(); }
                set { __pbn__Counter = value; }
            }
            public bool ShouldSerializeCounter() => __pbn__Counter != null;
            public void ResetCounter() => __pbn__Counter = null;
            private ulong? __pbn__Counter;

            [global::ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
            public ulong GasLimit
            {
                get { return __pbn__GasLimit.GetValueOrDefault(); }
                set { __pbn__GasLimit = value; }
            }
            public bool ShouldSerializeGasLimit() => __pbn__GasLimit != null;
            public void ResetGasLimit() => __pbn__GasLimit = null;
            private ulong? __pbn__GasLimit;

            [global::ProtoBuf.ProtoMember(5, Name = @"storage_limit")]
            public ulong StorageLimit
            {
                get { return __pbn__StorageLimit.GetValueOrDefault(); }
                set { __pbn__StorageLimit = value; }
            }
            public bool ShouldSerializeStorageLimit() => __pbn__StorageLimit != null;
            public void ResetStorageLimit() => __pbn__StorageLimit = null;
            private ulong? __pbn__StorageLimit;

            [global::ProtoBuf.ProtoMember(6, Name = @"delegate")]
            public byte[] Delegate
            {
                get { return __pbn__Delegate; }
                set { __pbn__Delegate = value; }
            }
            public bool ShouldSerializeDelegate() => __pbn__Delegate != null;
            public void ResetDelegate() => __pbn__Delegate = null;
            private byte[] __pbn__Delegate;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TezosSignedTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signature
        {
            get { return __pbn__Signature ?? ""; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private string __pbn__Signature;

        [global::ProtoBuf.ProtoMember(2, Name = @"sig_op_contents")]
        public byte[] SigOpContents
        {
            get { return __pbn__SigOpContents; }
            set { __pbn__SigOpContents = value; }
        }
        public bool ShouldSerializeSigOpContents() => __pbn__SigOpContents != null;
        public void ResetSigOpContents() => __pbn__SigOpContents = null;
        private byte[] __pbn__SigOpContents;

        [global::ProtoBuf.ProtoMember(3, Name = @"operation_hash")]
        [global::System.ComponentModel.DefaultValue("")]
        public string OperationHash
        {
            get { return __pbn__OperationHash ?? ""; }
            set { __pbn__OperationHash = value; }
        }
        public bool ShouldSerializeOperationHash() => __pbn__OperationHash != null;
        public void ResetOperationHash() => __pbn__OperationHash = null;
        private string __pbn__OperationHash;

    }

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
