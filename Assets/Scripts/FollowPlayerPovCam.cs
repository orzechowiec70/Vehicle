using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerPovCam : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 1.79f, 0.25f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
