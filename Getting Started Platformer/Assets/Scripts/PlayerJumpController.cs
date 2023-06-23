using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{
    [SerializeField]
    private float _jumpPower = 15;
    private Rigidbody2D _rigidbody;
    private BoxCollider2D _collider;
    [SerializeField]
    private float _distanceDelta;
    [SerializeField]
    private LayerMask _groundMask;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround())
        {
            _rigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
    }

    public bool IsOnGround()
    {
        float distance = _collider.bounds.extents.y + _distanceDelta;
        Debug.DrawRay(transform.position, Vector2.down * distance, Color.green, 1);
        RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, Vector2.down, distance, _groundMask);
        return raycastHit.collider != null;
    }
}
