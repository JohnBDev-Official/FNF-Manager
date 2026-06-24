using System;
using System.Collections.Generic;
using System.Text;

namespace FNF_Manager.Models
{
    public class Settings
    {
        /// <summary>
        /// Where to store FNF base game
        /// </summary>
        public string BaseGameDir { get; set; } = "";
        /// <summary>
        /// Where to store FNF mods
        /// </summary>
        public string ModsDir { get; set; } = "";
        /// <summary>
        /// Where to store FNF save files
        /// </summary>
        public string SavesDir { get; set; } = "";
    }
}
