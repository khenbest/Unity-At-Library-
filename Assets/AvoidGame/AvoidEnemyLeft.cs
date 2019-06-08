using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidEnemyLeft : MonoBehaviour
{
    [Range(0, 6)]
    public float Speed = 2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * Speed);
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
