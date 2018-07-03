using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : BaseStatItem {

	public enum PotionTypes
    {
        HEALTH,
        STAMINA,
        MAGIC,
        STRENGTH,
        DEXTERITY,
        CONSTITUTION,
        INTELLIGENCE,
        WISDOM,
        CHARISMA
    }

    private PotionTypes potionType;
    private int itemEffectID;

    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }

}
