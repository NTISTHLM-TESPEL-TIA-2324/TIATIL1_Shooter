using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

  [SerializeField]
  float speed = 5; // rutor per sekund

  [SerializeField]
  GameObject bulletPrefab;

  [SerializeField]
  Transform gunPosition;

  float shotTimer = 0;
  
  [SerializeField]
  float timeBetweenShots = 0.5f;

  // Update is called once per frame
  void Update()
  {

    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    Vector2 movement = new Vector2(moveX, moveY);
    movement = movement.normalized * speed * Time.deltaTime;

    transform.Translate(movement);

    // Skjutakod
    shotTimer += Time.deltaTime;

    if (Input.GetAxisRaw("Fire1") > 0 && shotTimer > timeBetweenShots)
    {
      Instantiate(bulletPrefab, gunPosition.position, Quaternion.identity);
      shotTimer = 0;
    }
  }
}
