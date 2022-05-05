using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBullet : Bullet
{
    public override void Effect(Collision collider)
    {
        base.Effect(collider);
        Debug.Log("Hit");
    }
}
