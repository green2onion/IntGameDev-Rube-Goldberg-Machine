using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject toFollow;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Camera c in FindObjectsOfType<Camera>())
        {
            c.enabled = false;
        }
        gameObject.GetComponent<Camera>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float interpolation = speed * Time.deltaTime;
        Vector3 position = transform.position;
        position.x = Mathf.Lerp(transform.position.x, toFollow.transform.position.x, interpolation);
        position.y = Mathf.Lerp(transform.position.y, toFollow.transform.position.y - 2, interpolation);
        position.z = Mathf.Lerp(transform.position.z, toFollow.transform.position.z - 10, interpolation);
        transform.position = position;
    }
}
