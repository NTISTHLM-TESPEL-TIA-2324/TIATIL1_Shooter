using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
  

  // Update is called once per frame
  void Update()
  {
    float speed = 5; // rutor per sekund

    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    Vector2 movement = new Vector2(moveX, moveY);
    movement = movement.normalized * speed * Time.deltaTime;

    transform.Translate(movement);

  }
}
