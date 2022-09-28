using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBarrel : Barrel
{
    //INHERITANCE AND POLYMORPHISM
    protected override void MakeScoreOnCollision()
    {
        FindObjectOfType<GameManager>().AddScore(5);
        Destroy(gameObject);
    }
}
