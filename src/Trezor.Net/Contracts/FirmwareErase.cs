// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-bootloader.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace Trezor.Net.Contracts.Bootloader
{

    [ProtoBuf.ProtoContract()]
    public class FirmwareErase : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"length")]
        public uint Length
        {
            get { return __pbn__Length.GetValueOrDefault(); }
            set { __pbn__Length = value; }
        }
        public bool ShouldSerializeLength() => __pbn__Length != null;
        public void ResetLength() => __pbn__Length = null;
        private uint? __pbn__Length;

    }
}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
