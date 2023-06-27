using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _minX;
    [SerializeField]
    private float _maxX;

    // Update is called once per frame
    void Update()
    {
        Camera camera = GetComponent<Camera>();
        float height = camera.orthographicSize;
        float width = height * camera.aspect;
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(_target.position.x, _minX + width, _maxX - width);
        transform.position = position;
    }
}
