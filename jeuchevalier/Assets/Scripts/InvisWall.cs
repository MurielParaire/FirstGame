using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisWall : MonoBehaviour
{
    public GameObject DisappearingWall;
    public GameObject[] ListeEnnemies;
    public bool ennemiesmorts = true;
    public int coordonneex;

    // Start is called before the first frame update
    void Start()
    {
        ennemiesmorts = true;
    }

    // Update is called once per frame
    void Update()
    {
        ennemiesmorts = true;
        ListeEnnemies = GameObject.FindGameObjectsWithTag("Ennemie");
        //Debug.Log(ListeEnnemies.Length);
        //Debug.Log("Test");
        for (int i = 0; i < ListeEnnemies.Length; i++)
        {
            //Debug.Log(ListeEnnemies[i].transform.position.x);
            if (this.ListeEnnemies[i].transform.position.x < coordonneex)
            {
                ennemiesmorts = false;
            }
        }
        if (ennemiesmorts)
        {
            DisappearingWall.SetActive(false);
        }
        else
        {
            DisappearingWall.SetActive(true);
        }
    }
}