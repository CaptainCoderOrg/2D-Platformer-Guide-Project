using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{
    [SerializeField]
    private float _jumpPower = 15;
    private Rigidbody2D _rigidbody;
    [SerializeField]
    private bool _isOnGround;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isOnGround)
        {
            _rigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
    }
}
