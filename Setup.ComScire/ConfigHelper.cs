using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setup.ComScire
{
    public static class EnvVars
    {

        public const string COMSCIRE_ACTIVEX = "COMSCIRE_ACTIVEX_DLL";
        public const string USB_DRIVER_FTDI_DLL = "USB_DRIVER_FTDI_DLL";

        public const string COMSCIRE_32_BIT_RELATIVE_SOURCE_DIR = "COMSCIRE_32_BIT_DLL_RELATIVE_SOURCE_DIR";
        public const string COMSCIRE_64_BIT_RELATIVE_SOURCE_DIR = "COMSCIRE_64_BIT_DLL_RELATIVE_SOURCE_DIR";        

        public const string COMSCIRE_32_BIT_DESTINATION = "COMSCIRE_32_BIT_DESTINATION_DIR";
        public const string COMSCIRE_64_BIT_DESTINATION = "COMSCIRE_64_BIT_DESTINATION_DIR";
        
    }
    public static class Settings
    {
        public const string COMSCIRE_SETUP_ENV_SCRIPT = "setup_comscire_envVars.bat";
        public const string RegisterDll = "register_dll.bat";
        
        public const string EXTENSION_BAT = ".bat";
        
    }
}
