using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleBullet : Bullet
{
    [SerializeField]
    ParticleSystem particles;

    MeshRenderer PrefabRenderer;

    public override void Effect(Collision collider)
    {
        particles.Play();
        if (PrefabRenderer == null)
            PrefabRenderer = GetComponent<MeshRenderer>();
        PrefabRenderer.enabled = false;

    }

    public override void Inicializate()
    {
        if (PrefabRenderer == null)
            PrefabRenderer = GetComponent<MeshRenderer>();

        PrefabRenderer.enabled = true;
    }
}
