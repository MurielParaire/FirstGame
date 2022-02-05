using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public GameObject Player;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Chevalier_ptut");
        text = GameObject.Find("panel_text");
        text.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x > 20 || this.Player.transform.position.y < 0)
        {
            text.SetActive(false);
        }
    }
}
