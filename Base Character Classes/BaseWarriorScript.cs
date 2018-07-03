using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorScript : BaseCharacter{

    public void BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A strong fighter who uses their physical prowess to combat foes in close quarter combat.";

        HealthPoints = 30;
        StaminaPoints = 25;
        MagicPoints = 10;

        Strength = 15;
        Dexterity = 13;
        Constitution = 15;
        Intelligence = 10;
        Wisdom = 10;
        Charisma = 13;
    }
	
}
