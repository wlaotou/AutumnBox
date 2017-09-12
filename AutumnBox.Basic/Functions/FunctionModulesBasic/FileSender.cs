﻿using AutumnBox.Basic.Functions.Event;
using System.Diagnostics;
using AutumnBox.Basic.Functions.Interface;
using AutumnBox.Basic.AdbEnc;

namespace AutumnBox.Basic.Functions
{
    /// <summary>
    /// 文件发送器
    /// </summary>
    public sealed class FileSender : FunctionModule
    {
        public event SimpleFinishEventHandler sendSingleFinish;
        private FileArgs args;

        public FileSender(FileArgs fileArg) : base() {
            this.args= fileArg;
            for (int i = 0;i < args.files.Length; i++) {
                args.files[i].Replace('\\','/');
            }
        }
        protected override  OutputData MainMethod()
        {
            string filename;
            string[] x;
            foreach (string filepath in args.files)
            {
                x = filepath.Split('/');
                filename = x[x.Length - 1];
                MainExecuter.Execute(DeviceID, $"push \"{filepath}\" /sdcard/{filename}");
                sendSingleFinish?.Invoke();
            }
            return new OutputData();
        }
    }
}
