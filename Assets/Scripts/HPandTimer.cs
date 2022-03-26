using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPandTimer : MonoBehaviour
{
    [SerializeField]
    private Text Timertext;
    private int timer = 181;
    private int HP = 100;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimingSystem());
    }

    // Update is called once per frame
    IEnumerator TimingSystem()
    {
        while (true)
        {
            for (int i = 0; i < timer; i++)
            {
                timer = timer - 1;
                yield return new WaitForSeconds(1);
            }
        }
    }
   void Update()
    {
        Timertext.text = "Timer = " + timer;        
    }
}
