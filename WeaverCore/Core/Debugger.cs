﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeaverCore.Helpers;
using WeaverCore.Implementations;

namespace WeaverCore
{
    public static class Debugger
    {
        static Debugger_I impl = ImplFinder.GetImplementation<Debugger_I>();

        public static void Log(object obj)
        {
            impl.Log(obj);
        }

        public static void Log(string str)
        {
            impl.Log(str);
        }

        public static void LogError(object obj)
        {
            impl.LogError(obj);
        }

        public static void LogError(string str)
        {
            impl.LogError(str);
        }

        public static void LogWarning(object obj)
        {
            impl.LogWarning(obj);
        }

        public static void LogWarning(string str)
        {
            impl.LogWarning(str);
        }
    }
}
