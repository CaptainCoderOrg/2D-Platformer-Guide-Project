using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5;
    // Update is called once per frame
    void Update()
    {
        float leftRight = Input.GetAxis("Horizontal");
        transform.position += _speed * leftRight * Vector3.right * Time.deltaTime; 
    }
}
