﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ViridianLink.Editor.Implementations
{
    public class EditorDebuggerImplementation : ViridianLink.Implementations.DebuggerImplementation
    {
        public override void Log(object obj)
        {
            Debug.Log(obj);
        }

        public override void Log(string str)
        {
            Debug.Log(str);
        }

        public override void LogError(object obj)
        {
            Debug.LogError(obj);
        }

        public override void LogError(string str)
        {
            Debug.LogError(str);
        }

        public override void LogWarning(object obj)
        {
            Debug.LogWarning(obj);
        }

        public override void LogWarning(string str)
        {
            Debug.LogWarning(str);
        }
    }
}