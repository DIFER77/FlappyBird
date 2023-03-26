using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracker : MonoBehaviour
{
 [SerializeField] private bird _bird;
  [SerializeField] private float _xoffset;
  private void Update()
  {
    transform.position = new Vector3(_bird.transform.position.x - _xoffset,transform.position.y,transform.position.z);
  }
  
}
