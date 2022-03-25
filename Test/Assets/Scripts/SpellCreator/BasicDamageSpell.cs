using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDamageSpell 
{
    private int damage;
    private float knockback;
    private float speed;
    private float duration;
// Size is the AoE
    private float size;
    public int getDamage { get { return damage; } }
    public float getKnockback { get { return knockback;}}
    public float getSpeed { get { return speed; } }
    public float getDuration { get { return duration; } }
    public float getSize { get { return size; } }

    public BasicDamageSpell(int Setdamage, float Setknockback, float Setspeed, float Setduration, float Setsize)
    {
        damage = Setdamage;
        knockback = Setknockback;
        speed = Setspeed;
        duration = Setduration;
        size = Setsize;
    }
}
