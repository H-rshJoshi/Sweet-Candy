using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class instructions : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 0;
    }
    public void gameplay()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

}
