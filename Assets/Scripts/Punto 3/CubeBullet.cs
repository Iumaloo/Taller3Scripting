using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBullet : Bullet
{
    public override void Effect(Collision collider)
    {
        if(collider.gameObject.CompareTag("Wall"))
        collider.gameObject.GetComponent<ColliderInteraction>().DisableCollider();
    }
}
