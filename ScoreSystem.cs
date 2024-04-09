using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoredisplayer;
    public static float score = 0;
    /*public static int timer;
    public TMP_Text TimerText;*/
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoredisplayer.text = score.ToString();
        
/*        //for level 5->
        timer = (int)(timer + Time.deltaTime);
        TimerText.text = timer.ToString();*/
    }
    
}
