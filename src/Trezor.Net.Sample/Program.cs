﻿using Hid.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trezor.Manager;
using static Trezor.Manager.TrezorManager;

namespace TrezorTestApp
{
    class Program
    {
        #region Fields
        private static List<string> _Addresses = new List<string>();
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
            var devices = WindowsHidDevice.GetConnectedDeviceInformations();
            var trezors = devices.Where(d => d.VendorId == TrezorManager.TrezorVendorId && TrezorManager.TrezorProductId == 1);

            DeviceInformation trezorDeviceInformation;

            trezorDeviceInformation = trezors.FirstOrDefault(t => t.Product == USBOneName);

            if (trezorDeviceInformation == null)
            {
                throw new Exception("No Trezor is not connected or USB access was not granted to this application.");
            }

            var retVal = new WindowsHidDevice(trezorDeviceInformation);

            await retVal.InitializeAsync();

            return retVal;
        }

        /// <summary>
        /// TODO: This should be made in to a unit test but it's annoying to add the UI for a unit test as the Trezor requires human intervention for the pin
        /// </summary>
        /// <returns></returns>
        private async static Task Go()
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

                    Console.WriteLine("All good");

                    Console.ReadLine();
                }
            }
        }

        private async static Task DoGetAddress(TrezorManager trezorManager, int i)
        {
            _Addresses.Insert(i, await GetAddress(trezorManager, i));
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
}
