using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparitionEnnemies : MonoBehaviour
{
    public GameObject[] ListeEnnemies;
    public GameObject player;
    public int Coordoneex;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Chevalier_ptut");
        for (int i = 0; i < ListeEnnemies.Length; i++)
        {
            if (ListeEnnemies[i])
            {
                ListeEnnemies[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("x " + this.player.transform.position.x);
        if (this.player.transform.position.x > Coordoneex)
        {
            for (int i = 0; i < ListeEnnemies.Length; i++)
            {
                if (ListeEnnemies[i])
                {
                    ListeEnnemies[i].SetActive(true);
                }
            }
        }
    }
}