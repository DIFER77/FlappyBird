using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(bird))]
public class BirdCollision : MonoBehaviour
{
  private bird _bird;
  private void Start()
  {
    _bird = GetComponent<bird>();
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if(collision.TryGetComponent(out ScoreZone scorezone))
      _bird.IncreaseScore();
    else
      _bird.Die();
  }
}
