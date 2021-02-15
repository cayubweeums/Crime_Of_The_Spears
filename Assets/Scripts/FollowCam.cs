using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    public GameObject player;
    public float boundaryPercent;
    public float easing;

    private float lbound;
    private float rbound;
    private float ubound;
    private float dbound;

    // Start is called before the first frame update
    void Start()
    {

        lbound = boundaryPercent * Camera.main.pixelWidth;
        rbound = Camera.main.pixelWidth - lbound;
        dbound = boundaryPercent * Camera.main.pixelHeight;
        ubound = Camera.main.pixelHeight - dbound;

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (player)
        {

            Vector3 spriteLoc = Camera.main.WorldToScreenPoint(player.transform.position);
            Vector3 pos = transform.position;
            if (spriteLoc.x < lbound)
            {
                pos.x -= lbound - spriteLoc.x;
            }else if (spriteLoc.x > rbound)
            {
                pos.x += spriteLoc.x - rbound;
            }

            if (spriteLoc.y < dbound)
            {
                pos.y -= dbound - spriteLoc.y;
            }
            else if (spriteLoc.y > ubound)
            {
                pos.y += spriteLoc.y - ubound;
            }

            pos = Vector3.Lerp(transform.position, pos, easing);

            transform.position = pos;

        }
    }
}
