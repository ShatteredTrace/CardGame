using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero{

    int Hitpoints;
    int Manapoints;
    int Maxhandsize;

    Hero(int hp, int mp, int maxhand)
    {
        this.Hitpoints = hp;
        this.Manapoints =mp;
        this.Maxhandsize = maxhand;
    }

    Hero()
    {
        this.Hitpoints = 10;
        this.Manapoints = 10;
        this.Maxhandsize = 10;
    }

    void takeDamage(int dmg)
    {
        Hitpoints -= dmg;
    }

    bool useMana(int mana)
    {
        if(Manapoints >= mana)
        {
            Manapoints -= mana;
            return true;
        } else
        {
            return false;
        }
    }
}
