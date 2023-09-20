using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

  [SerializeField]
  GameObject explosionPrefab;

  void Start()
  {
    float x = Random.Range(-5f, 5f);
    Vector2 pos = new Vector2(x, Camera.main.orthographicSize + 1);

    transform.position = pos;
  }

  void Update()
  {
    float speed = 4;

    Vector2 movement = Vector2.down * speed * Time.deltaTime;

    transform.Translate(movement);

    if (transform.position.y < -Camera.main.orthographicSize - 1)
    {
      GameObject.Destroy(this.gameObject);
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "bolt" || other.gameObject.tag == "Player")
    {
      Destroy(this.gameObject);
      GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);

      Destroy(explosion, 0.3f);

    }
  }

}
