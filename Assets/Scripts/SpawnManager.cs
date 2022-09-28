using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnManager : MonoBehaviour
{
    [SerializeField] Transform SpawnTransform;
    public List<GameObject> BarrelPrefab;
    public float _spawnPeriod { get; private set; }
    public int _prefabIndex;
    private float _timer;


   
    //ABSTRACTION
    public  void Spawn()
    {
        _spawnPeriod = 5;
        _timer += Time.deltaTime;
        if (_timer >= _spawnPeriod)
        {
           _timer = 0;
           Instantiate(BarrelPrefab[_prefabIndex], SpawnTransform.position, Quaternion.Euler(-90, 0, 0));
        }
    }
}
