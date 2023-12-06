using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flickers : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject lightOff;
    public GameObject lightOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 20; i++)
        {
            float time = Random.Range(0.5f, 4.5f);
            StartCoroutine(LightFlicker(time));
        }
    }
    private IEnumerator LightFlicker(float time)
    {
        int pick = Random.Range(0, 2);
        if (pick == 0)
        {
            light2.SetActive(false);
            lightOff.SetActive(false);
            lightOn.SetActive(true);
            light1.SetActive(true);
        }
        else if (pick == 1)
        {
            light1.SetActive(false);
            lightOff.SetActive(false);
            lightOn.SetActive(true);
            light2.SetActive(true);
        }
        else if(pick == 2)
        {
            light1.SetActive(false);
            light2.SetActive(false);
            lightOn.SetActive(false);
            lightOff.SetActive(true);
        }
        yield return new WaitForSecondsRealtime(time);
    }
}
