using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
  [SerializeField]
  GameObject enemyPrefab;

  void Update()
  {
    Instantiate(enemyPrefab);
  }
}
