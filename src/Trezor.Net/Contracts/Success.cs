// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-common.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace Trezor.Net.Contracts.Common
{

    [ProtoBuf.ProtoContract()]
    public class Success : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"message")]
        [System.ComponentModel.DefaultValue("")]
        public string Message
        {
            get { return __pbn__Message ?? ""; }
            set { __pbn__Message = value; }
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private string __pbn__Message;

    }
}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
