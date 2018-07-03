using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScroll : BaseStatItem {

	public enum ScrollTypes
    {
        HEALING,
        ATTACK
    }

    private ScrollTypes scrolltypes;
    private int itemEffectID;

    public ScrollTypes ScrollType
    {
        get { return scrolltypes; }
        set { scrolltypes = value; }
    }
    public int ItemEffectID
    {
        get { return itemEffectID; }
        set { itemEffectID = value; }
    }
}
