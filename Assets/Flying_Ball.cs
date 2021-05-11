using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying_Ball : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public float aptitude;

    public Vector3 tempPosition;

    // Start is called before the first frame update
    void Start()
    {
        tempPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tempPosition.x += horizontalSpeed;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * aptitude;
        transform.position = tempPosition;
    }
}
