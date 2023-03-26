using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : ObjectPool
{
   [SerializeField] private GameObject _template;
   [SerializeField] private float _secondsBetweenSpawn;
   [SerializeField] private float _maxSpwnPositionY;
   [SerializeField] private float _minSpwnPositionY;
   private float _elapsedTime = 0;


private void Start()
{
    Initialize(_template);
}
private void Update()
{
    _elapsedTime += Time.deltaTime;
    if(_elapsedTime > _secondsBetweenSpawn)
    {
        if (TryGetComponent(out GameObject pipe))
        {
            _elapsedTime = 0;
            float spawnPositionY = Random.Range(_minSpwnPositionY, _maxSpwnPositionY);
            Vector3 spawnPoint = new Vector3(transform.position.x, spawnPositionY, transform.position.z);
            pipe.SetActive(true);
            pipe.transform.position = spawnPoint;

            DisableObjectAbroadScreen();
        }
    }
}
}
