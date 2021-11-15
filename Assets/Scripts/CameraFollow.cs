
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    Camera cam;

    private void Awake()
    {
        cam = gameObject.GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
        if (OverworldSwap.undergroundActive == true)
        {
            cam.cullingMask = 4 << 4;
        }
        
    }


}
