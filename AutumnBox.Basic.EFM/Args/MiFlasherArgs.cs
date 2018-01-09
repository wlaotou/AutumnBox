/* =============================================================================*\
*
* Filename: MiFlasherArgs.cs
* Description: 
*
* Version: 1.0
* Created: 10/3/2017 00:36:34(UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using AutumnBox.Basic.Device;

namespace AutumnBox.Basic.Function.Args
{
    public enum MiFlashType
    {
        FlashAll,
        FlashAllExceptStorage,
        FlashAllExceptStorageAndData,
    }
    public class MiFlasherArgs : ModuleArgs
    {
        public MiFlasherArgs(DeviceBasicInfo devInfo) : base(devInfo) { }
        public string  FloderPath { get; set; }
        public MiFlashType Type { get; set; }
    }
}
