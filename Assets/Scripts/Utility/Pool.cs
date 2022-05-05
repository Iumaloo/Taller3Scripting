using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pool : MonoBehaviour
{

    [SerializeField]
    int size;

    [SerializeField]
    Rigidbody bulletPrefab;

    private List<Rigidbody> bullets;


    private void Awake()
    {

            PreparePool();
    }

    private void PreparePool()
    {
        bullets = new List<Rigidbody>();
        for (int i = 0; i < size; i++)
        {
            AddBullet();
        }
    }

    private void AddBullet()
    {
        Rigidbody instance = Instantiate(bulletPrefab);
        instance.gameObject.GetComponent<Bullet>().OnHit += ReleaseBullet;
        instance.gameObject.SetActive(false);
        bullets.Add(instance);
    }

    public Rigidbody GetBullet()
    {
        if(bullets.Count == 0)
        {
            AddBullet();
        }
        return AllocateBullet();
    }

    public void ReleaseBullet(Rigidbody bullet)
    {
        Debug.Log("Reciclada");
        bullet.gameObject.SetActive(false);
        bullets.Add(bullet);
    }

    private Rigidbody AllocateBullet()
    {
        Rigidbody bullet = bullets[bullets.Count - 1];
        bullets.RemoveAt(bullets.Count - 1);
        bullet.gameObject.SetActive(true);
        return bullet;
    }


}
