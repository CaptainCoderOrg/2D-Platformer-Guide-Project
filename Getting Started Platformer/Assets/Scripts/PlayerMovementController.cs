using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5;
    private Rigidbody2D _rigidbody;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float leftRight = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(leftRight * _speed, _rigidbody.velocity.y);
    }
}
