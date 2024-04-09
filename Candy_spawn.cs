using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy_spawn : MonoBehaviour
{
    // Start is called before the first frame update
    float timer;
    public GameObject[] drops;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var obj = Random.Range(0, drops.Length);
        timer = timer + Time.deltaTime;
        if (timer > 2.5f)
        {
            var clone = Instantiate(drops[obj], transform.position, transform.rotation);
            Destroy(clone, 4f);
            timer = 0;
        }
        
    }
    
}
