using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColliderInteraction : MonoBehaviour
{
    BoxCollider Wallcollider;

    public Action OnColliderDisable;
    public Action OnColliderEnable;

    float timer;
    bool colliderDisabled;

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
            OnColliderEnable?.Invoke();
        }
    }
}
