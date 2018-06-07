using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    int HitPoints;
    int Damage;
    int Speed;

    public Monster(int hp, int dmg, int speed)
    {
        this.HitPoints = hp;
        this.Damage = dmg;
        this.Speed = speed;
    }

    public Monster()
    {
        this.HitPoints = 100;
        this.Damage = 1;
        this.Speed = 1;
    }

    public void takeDamage(int dmg)
    {
        this.HitPoints -= dmg;
    }
}
