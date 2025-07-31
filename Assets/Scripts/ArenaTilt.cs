using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaTilt : MonoBehaviour
{
    [Range(-30.0f, 30.0f)]
    public float angle_x;

    [Range(-30.0f, 30.0f)]
    public float angle_z;

    public float angle_speed;

    [Range(0.0f, 1.0f)]
    public float return_koef;

    private bool is_input_running = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (is_input_running) {
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow)) {

            } else if (Input.GetKey(KeyCode.UpArrow)) {
                angle_x += angle_speed * Time.deltaTime;
            } else if (Input.GetKey(KeyCode.DownArrow)) {
                angle_x -= angle_speed * Time.deltaTime;
            } else {
                angle_x -= angle_x * Time.deltaTime * return_koef;
            }

            if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow)) {

            } else if (Input.GetKey(KeyCode.LeftArrow)) {
                angle_z += angle_speed * Time.deltaTime;
            } else if (Input.GetKey(KeyCode.RightArrow)) {
                angle_z -= angle_speed * Time.deltaTime;
            } else {
                angle_z -= angle_z * Time.deltaTime * return_koef;
            }
        }

        angle_x = Mathf.Clamp(angle_x, -30.0f, 30.0f);
        angle_z = Mathf.Clamp(angle_z, -30.0f, 30.0f);

        this.GetComponent<Transform>().rotation = Quaternion.Euler(angle_x, 0, angle_z);
    }
    
    public void on_ball_reset() {
        is_input_running = false;
        StartCoroutine(return_to_neutral(angle_x, angle_z, 1.0f));
    }

    public void on_ball_reset_done() {
        is_input_running = true;
    }

    public void stop_input() {
        is_input_running = false;
    }


    IEnumerator return_to_neutral(float start_x, float start_z, float duration)
    {
        float timestep = 0;
        while(timestep <=duration)
        {
            timestep = timestep + Time.deltaTime;
            float step = Mathf.Clamp01(timestep / duration);
            angle_x = Mathf.Lerp(start_x, 0.0f, step);
            angle_z = Mathf.Lerp(start_z, 0.0f, step);
            yield return null;
        }
    }
}
