using Hid.Net;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.RLP;
using Nethereum.Signer;
using Trezor.Net;
using Trezor.Net.Contracts;
using Trezor.Net.Contracts.Ethereum;

namespace TrezorTestApp
{
    class Program
    {
        #region Fields
        private static readonly string[] _Addresses = new string[50];
        #endregion

        #region Main
        static void Main(string[] args)
        {
            try
            {
                Go();
                while (true) ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
        #endregion

        #region Private  Methods
        private static async Task<IHidDevice> Connect()
        {
            DeviceInformation trezorDeviceInformation = null;

            WindowsHidDevice retVal = null;

            retVal = new WindowsHidDevice();

            Console.Write("Waiting for Trezor .");

            while (trezorDeviceInformation == null)
            {
                var devices = WindowsHidDevice.GetConnectedDeviceInformations();
                var trezors = devices.Where(d => d.VendorId == TrezorManager.TrezorVendorId && TrezorManager.TrezorProductId == 1).ToList();
                trezorDeviceInformation = trezors.FirstOrDefault(t => t.Product == TrezorManager.USBOneName);

                if (trezorDeviceInformation != null)
                {
                    break;
                }

                await Task.Delay(1000);
                Console.Write(".");
            }

            retVal.DeviceInformation = trezorDeviceInformation;

            await retVal.InitializeAsync();

            Console.WriteLine("Connected");

            return retVal;
        }

        public enum Test
        {
            One,
            Two
        }

        /// <summary>
        /// TODO: This should be made in to a unit test but it's annoying to add the UI for a unit test as the Trezor requires human intervention for the pin
        /// </summary>
        /// <returns></returns>
        private async static Task Go()
        {

            try
            {
                using (var trezorHid = await Connect())
                {
                    using (var trezorManager = new TrezorManager(GetPin, trezorHid))
                    {
                        await trezorManager.InitializeAsync();

                        var tasks = new List<Task>();

                        for (var i = 0; i < 50; i++)
                        {
                            tasks.Add(DoGetAddress(trezorManager, i));
                        }

                        await Task.WhenAll(tasks);

                        for (var i = 0; i < 50; i++)
                        {
                            var address = await GetAddress(trezorManager, i);

                            Console.WriteLine($"Index: {i} (No change) - Address: {address}");

                            if (address != _Addresses[i])
                            {
                                throw new Exception("The ordering got messed up");
                            }
                        }

                        var ethAddress = await trezorManager.GetAddressAsync("ETH", 60, false, 0, false, AddressType.Ethereum);
                        Console.WriteLine($"First ETH address: {ethAddress}");

                        //This fails with 'Safety check failed'
                        //See https://github.com/trezor/trezor-mcu/issues/143
                        //https://github.com/trezor/trezor-mcu/blob/master/firmware/ethereum.c
                        //Which values here need leading zeros? Is Unicode the correct encoding?

                       

                        var message = new EthereumSignMessage
                        {
                            AddressNs = KeyPath.Parse("m/44'/60'/0'/0/0").Indexes,
                            Message = Encoding.UTF8.GetBytes("Hello").ToHex().ToHexBytes()
                        };

                        var messageSignature = await trezorManager.SendMessageAsync<EthereumMessageSignature, EthereumSignMessage>(message);

                        //Same as first address 
                        Console.WriteLine(ToHex(messageSignature.Address));

                        var signer = new Nethereum.Signer.EthereumMessageSigner();
                        var messageSignature2 = signer.EncodeUTF8AndSign("Hello2", new EthECKey(
                            "0x2e14c29aaecd1b7c681154d41f50c4bb8b6e4299a431960ed9e860e39cae6d29"));
                       // var recoveredAddress = signer.EncodeUTF8AndEcRecover("Hello", messageSignature.Signature.ToHex());
                        //Same as recovered address 
                        //Console.WriteLine(recoveredAddress);

                        //var txMessage = new EthereumSignTx
                        //{
                        //    Nonce = 1.ToHexBytes(),
                        //    GasPrice = 1000000000.ToHexBytes(),
                        //    GasLimit = 21000.ToHexBytes(),
                        //    To = "689c56aef474df92d44a1b70850f808488f9769c".ToHexBytes(),
                        //    Value = 1000000000000000.ToHexBytes(),
                        //    //Value = "de0b6b3a7640000".ToHexBytes(),
                        //    AddressNs = KeyPath.Parse("m/44'/60'/0'/0/0").Indexes,
                        //    ChainId = 1
                        //};



                        var txMessage = new EthereumSignTx
                        {
                            Nonce = 10.ToBytesForRLPEncoding().ToHex().ToHexBytes(),
                            GasPrice = 10.ToBytesForRLPEncoding().ToHex().ToHexBytes(),
                            GasLimit = 21000.ToBytesForRLPEncoding().ToHex().ToHexBytes(),
                            To = "689c56aef474df92d44a1b70850f808488f9769c".ToHexBytes(),
                            Value = BigInteger.Parse("10000000000000000000").ToBytesForRLPEncoding().ToHex().ToHexBytes(),
                            //Value = "de0b6b3a7640000".ToHexBytes(),
                            AddressNs = KeyPath.Parse("m/44'/60'/0'/0/0").Indexes,
                            //ChainId = 1
                        };
                        var transaction = await trezorManager.SendMessageAsync<EthereumTxRequest, EthereumSignTx>(txMessage);

                        var transactionSigner = new TransactionSigner();
                        var sigature2 = transactionSigner.SignTransaction("0x2e14c29aaecd1b7c681154d41f50c4bb8b6e4299a431960ed9e860e39cae6d29",
                         "0x689c56aef474df92d44a1b70850f808488f9769c", 10, 10, 10, 21000);
                        var transactionRecovered = new Transaction(sigature2.HexToByteArray());
                        //var transactionChainId = new TransactionChainId(sigature2.HexToByteArray(), 1);
                        

                        Console.WriteLine("All good");

                        Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }

        public static string ToHex(byte[] value, bool prefix = false)
        {
            var strPrex = prefix ? "0x" : "";
            return strPrex + string.Concat(value.Select(b => b.ToString("x2")).ToArray());
        }

        private async static Task DoGetAddress(TrezorManager trezorManager, int i)
        {
            var address = await GetAddress(trezorManager, i);
            _Addresses[i] = address;
        }

        private static async Task<string> GetAddress(TrezorManager trezorManager, int i)
        {
            return await trezorManager.GetAddressAsync("BTC", 0, false, (uint)i, false, AddressType.Bitcoin);
        }

        private async static Task<string> GetPin()
        {
            Console.WriteLine("Enter PIN based on Trezor values: ");
            return Console.ReadLine().Trim();
        }
        #endregion
    }


    public static class EthHelpers
    {
        private const string Format = "X1";
        private static readonly Encoding Encoding = new UTF8Encoding();

        public static string ToHexString(this IEnumerable<byte> bytes)
        {
            return bytes.Aggregate(string.Empty, (current, theByte) => current + theByte.ToString("X2"));
        }

        public static byte[] ToHexBytes(this string ethString)
        {
            var numberOfCharacters = ethString.Length / 2;
            var returnValue = new byte[numberOfCharacters];

            for (var i = 0; i < numberOfCharacters; i++)
            {
                var x = i * 2;
                var firstHexCharacter = ethString[x];
                var secondHexCharacter = ethString[x + 1];

                var hexStringBuilder = new StringBuilder();
                hexStringBuilder.Append(firstHexCharacter);
                hexStringBuilder.Append(secondHexCharacter);

                var hexString = hexStringBuilder.ToString();

                returnValue[i] = byte.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            }

            return returnValue;
        }

        public static string ToHex(this long number)
        {
            return number.ToString(Format);
        }

        public static string ToHex(this int number)
        {
            return number.ToString(Format);
        }

        public static byte[] ToHexBytes(this int number)
        {
            return Encoding.GetBytes(number.ToHex());
        }

        public static byte[] ToHexBytes(this long number)
        {
            return Encoding.GetBytes(number.ToHex());
        }

        public static byte[] ToEthBytes(this long number)
        {
            return Encoding.GetBytes($"0x{ToHexBytes(number)}");
        }

        public static byte[] ToEthBytes(this int number)
        {
            return Encoding.GetBytes($"0x{ToHexBytes(number)}");
        }
    }

    /****
    Copyright(c) 2014 Metaco SA

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.


    *****/


    /// <summary>
    /// Represent a path in the hierarchy of HD keys (BIP32)
    /// </summary>
    public class KeyPath
    {
        public KeyPath()
        {
            _Indexes = new uint[0];
        }

        /// <summary>
        /// Parse a KeyPath
        /// </summary>
        /// <param name="path">The KeyPath formated like 10/0/2'/3</param>
        /// <returns></returns>
        public static KeyPath Parse(string path)
        {
            var parts = path
                .Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(p => p != "m")
                .Select(ParseCore)
                .ToArray();
            return new KeyPath(parts);
        }

        public KeyPath(string path)
        {
            _Indexes =
                path
                .Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(p => p != "m")
                .Select(ParseCore)
                .ToArray();
        }

        private static uint ParseCore(string i)
        {
            bool hardened = i.EndsWith("'");
            var nonhardened = hardened ? i.Substring(0, i.Length - 1) : i;
            var index = uint.Parse(nonhardened);
            return hardened ? index | 0x80000000u : index;
        }

        public KeyPath(params uint[] indexes)
        {
            _Indexes = indexes;
        }

        readonly uint[] _Indexes;
        public uint this[int index]
        {
            get
            {
                return _Indexes[index];
            }
        }

        public uint[] Indexes
        {
            get
            {
                return _Indexes.ToArray();
            }
        }

        public KeyPath Derive(int index, bool hardened)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index", "the index can't be negative");
            uint realIndex = (uint)index;
            realIndex = hardened ? realIndex | 0x80000000u : realIndex;
            return Derive(new KeyPath(realIndex));
        }

        public KeyPath Derive(string path)
        {
            return Derive(new KeyPath(path));
        }

        public KeyPath Derive(uint index)
        {
            return Derive(new KeyPath(index));
        }

        public KeyPath Derive(KeyPath derivation)
        {
            return new KeyPath(
                _Indexes
                .Concat(derivation._Indexes)
                .ToArray());
        }

        public KeyPath Parent
        {
            get
            {
                if (_Indexes.Length == 0)
                    return null;
                return new KeyPath(_Indexes.Take(_Indexes.Length - 1).ToArray());
            }
        }

        public KeyPath Increment()
        {
            if (_Indexes.Length == 0)
                return null;
            var indices = _Indexes.ToArray();
            indices[indices.Length - 1]++;
            return new KeyPath(indices);
        }

        public override bool Equals(object obj)
        {
            KeyPath item = obj as KeyPath;
            if (item == null)
                return false;
            return ToString().Equals(item.ToString());
        }
        public static bool operator ==(KeyPath a, KeyPath b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (((object)a == null) || ((object)b == null))
                return false;
            return a.ToString() == b.ToString();
        }

        public static bool operator !=(KeyPath a, KeyPath b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        string _Path;
        public override string ToString()
        {
            return _Path ?? (_Path = string.Join("/", _Indexes.Select(ToString).ToArray()));
        }

        private static string ToString(uint i)
        {
            var hardened = (i & 0x80000000u) != 0;
            var nonhardened = (i & ~0x80000000u);
            return hardened ? nonhardened + "'" : nonhardened.ToString(CultureInfo.InvariantCulture);
        }

        public bool IsHardened
        {
            get
            {
                if (_Indexes.Length == 0)
                    throw new InvalidOperationException("No indice found in this KeyPath");
                return (_Indexes[_Indexes.Length - 1] & 0x80000000u) != 0;
            }
        }
    }
}



