using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float speed = 2; // rutor per sekund

    float moveX = Input.GetAxisRaw("Horizontal");

    Vector2 movement = new Vector2(speed, 0) * moveX * Time.deltaTime;

    transform.Translate(movement);

  }
}
