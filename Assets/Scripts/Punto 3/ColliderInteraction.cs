using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColliderInteraction : MonoBehaviour
{
    static private ColliderInteraction instance;

    BoxCollider Wallcollider;

    public Action OnColliderDisable;
    public Action OnColliderEnable;

    float timer;
    bool colliderDisabled;

    public static ColliderInteraction Instance { get => instance;}

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(instance);
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        Wallcollider = GetComponent<BoxCollider>();
    }
    public void DisableCollider()
    {
        Wallcollider.enabled = false;
        OnColliderDisable?.Invoke();
        timer = 1;
        colliderDisabled = true;
    }

    private void Update()
    {
        if (timer > 0 && colliderDisabled)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Wallcollider.enabled = true;
            OnColliderEnable?.Invoke();
        }
    }
}
