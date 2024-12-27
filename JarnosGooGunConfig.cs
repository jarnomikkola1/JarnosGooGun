using System; 
using PhoenixPoint.Modding;

namespace JarnosGooGun
{
	/// <summary>
	/// ModConfig is mod settings that players can change from within the game.
	/// Config is only editable from players in main menu.
	/// Only one config can exist per mod assembly.
	/// Config is serialized on disk as json.
	/// </summary>
	public class JarnosGooGunConfig : ModConfig
	{

		/*
        /// Only public fields are serialized.
        /// Supported types for in-game UI are:
        public int IntegerValue;
        public float FloatValue;
        public bool BoolValue;

        public enum CustomEnum
        {
            A, B, C
        }
        public CustomEnum CustomEnumValue;
        */

		[ConfigField(text: "Edit Kaos Buggy/Junker to have a paralyzing goo gun",
			description: "Just like the titel say (Default false)")]
		public bool maxgoo = false;

	}
}
