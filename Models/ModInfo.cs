using System;
using System.Collections.Generic;
using System.Text;

namespace FNF_Manager.Models
{
    /// <summary>
    /// Represents a Friday Night Funkin' mod installed or tracked by the manager.
    /// </summary>
    public class ModInfo
    {
        /// <summary>
        /// The display name of the mod.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// The folder name of the mod in the FNF Manager mods directory
        /// </summary>
        public string FolderName { get; set; } = "";

        /// <summary>
        /// The version number of the mod.
        /// </summary>
        public string Version { get; set; } = "";

        /// <summary>
        /// Where the mod is from, used when checking and pulling new versions of the mod.
        /// </summary>
        public enum ModSource
        {
            GameBanana,
            LocalZip,
            ManualFolder,
            Unknown
        }

        /// <summary>
        /// If the mod is actually installed or in the user's list of mods.
        /// </summary>
        public bool IsInstalled { get; set; }
}
}
