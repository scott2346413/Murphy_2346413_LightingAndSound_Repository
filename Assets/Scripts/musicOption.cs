using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicOption : MonoBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public GameObject audioSource;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(targetPosition, transform.position) > 0.1f)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * 3f);
        }
    }
}
