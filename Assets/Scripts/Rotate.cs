using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float _horizontalInput;
    [SerializeField] float _verticalInput;
    [SerializeField] float RotationSpeedX;
    [SerializeField] float RotationSpeedY;
    [SerializeField] float RotationBoundX;
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime * RotationSpeedX * _horizontalInput);
        _verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right, Time.deltaTime * RotationSpeedY * _verticalInput);
    }
}
