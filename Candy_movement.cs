using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Candy_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedofCandy;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - speedofCandy);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Basket_movement.candy_touches_ground++;
            Destroy(gameObject);
        }
    }

}
