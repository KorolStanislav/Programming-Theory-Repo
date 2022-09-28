using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    private float _points;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CannonBall>())
        {
            MakeScoreOnCollision();
        }
    }
   
    protected virtual void MakeScoreOnCollision()
    {
        FindObjectOfType<GameManager>().AddScore(0);
        Destroy(gameObject);
    }
}
