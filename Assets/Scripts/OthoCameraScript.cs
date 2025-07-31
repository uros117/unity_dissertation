using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OthoCameraScript : MonoBehaviour
{
    public Transform focus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(focus.position.x, 10.0f, focus.position.z);
        
    }
}
