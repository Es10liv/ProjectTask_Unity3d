using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter{

    private string characterClassName;
    private string characterClassDescription;


    // depletable stats
    private int healthPoints;
    private int staminaPoints;
    private int magicPoints;

    // main attributes
    private int strength;
    private int dexterity;
    private int constitution;
    private int intelligence;
    private int wisdom;
    private int charisma;

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public int HealthPoints
    {
        get { return healthPoints; }
        set { healthPoints = value; }
    }

    public int StaminaPoints
    {
        get { return staminaPoints; }
        set { staminaPoints = value; }
    }

    public int MagicPoints
    {
        get { return magicPoints; }
        set { magicPoints = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Constitution
    {
        get { return constitution; }
        set { constitution = value; }
    }

    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

    public int Wisdom
    {
        get { return wisdom; }
        set { wisdom = value; }
    }

    public int Charisma
    {
        get { return charisma; }
        set { charisma = value; }
    }
}
