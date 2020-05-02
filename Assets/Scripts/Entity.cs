using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public byte level = 1;
    public short health = 10;
    public short maxHealth = 10;
    public short mana = 3;
    public short maxMana = 3;

    public byte strength = 10,
               dexterity = 10,
               constitution = 10,
               charisma = 10,
               wisdom = 10,
               intelligence = 10;

    // Update is called once per frame
    void Update()
    {

    }
}
