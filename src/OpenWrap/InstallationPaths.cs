﻿using System;
using System.Collections.Generic;
using System.IO;
using OpenWrap.Configuration;
using OpenWrap.Configuration.remote_repositories;
using OpenFileSystem.IO;
using OpenWrap.Repositories;
using OpenWrap.Services;

namespace OpenWrap
{
    public static class InstallationPaths
    {
        public static string SystemRepositoryDirectory
        {
            get
            {
                return Path.Combine(SystemDirectory, "wraps");
            }
        }
        public static string ConfigurationDirectory
        {
            get
            {
                return Path.Combine(SystemDirectory, "config");
            }
        }
        public static string SystemDirectory
        {
            get
            {
                return 
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "openwrap");
            }
        }
    }
}