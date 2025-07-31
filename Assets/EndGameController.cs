using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void on_game_end() {
        StartCoroutine(StartCountdown());
    }

    float currCountdownValue;
    public IEnumerator StartCountdown(float countdownValue = 5)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
        Application.Quit();
    }
}
