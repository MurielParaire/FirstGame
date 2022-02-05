using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Quitter;
    public GameObject Recommencer;
    public GameObject Gameover;

    private void Start()
    {
        Quitter = GameObject.Find("Quitter");
        Recommencer = GameObject.Find("Recommencer");
        Gameover = GameObject.Find("Gameover");
    }
    void Update()
    {
        if (PlayerHealth.instance.currentHealth <= 0)
        {
            Quitter.SetActive(true);
            Recommencer.SetActive(true);
            Gameover.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Quitter.SetActive(false);
            Recommencer.SetActive(false);
            Gameover.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
