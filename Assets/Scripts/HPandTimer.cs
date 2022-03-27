using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPandTimer : MonoBehaviour
{
    [SerializeField]
    private Text Timertext;

    [SerializeField]
    private Text HPText;

    [SerializeField]
    private Button StartButton;

    private int timer = 181;
    private int HP = 100;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = StartButton.GetComponent<Button>();
        btn.onClick.AddListener(Started);
        Timertext.gameObject.SetActive(false);
        HPText.gameObject.SetActive(false);
        
    }

    void Started()
    {
        StartCoroutine(TimingSystem());
        Timertext.gameObject.SetActive(true);
        HPText.gameObject.SetActive(true);
    }
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
        HPText.text = HP + " HP";
    }
}
