﻿using System.Management;

namespace TotalCore.Helpers
{
    public static class SystemInfos
    {
        public static bool Validate()
        {
            string systemInfos = SystemInfos.GetSystemInfos(true);
            //string systemInfoDecrypt = SecureEncoding.Decrypt("9AjMX2WmdH1+f1gY28KOSIrnL3TmPUpAWOsRtqiPRqvMGh2ghwBv2xaZX73H9J2HdhsEjFDPEREvvqZWNMhmNZnwzIpQM0n+8sSgl7GDLB7KbU7rEjaLkIMwkLnkPwloByCwe9AtKMRrK1iCQ+dYyQTwZa6fHdaS/2ziwFyUsUQ="); //E7240T
            //string systemInfoDecrypt = SecureEncoding.Decrypt("AqSCdFEojixT1R7g9mYsC7P/RLTChZ2Y/nGSXg4MCCMoH+3cQ9mWmIc/ut8JYMX0uua5rejJyASktIBqHR/DiE3oy1QncbFDyGU2KtsPonCR8zk79MQENUIUvAWSivqIvKKyAHYRH45OvYD7B8+mANoCS2lhDFWMyE0Shn5h9wm2TNyVT7Nz04drLALpwgm436Zrrn6R9MEtnEf8jLGjUw=="); //VCP
            //@@AqSCdFEojixT1R7g9mYsC7P/RLTChZ2Y/nGSXg4MCCMoH+3cQ9mWmIc/ut8JYMX0uua5rejJyASktIBqHR/DiE3oy1QncbFDyGU2KtsPonCR8zk79MQENUIUvAWSivqIvKKyAHYRH45OvYD7B8+mAIrFiGbDS8JDUow7qVyLx24=@@ //E7250
            //[@@Cijn5MAjF/Bbydr1ZlOqFvgXtALG9k3sWDHK9o3XdZG60Mxnzx/VIRhs8fsZHUA0pCieTmZe6vIkFhwyHioDkn9J4/eQeA9a6G44TyXuch+lOMpKaFoQJ5ZBz+AXYwKgErRkVtcJg+gxsD0ea/amfcfFFF5+nwhHk7My63ffKDU=@@] //TTP
            if (systemInfos == "gmEgOUgh+OZ9d18aom0lEhe1oqlQBr0fB9g4Z8Y8ocZiLVQPbCycyyp7SIVl2t83y9X7eoqbBxIe1YbAOa4sbPLQVoTHUJF6TbYMV6gayKIJ1moEXxi2pBCvjEijOhxHluKNDcuEISk/Fa4XRtDrNKYfFNiDSVZr42GJmnMIHhA=" || systemInfos == "+4hi4FwOTj23nuc+yMjaAbL9gaElR1IKN2yQmhNJIS1tZK8uAHXAI5yKHUPPXYZlSnHdGnxKm8Uz5Z3bg50e1Oua2VRsrvZvdmPx4e47opjOfMrOv2e0DRprqXkEKcnqS+wvVkC0E7Cavh6S2Ms10FKMbgmCN7BzuKHPKT3t9Ts=" || systemInfos == "kxWScVlhOkmxRldQScelM+J4c36yK+u9o6JP7FdmJUmsIqLhdRd1OShXTePt2JfeCS1kD7QakMcgcaizK7gLZmyqFCJNNSNBK4EHN5PqoW25QMwzlQhYHFmuScOvQ8BAyJtlzdgMfU+QgONEKAi1qld09/Meh0WwR2s8Lmg3O/w=" || systemInfos == "Cijn5MAjF/Bbydr1ZlOqFvgXtALG9k3sWDHK9o3XdZG60Mxnzx/VIRhs8fsZHUA0pCieTmZe6vIkFhwyHioDkn9J4/eQeA9a6G44TyXuch+lOMpKaFoQJ5ZBz+AXYwKgErRkVtcJg+gxsD0ea/amfcfFFF5+nwhHk7My63ffKDU=" || systemInfos == "AqSCdFEojixT1R7g9mYsC7P/RLTChZ2Y/nGSXg4MCCMoH+3cQ9mWmIc/ut8JYMX0uua5rejJyASktIBqHR/DiE3oy1QncbFDyGU2KtsPonCR8zk79MQENUIUvAWSivqI/2CeUJ9Fd/aTBNbWaB9rGw==" || systemInfos == "gmEgOUgh+OZ9d18aom0lEkMQtkVytJhi0WMs9PaNUaLcO8mC/end9t41El6XIJil3Jj9F024seQ86Cgc+clcah519aPKmiHIT6uZ4G03KC4a/uuaARWFqzYrCzlI7xZNkMU4IvW8q/yCHU2ABITs5lQMOTuACP4VFW1A07n/7WY=" || systemInfos == "AqSCdFEojixT1R7g9mYsC7P/RLTChZ2Y/nGSXg4MCCMoH+3cQ9mWmIc/ut8JYMX0uua5rejJyASktIBqHR/DiE3oy1QncbFDyGU2KtsPonCR8zk79MQENUIUvAWSivqIvKKyAHYRH45OvYD7B8+mAIrFiGbDS8JDUow7qVyLx24=" || systemInfos == "9AjMX2WmdH1+f1gY28KOSIrnL3TmPUpAWOsRtqiPRqvMGh2ghwBv2xaZX73H9J2HdhsEjFDPEREvvqZWNMhmNZnwzIpQM0n+8sSgl7GDLB7KbU7rEjaLkIMwkLnkPwloByCwe9AtKMRrK1iCQ+dYyQTwZa6fHdaS/2ziwFyUsUQ=" || systemInfos == "AqSCdFEojixT1R7g9mYsC7P/RLTChZ2Y/nGSXg4MCCMoH+3cQ9mWmIc/ut8JYMX0uua5rejJyASktIBqHR/DiE3oy1QncbFDyGU2KtsPonCR8zk79MQENUIUvAWSivqIvKKyAHYRH45OvYD7B8+mANoCS2lhDFWMyE0Shn5h9wm2TNyVT7Nz04drLALpwgm436Zrrn6R9MEtnEf8jLGjUw==" || systemInfos == "+4hi4FwOTj23nuc+yMjaAbL9gaElR1IKN2yQmhNJIS1tZK8uAHXAI5yKHUPPXYZlSnHdGnxKm8Uz5Z3bg50e1Oua2VRsrvZvdmPx4e47opjOfMrOv2e0DRprqXkEKcnqS+wvVkC0E7Cavh6S2Ms10KQiVnZdtokR95DwNpb/M1Q=" || systemInfos == "3NOAqcCDOHLl8gbGvZfCF3INjdNgWLsrhjnTICFjq+G9OgAzVd3uPXu932TA4QRsDh9EJPci0IhUWh5v4OQZtUPpA0o7HcZV3NBW7du+epWdcdr5+RGazxfNnrCQ4qI0fqAJdZRia1Y/FBOl+l+SWd5dUXJpa3HnQfNOS+3O7xgU+y3GQQraIFYtgbadsTi8" || systemInfos == "fzs4+xEMFQA7okWRdpuqxOFTJrNvN56JUnHUgNb+Bw26YN2Iz61Lm07Z/Oj75O1OzVRNIID4YElyDhOILJ24O4yAGt1LNrW0yi4+4+OPv5mx8O3QFKAM85/6bmOhcOZ74o8J5AuIgB/CPmb5StrJVfVyHm6l2+ycudlq2g9w74braZrhqroN1p7rgqBmNIgzs3iCkJzw3TmG6WNq5nAh4Q==" || systemInfos == "fzs4+xEMFQA7okWRdpuqxOFTJrNvN56JUnHUgNb+Bw26YN2Iz61Lm07Z/Oj75O1OzVRNIID4YElyDhOILJ24O4yAGt1LNrW0yi4+4+OPv5mx8O3QFKAM85/6bmOhcOZ74o8J5AuIgB/CPmb5StrJVfVyHm6l2+ycudlq2g9w74aVwsGZs3qw5Cupm5f/mt8o" || systemInfos == "gmEgOUgh+OZ9d18aom0lEkMQtkVytJhi0WMs9PaNUaLcO8mC/end9t41El6XIJil3Jj9F024seQ86Cgc+clcah519aPKmiHIT6uZ4G03KC4a/uuaARWFqzYrCzlI7xZNrUpL6yc4dA7+QqQZHE/4ABrMdAJRuQQwwaeNvOABneE=" || systemInfos == "+4hi4FwOTj23nuc+yMjaAbL9gaElR1IKN2yQmhNJIS1tZK8uAHXAI5yKHUPPXYZlSnHdGnxKm8Uz5Z3bg50e1Oua2VRsrvZvdmPx4e47opiUsCg4L87I0QKopDtaumJSYO5+Bja5qqIk2sMxdDWkygKylCGUeCTBydBLXA7QFP4=" || systemInfos == "kxWScVlhOkmxRldQScelM+J4c36yK+u9o6JP7FdmJUmsIqLhdRd1OShXTePt2JfeCS1kD7QakMcgcaizK7gLZmyqFCJNNSNBK4EHN5PqoW25QMwzlQhYHFmuScOvQ8BAYU2ujatxTIo9BWRwkxRYkg==" || systemInfos == "Cijn5MAjF/Bbydr1ZlOqFvgXtALG9k3sWDHK9o3XdZGE9pscGrLMj2R9lWvft1R6zNj8jbkFXqdfclMYuvKuJxpjvoPpMArmFcZBPsEcHx8VRBpR44kInmXhz6eoD6YSGyxCr+bHKExQWiM7V6Mjd4BBgdgPoyVr63f8CNCq5qM=")
                return true;
            else
                throw new SystemException("Copyright " + DateTime.Now.Year + ". All rights reserved." + "\r\n" + "\r\n" + "Please contact via: Tel: 0903 880 501, 0919 878 329, Skype: hieperp, Email: hieperp@gmail.com");
        }

        public static String GetSystemInfos()
        {
            return SystemInfos.GetSystemInfos(false);
        }

        public static String GetSystemInfos(bool secureEncoding)
        {
            string processorAllInfos = SystemInfos.GetProcessorAllInfos();
            string hddSerialNo = SystemInfos.GetHDDSerialNo();
            string macAddress = SystemInfos.GetMACAddress();
            string boardMaker = SystemInfos.GetBoardMaker();

            string systemInfos = processorAllInfos + boardMaker + macAddress;// +hddSerialNo;
            if (secureEncoding)
                systemInfos = SecureEncoding.Encrypt(systemInfos);

            return systemInfos;
        }

        /// <summary>
        /// This = GetProcessorId() + GetProcessorInformation()
        /// </summary>
        /// <returns></returns>
        public static String GetProcessorAllInfos()
        {

            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["processorID"].Value.ToString();
                break;
            }

            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                string name = (string)mo["Name"];
                name = name.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ");

                info = name + ", " + (string)mo["Caption"] + ", " + (string)mo["SocketDesignation"];
                //mo.Properties["Name"].Value.ToString();
                //break;
            }

            return Id + info;
        }

        /// <summary>
        /// Retrieving Processor Id.
        /// </summary>
        /// <returns></returns>
        /// 
        public static String GetProcessorId()
        {

            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return Id;

        }

        /// <summary>
        /// Retrieving Processor Information.
        /// </summary>
        /// <returns></returns>
        public static String GetProcessorInformation()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                string name = (string)mo["Name"];
                name = name.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ");

                info = name + ", " + (string)mo["Caption"] + ", " + (string)mo["SocketDesignation"];
                //mo.Properties["Name"].Value.ToString();
                //break;
            }
            return info;
        }

        /// <summary>
        /// Retrieving HDD Serial No.
        /// </summary>
        /// <returns></returns>
        public static String GetHDDSerialNo()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }

        /// <summary>
        /// Retrieving System MAC Address.
        /// </summary>
        /// <returns></returns>
        public static string GetMACAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            string MACAddress = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                if (MACAddress == String.Empty)
                {
                    if ((bool)mo["IPEnabled"] == true)
                        MACAddress = mo["MacAddress"].ToString();
                }
                mo.Dispose();
            }

            MACAddress = MACAddress.Replace(":", "");
            return MACAddress;
        }

        /// <summary>
        /// Retrieving Motherboard Manufacturer.
        /// </summary>
        /// <returns></returns>
        public static string GetBoardMaker()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();
                }

                catch { }

            }

            return "Board Maker: Unknown";
        }

        /// <summary>
        /// Retrieving Motherboard Product Id.
        /// </summary>
        /// <returns></returns>
        public static string GetBoardProductId()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Product").ToString();

                }

                catch { }

            }

            return "Product: Unknown";

        }

        /// <summary>
        /// Retrieving CD-DVD Drive Path.
        /// </summary>
        /// <returns></returns>
        public static string GetCdRomDrive()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Drive").ToString();

                }

                catch { }

            }

            return "CD ROM Drive Letter: Unknown";
        }

        /// <summary>
        /// Retrieving BIOS Maker.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOSmaker()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();

                }

                catch { }

            }

            return "BIOS Maker: Unknown";
        }

        /// <summary>
        /// Retrieving BIOS Serial No.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOSserNo()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("SerialNumber").ToString();

                }

                catch { }

            }

            return "BIOS Serial Number: Unknown";

        }

        /// <summary>
        /// Retrieving BIOS Caption.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOScaption()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Caption").ToString();

                }
                catch { }
            }
            return "BIOS Caption: Unknown";
        }

        /// <summary>
        /// Retrieving System Account Name.
        /// </summary>
        /// <returns></returns>
        public static string GetAccountName()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {

                    return wmi.GetPropertyValue("Name").ToString();
                }
                catch { }
            }
            return "User Account Name: Unknown";

        }

        /// <summary>
        /// Retrieving Physical Ram Memory.
        /// </summary>
        /// <returns></returns>
        public static string GetPhysicalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            // In case more than one Memory sticks are installed
            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Capacity"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024;
            return MemSize.ToString() + "MB";
        }

        /// <summary>
        /// Retrieving No of Ram Slot on Motherboard.
        /// </summary>
        /// <returns></returns>
        public static string GetNoRamSlots()
        {

            int MemSlots = 0;
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery2 = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
            ManagementObjectSearcher oSearcher2 = new ManagementObjectSearcher(oMs, oQuery2);
            ManagementObjectCollection oCollection2 = oSearcher2.Get();
            foreach (ManagementObject obj in oCollection2)
            {
                MemSlots = Convert.ToInt32(obj["MemoryDevices"]);

            }
            return MemSlots.ToString();
        }

        //Get CPU Temprature.
        /// <summary>
        /// method for retrieving the CPU Manufacturer
        /// using the WMI class
        /// </summary>
        /// <returns>CPU Manufacturer</returns>
        public static string GetCPUManufacturer()
        {
            string cpuMan = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            foreach (ManagementObject obj in objCol)
            {
                if (cpuMan == String.Empty)
                {
                    // only return manufacturer from first CPU
                    cpuMan = obj.Properties["Manufacturer"].Value.ToString();
                }
            }
            return cpuMan;
        }

        /// <summary>
        /// method to retrieve the CPU's current
        /// clock speed using the WMI class
        /// </summary>
        /// <returns>Clock speed</returns>
        public static int GetCPUCurrentClockSpeed()
        {
            int cpuClockSpeed = 0;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            foreach (ManagementObject obj in objCol)
            {
                if (cpuClockSpeed == 0)
                {
                    // only return cpuStatus from first CPU
                    cpuClockSpeed = Convert.ToInt32(obj.Properties["CurrentClockSpeed"].Value.ToString());
                }
            }
            //return the status
            return cpuClockSpeed;
        }

        /// <summary>
        /// method to retrieve the network adapters
        /// default IP gateway using WMI
        /// </summary>
        /// <returns>adapters default IP gateway</returns>
        public static string GetDefaultIPGateway()
        {
            //create out management class object using the
            //Win32_NetworkAdapterConfiguration class to get the attributes
            //of the network adapter
            ManagementClass mgmt = new ManagementClass("Win32_NetworkAdapterConfiguration");
            //create our ManagementObjectCollection to get the attributes with
            ManagementObjectCollection objCol = mgmt.GetInstances();
            string gateway = String.Empty;
            //loop through all the objects we find
            foreach (ManagementObject obj in objCol)
            {
                if (gateway == String.Empty)  // only return MAC Address from first card
                {
                    //grab the value from the first network adapter we find
                    //you can change the string to an array and get all
                    //network adapters found as well
                    //check to see if the adapter's IPEnabled
                    //equals true
                    if ((bool)obj["IPEnabled"] == true)
                    {
                        gateway = obj["DefaultIPGateway"].ToString();
                    }
                }
                //dispose of our object
                obj.Dispose();
            }
            //replace the ":" with an empty space, this could also
            //be removed if you wish
            gateway = gateway.Replace(":", "");
            //return the mac address
            return gateway;
        }

        /// <summary>
        /// Retrieve CPU Speed.
        /// </summary>
        /// <returns></returns>
        public static double? GetCpuSpeedInGHz()
        {
            double? GHz = null;
            using (ManagementClass mc = new ManagementClass("Win32_Processor"))
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    GHz = 0.001 * (UInt32)mo.Properties["CurrentClockSpeed"].Value;
                    break;
                }
            }
            return GHz;
        }

        /// <summary>
        /// Retrieving Current Language
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentLanguage()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("CurrentLanguage").ToString();
                }

                catch { }

            }

            return "BIOS Maker: Unknown";
        }

        /// <summary>
        /// Retrieving Current Language.
        /// </summary>
        /// <returns></returns>
        public static string GetOSInformation()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return ((string)wmi["Caption"]).Trim() + ", " + (string)wmi["Version"] + ", " + (string)wmi["OSArchitecture"];
                }
                catch { }
            }
            return "BIOS Maker: Unknown";
        }

        /// <summary>
        /// Retrieving Computer Name.
        /// </summary>
        /// <returns></returns>
        public static String GetComputerName()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                info = (string)mo["Name"];
                //mo.Properties["Name"].Value.ToString();
                //break;
            }
            return info;
        }
    }
}
