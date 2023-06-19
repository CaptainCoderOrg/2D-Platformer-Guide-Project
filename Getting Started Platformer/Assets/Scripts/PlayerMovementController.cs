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
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(leftRight * _speed, rigidbody.velocity.y);
    }
}
