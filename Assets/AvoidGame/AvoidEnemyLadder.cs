using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidEnemyLadder : MonoBehaviour
{
    
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = Random.Range(4, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * Speed);
        transform.Translate((Vector2.left * Time.deltaTime * Speed) / 2);


        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > 10f)
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
