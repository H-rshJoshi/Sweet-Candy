using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Basket_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedofBasket;
    public GameObject[] lives;
    public static int life = 3;
    public static int candy_touches_ground = 0;
    public GameObject gameover;
    public GameObject levelcompleteUI;
    public AudioSource candy_collision;
    public AudioSource bomb_collision;
    public AudioSource levelcompleteSound;
    public AudioSource GameOverSound;
    public int candytouchgameOver;
    public int ScoreTarget;
    public GameObject explosion;
    /*public int timeout;*/
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        transform.position = new Vector2(Mathf.Clamp(transform.position.x + speedofBasket * xinput, -2, 2), transform.position.y);

        if (life < 3)
        {
            lives[life].SetActive(false);
        }
        if (candy_touches_ground == candytouchgameOver)
        {
            life--;
            candy_touches_ground = 0;
        }
        if (life <=0)
        {
            gameover.SetActive(true);
            GameOverSound.Play();
            gameObject.SetActive(false);
        }
        if(ScoreSystem.score == ScoreTarget)
        {
            levelcompleteUI.SetActive(true);
            levelcompleteSound.Play();
        }

        /*if (ScoreSystem.timer == timeout && ScoreSystem.score != 50)
        {
            gameover.SetActive(true);
            GameOverSound.Play();
            gameObject.SetActive(false);
        }*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "candy")
        {
            ScoreSystem.score++;
            candy_collision.Play();
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "bomb")
        {
            life--;
            bomb_collision.Play();
            Destroy(collision.gameObject);
            var clone = Instantiate(explosion, transform.position, explosion.transform.rotation);
            Destroy(clone,1.25f);
        }
        if(collision.gameObject.tag == "BadCandy")
        {
            if(ScoreSystem.score > 0)
            {
                ScoreSystem.score--;
            }
            Destroy(collision.gameObject);
        }
    }

}
