﻿using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace OpenInSublimeText
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", Version, IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(PackageGuids.guidPackageString)]
    public sealed class VSPackage : Package
    {
        public const string Version = "1.0";
        public const string Title = "Open in Sublime Text";

        protected override void Initialize()
        {
            Logger.Initialize(this, Title);
            Telemetry.Initialize(this, Version, "7f5bc7fb-da06-481e-b66d-40088746d163");
            OpenSublimeTextCommand.Initialize(this);

            base.Initialize();
        }
    }
}
