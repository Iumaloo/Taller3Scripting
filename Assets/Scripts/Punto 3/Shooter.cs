using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    CubePool cubePool;
    SpherePool spherePool;
    CapsulePool capsulePool;
    Pool selectedPool;
    private void Start()
    {
        cubePool = GetComponent<CubePool>();
        spherePool = GetComponent<SpherePool>();
        capsulePool = GetComponent<CapsulePool>();

        selectedPool = cubePool;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody bullet = selectedPool.GetBullet();
            bullet.transform.position = transform.position;
        }
    }

    void ChangePool()
    {

    }
}
