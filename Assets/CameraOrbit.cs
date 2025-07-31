using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{

    public Transform pivot;
    public float sensitivity;
    public float scroll_sensitivity;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance += Input.GetAxis("Mouse ScrollWheel") * scroll_sensitivity;

        this.transform.position = pivot.transform.position;

        float delta_x = 0;
        float delta_y = 0;
        if(Input.GetMouseButton(1)) {
            delta_x = Input.GetAxis("Mouse X") * sensitivity;
            delta_y = Input.GetAxis("Mouse Y") * sensitivity;
        }

        this.transform.rotation = Quaternion.AngleAxis(delta_x, Vector3.up) * this.transform.rotation * Quaternion.AngleAxis(delta_y, Vector3.right);
        this.transform.Translate(Vector3.back * distance);
    }
}
