using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem {

	public enum WeaponTypes
    {
        SWORD,
        GREATSWORD,
        AXE,
        BATTLEAXE,
        MACE,
        WARHAMMER,
        BOW,
        DAGGER,
        STAFF,
        TOME
    }
    private WeaponTypes weaponTypes;
    private int itemEffectID;

    public WeaponTypes weaponType
    {
        get { return weaponTypes; }
        set { weaponTypes = value; }
    }
    public int ItemEffectID
    {
        get { return itemEffectID; }
        set { itemEffectID = value; }
    }
}