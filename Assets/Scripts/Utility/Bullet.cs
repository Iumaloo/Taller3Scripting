using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Bullet : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    float force;

    public event Action<Rigidbody> OnHit;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnEnable()
    {
        rb.AddForce(Vector3.forward * force);
        Inicializate();
    }

    public virtual void Inicializate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Effect(collision);
    }

    public virtual void Effect(Collision collider)
    {
        OnHit?.Invoke(rb);
    }


    public void BackToPool()
    {
        OnHit?.Invoke(rb);
    }

}
