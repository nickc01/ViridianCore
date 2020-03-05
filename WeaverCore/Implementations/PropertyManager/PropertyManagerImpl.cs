﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeaverCore.Helpers;

namespace WeaverCore.Implementations
{
	public abstract class PropertyManagerImplementation : IImplementation
	{
		public abstract void Start();

		public abstract void End();

		public abstract void AddTable(IPropertyTableBase table);
		public abstract void RemoveTable(IPropertyTableBase table);

		public void CleanTable(IPropertyTableBase table)
		{
			lock (table.Lock)
			{
				foreach (var key in table.Keys.ToList())
				{
					if (!table.Validate(key))
					{
						table.Remove(key);
					}
				}
			}
		}
	}
}
