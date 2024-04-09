using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 100;
    public GameObject gameOver;
    public AudioSource GameoverSound;
    public TMP_Text Timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        int timerEditor = (int) timer;
        Timer.text = timerEditor.ToString();
        if (timer == 0)
        {
            gameOver.SetActive(true);
            GameoverSound.Play();
        }
    }
}
