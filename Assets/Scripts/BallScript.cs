using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallScript : MonoBehaviour
{
    public Transform respawn_point;

    public UnityEvent ball_reset_anim_start_event;
    public UnityEvent ball_reset_event;
    public UnityEvent ball_reset_anim_end_event;
    public UnityEvent ball_won_event;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "hole") {
            reset_position();
        }
        if (collider.gameObject.tag == "final_hole") {
            stop_rigidbody();
            ball_won_event.Invoke();
        }
    }


    void reset_position() {
        ball_reset_anim_start_event.Invoke();
        this.GetComponent<Animator>().SetTrigger("reset");
        stop_rigidbody();
    }


    void animation_event_ball_shrinked() {
        this.transform.position = respawn_point.position;
        ball_reset_event.Invoke();
    }

    void animaiton_event_reset_animation_done() {
        ball_reset_anim_end_event.Invoke();
        this.GetComponent<Rigidbody>().isKinematic = false;
    }

    void stop_rigidbody() {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.Sleep();
        rb.isKinematic = true;
    }
}
