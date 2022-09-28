using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBarrel : MonoBehaviour
{
    public float Speed;
    private void Start()
    {
        Speed = Random.Range(5, 10);
        
    }
    private void Update()
    {
        transform.Translate(Vector3.right * Speed* Time.deltaTime);
        if(transform.position.x > 150)
        {
            Destroy(gameObject);
        }
    }
}
