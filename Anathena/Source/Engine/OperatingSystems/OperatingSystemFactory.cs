﻿using Anathena.Source.Engine.OperatingSystems.Windows;
using System.Diagnostics;

namespace Anathena.Source.Engine.OperatingSystems
{
    class OperatingSystemFactory
    {
        public static IOperatingSystem GetOperatingSystem(Process Target)
        {
            return new WindowsAdapter(Target);
        }

    } // End class

} // End namespace