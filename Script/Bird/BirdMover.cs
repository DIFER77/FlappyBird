using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdMover : MonoBehaviour
{
    // Force
    [SerializeField] private Vector2 _startPosition;
    [SerializeField] private float jumpForce;
    [SerializeField] private float speed;
    
    
    // rotation
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float minRotationZ;
    [SerializeField] private float maxRotationZ;
    
    private Quaternion _minRotation;
    private Quaternion _maxRotation;

    // Physics
    private Rigidbody2D _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = Vector2.zero;
        transform.position = _startPosition;
        _minRotation = Quaternion.Euler(0, 0, minRotationZ);
        _maxRotation = Quaternion.Euler(0, 0, maxRotationZ);
        ResetBird();
    }

    void Update()
    {
          // true || false
          if (Input.GetKeyDown(KeyCode.Space))
          {
              _rigidbody.velocity = Vector2.up * jumpForce + Vector2.right * speed;
              
              transform.rotation = _maxRotation;
          }

          transform.rotation = Quaternion.Lerp(
              transform.rotation, 
              _minRotation,
              Time.deltaTime * rotationSpeed
              );
    }
    public void ResetBird()
    {
        transform.position = _startPosition;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        _rigidbody.velocity = Vector2.zero;
    }
}
