using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEquipment : BaseStatItem
{

    public enum EquipmentTypes
    {
        HEAD,
        ARMS,
        LEGS,
        CHEST,
        ACCESSORY
    }

    private EquipmentTypes equipmentTypes;
    private int itemEffectID;

    public EquipmentTypes equipmentType
    {
        get { return equipmentTypes; }
        set { equipmentTypes = value; }
    }
    public int ItemEffectID
    {
        get { return itemEffectID; }
        set { itemEffectID = value; }
    }
}