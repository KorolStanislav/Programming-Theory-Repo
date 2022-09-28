using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Spawn;
    public float BulletSpeed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(BulletPrefab, Spawn.position, Spawn.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = Spawn.forward * BulletSpeed;
          Destroy(newBullet.gameObject,2);
        }
    }
    public void ChooseBullet(GameObject bullet)
    {
        BulletPrefab = bullet;
    }
  
}
