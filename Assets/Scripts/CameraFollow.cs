using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject PlayerObject;
    [SerializeField] Vector3 _offset = new Vector3(0f, 5f, -7f);
    void LateUpdate()
    {
        transform.position = PlayerObject.transform.position + _offset;
       
    }

}
