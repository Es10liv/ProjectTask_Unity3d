using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageScript : BaseCharacter {

    public void BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "A student of the mystic arts who wields powerful magic to trick and defeat their foes.";

        HealthPoints = 20;
        StaminaPoints = 15;
        MagicPoints = 30;

        Strength = 10;
        Dexterity = 12;
        Constitution = 12;
        Intelligence = 15;
        Wisdom = 15;
        Charisma = 12;
    }
}
