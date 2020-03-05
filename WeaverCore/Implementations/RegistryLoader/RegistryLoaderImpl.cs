﻿using System;
using System.Collections.Generic;
using UnityEngine;
using WeaverCore.Helpers;

namespace WeaverCore.Implementations
{
	public abstract class RegistryLoaderImplementation : IImplementation
    {
        //static bool loaded = false;

        public IEnumerable<Registry> GetRegistries<Mod>() where Mod : IWeaverMod
        {
            return GetRegistries(typeof(Mod));
        }

        public abstract IEnumerable<Registry> GetRegistries(Type modType);
    }
}