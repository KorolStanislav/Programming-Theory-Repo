using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBarrel : Barrel
{
    //INHERITANCE AND POLYMORPHISM
    protected override void MakeScoreOnCollision()
    {
        FindObjectOfType<GameManager>().AddScore(3);
        Destroy(gameObject);
    }
}
