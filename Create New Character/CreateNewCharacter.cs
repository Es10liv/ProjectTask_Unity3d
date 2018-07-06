using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour {

    private BasePlayer newPlayer;

    private bool isMageClass;
    private bool isWarriorClass;
    private bool isRogueClass;
    private string playerName = "Enter Name";


	// Use this for initialization
	void Start ()
    {
        newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 15);
        isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        isRogueClass = GUILayout.Toggle(isRogueClass, "Rogue Class");
        if (GUILayout.Button("Create New Character"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageScript();
            }
        
            else if (isWarriorClass)
            {
            newPlayer.PlayerClass = new BaseWarriorScript();
            }
            else if (isRogueClass)
            {
                newPlayer.PlayerClass = new BaseRougeClass();
            }
            newPlayer.PlayerLevel = 1;
            newPlayer.HealthPoints = newPlayer.PlayerClass.HealthPoints;
            newPlayer.StaminaPoints = newPlayer.PlayerClass.StaminaPoints;
            newPlayer.MagicPoints = newPlayer.PlayerClass.MagicPoints;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
            newPlayer.Constitution = newPlayer.PlayerClass.Constitution;
            newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
            newPlayer.Wisdom = newPlayer.PlayerClass.Wisdom;
            newPlayer.Charisma = newPlayer.PlayerClass.Charisma;
            newPlayer.PlayerName = playerName;

            StoreNewPlayerInfo();
            SaveInfo.SaveAllInfo();

            
        }
        if(GUILayout.Button("Load"))
        {
            // Obsolete - added UnityEngine.SceneManagement
            //Application.LoadLevel("test");
            
            SceneManager.LoadScene("test");
        }
        
    }
    private void StoreNewPlayerInfo()
    {
        GameInfo.PlayerName = newPlayer.PlayerName;
        GameInfo.PlayerLevel = newPlayer.PlayerLevel;
        GameInfo.HealthPoints = newPlayer.HealthPoints;
        GameInfo.StaminaPoints = newPlayer.StaminaPoints;
        GameInfo.MagicPoints = newPlayer.MagicPoints;
        GameInfo.Strength = newPlayer.Strength;
        GameInfo.Dexterity = newPlayer.Dexterity;
        GameInfo.Constitution = newPlayer.Constitution;
        GameInfo.Intelligence = newPlayer.Intelligence;
        GameInfo.Wisdom = newPlayer.Wisdom;
        GameInfo.Charisma = newPlayer.Charisma;
    }
}
