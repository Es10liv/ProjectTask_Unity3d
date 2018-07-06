using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour {

	public static void SaveAllInfo()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInfo.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInfo.PlayerName);
        PlayerPrefs.SetInt("HEALTHPOINTS", GameInfo.HealthPoints);
        PlayerPrefs.SetInt("STAMINAPOINTS", GameInfo.StaminaPoints);
        PlayerPrefs.SetInt("MAGICPOINTS", GameInfo.MagicPoints);
        PlayerPrefs.SetInt("STRENGTH", GameInfo.Strength);
        PlayerPrefs.SetInt("DEXTERITY", GameInfo.Dexterity);
        PlayerPrefs.SetInt("CONSTITUTION", GameInfo.Constitution);
        PlayerPrefs.SetInt("INTELLIGENCE", GameInfo.Intelligence);
        PlayerPrefs.SetInt("WISDOM", GameInfo.Wisdom);
        PlayerPrefs.SetInt("CHARISMA", GameInfo.Charisma);
    }
}
