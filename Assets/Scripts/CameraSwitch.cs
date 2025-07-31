using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject parallel_camera;
    public GameObject ortho_camera;
    // Start is called before the first frame update
    void Start()
    {
        parallel_camera.SetActive(true);
        ortho_camera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)) {
            if(parallel_camera.activeSelf) {
                parallel_camera.SetActive(false);
                ortho_camera.SetActive(true);
            } else {
                parallel_camera.SetActive(true);
                ortho_camera.SetActive(false);
            }
        }
        
    }
}
