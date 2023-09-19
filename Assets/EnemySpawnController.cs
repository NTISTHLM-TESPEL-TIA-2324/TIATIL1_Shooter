using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
  [SerializeField]
  GameObject enemyPrefab;

  float timer = 0;

  [SerializeField]
  float timeBetweenEnemies = 1.5f;

  void Update()
  {
    timer += Time.deltaTime;

    if (timer > timeBetweenEnemies)
    {
      Instantiate(enemyPrefab);
      timer = 0;
    }
  }
}
