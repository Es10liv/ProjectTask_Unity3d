using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRougeClass : BaseCharacter {

    public void BaseRogueClass()
    {
        CharacterClassName = "Rogue";
        CharacterClassDescription = "A dextrous adventurer who prefers to fight at a distance as an archer or sneaking up behind their enemies with their daggers.";

        HealthPoints = 20;
        StaminaPoints = 30;
        MagicPoints = 15;

        Strength = 12;
        Dexterity = 15;
        Constitution = 12;
        Intelligence = 12;
        Wisdom = 10;
        Charisma = 15;
    }
}
