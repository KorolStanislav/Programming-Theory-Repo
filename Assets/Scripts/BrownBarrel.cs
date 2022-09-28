using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownBarrel : Barrel
{
    //INHERITANCE AND POLYMORPHISM
    protected override void MakeScoreOnCollision()
    {
        FindObjectOfType<GameManager>().AddScore(8);
        Destroy(gameObject);
    }
}
