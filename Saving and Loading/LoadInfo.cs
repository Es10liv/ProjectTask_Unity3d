using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo : MonoBehaviour {

	public static void LoadAllInfo()
    {
        GameInfo.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInfo.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInfo.HealthPoints = PlayerPrefs.GetInt("HEALTHPOINTS");
        GameInfo.StaminaPoints = PlayerPrefs.GetInt("STAMINAPOINTS");
        GameInfo.MagicPoints = PlayerPrefs.GetInt("MAGICPOINTS");
        GameInfo.Strength = PlayerPrefs.GetInt("STRENGTH");
        GameInfo.Dexterity = PlayerPrefs.GetInt("DEXTERITY");
        GameInfo.Constitution = PlayerPrefs.GetInt("CONSTITUTION");
        GameInfo.Intelligence = PlayerPrefs.GetInt("INTELLIGENCE");
        GameInfo.Wisdom = PlayerPrefs.GetInt("WISDOM");
        GameInfo.Charisma = PlayerPrefs.GetInt("CHARISMA");
    }
}
