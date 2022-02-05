using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset; //changes the position of the camera based on it's current position
    private Vector3 newtrans;

    //only applies on x and z axis, as to not follow the player's jumps
    // Start is called before the first frame update
    void Start()
    {
        offset.x = transform.position.x - player.transform.position.x;
        offset.z = transform.position.z - player.transform.position.z;       

        newtrans=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newtrans.x= player.transform.position.x + offset.x;
        if (newtrans.x < -2) 
        {
            newtrans.x = -2;
        } //stops the camera on the left side as to stay on the map  

        newtrans.z= player.transform.position.z + offset.z;
        if (newtrans.x > 222) 
        {
            newtrans.x = 222;
        } //stops the camera on the left side as to stay on the map
        transform.position = newtrans;
    }
}

