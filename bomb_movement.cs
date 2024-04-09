using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedofBomb;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - speedofBomb);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Destroy(gameObject);
        }

    }
}
