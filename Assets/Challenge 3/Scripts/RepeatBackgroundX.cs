using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.y / 2;
    }

    private void Update()
    {
        if (transform.position.x < 11.3f)
        {
            transform.position = startPos;
        }
    }


}


