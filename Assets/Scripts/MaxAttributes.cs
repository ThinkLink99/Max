// Attribute Script
// Author: Trey Hall
// Description:
// Handles getting and modifying attributes related to the player such as health, mana, and other rpg attributes.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentSlots { HEAD, TORSO, LEGS, BOOTS, ARMS, WEAPON_MAIN, WEAPON_OFF };
public class MaxAttributes : Entity
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public override string ToString()
    {
        return $"Health: {health}/{maxHealth}\nMana: {mana}/{maxMana}\nStrength: {strength}\nDexterity: {dexterity}\nConstitution: {constitution}\nCharisma: {charisma}\nWisdom: {wisdom}\nIntelligence: {intelligence}";
    }
}

