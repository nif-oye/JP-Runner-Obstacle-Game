using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (transform.position.x < -11.3){
            transform.position = startPos;
        }
    }
}
