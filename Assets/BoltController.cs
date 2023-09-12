using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    float speed = 8;

    Vector2 movement = new Vector2(0, speed) * Time.deltaTime;

    transform.Translate(movement);

    if (transform.position.y > Camera.main.orthographicSize + 1)
    {
      GameObject.Destroy(this.gameObject);
    }
  }
}
