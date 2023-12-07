using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public GameObject lightOn;
    public GameObject lightOn1;
    public GameObject lightOn2;
    public GameObject lightOn3;
    public GameObject lightOn4;
    public GameObject lightOn5;
    public GameObject lightOn6;
    public GameObject lightOff;
    public GameObject lightOff1;
    public GameObject lightOff2;
    public GameObject lightOff3;
    public GameObject lightOff4;
    public GameObject lightOff5;
    public GameObject lightOff6;
    public GameObject door;
    public GameObject doorAnimation;
    public GameObject theCube;
    public GameObject labDoor;
    public GameObject labLight;
    public GameObject labLight1;
    public GameObject labLight2;
    public GameObject labLight3;
    public GameObject labOff;
    public GameObject labOff1;
    public GameObject labOff2;
    public GameObject labOff3;
    public GameObject theBed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DoorwayTrigger"))
        {
            other.gameObject.SetActive(false);
            StartCoroutine(LightsOut());
        }
        if (other.gameObject.CompareTag("StairTrigger"))
        {
            other.gameObject.SetActive(false);
            door.SetActive(false);
            StartCoroutine(DoorSlam());
        }
        if (other.gameObject.CompareTag("OtherEndTrigger"))
        {
            other.gameObject.SetActive(false);
            theCube.SetActive(true);
        }
        if (other.gameObject.CompareTag("DoorCloseTrigger"))
        {
            other.gameObject.SetActive(false);
            theCube.SetActive(false);
            StartCoroutine(LabDoorSlam());
        }
        if (other.gameObject.CompareTag("BedTrigger"))
        {
            other.gameObject.SetActive(false);
            theBed.SetActive(true);
        }
    }
    IEnumerator DoorSlam()
    {
        doorAnimation.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        lightOn6.SetActive(false);
        lightOff6.gameObject.SetActive(true);
    }
    IEnumerator LabDoorSlam()
    {
        labDoor.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        labLight.SetActive(false);
        labOff.SetActive(true);
        labLight1.SetActive(false);
        labOff1.SetActive(true);
        labLight2.SetActive(false);
        labOff2.SetActive(true);
        labLight3.SetActive(false);
        labOff3.SetActive(true);
    }
    IEnumerator LightsOut()
    {
        lightOn.SetActive(false);
        lightOff.SetActive(true);
        yield return new WaitForSecondsRealtime(0.1f);
        lightOn1.SetActive(false);
        lightOff1.SetActive(true);
        yield return new WaitForSecondsRealtime(0.2f);
        lightOn2.SetActive(false);
        lightOff2.SetActive(true);
        yield return new WaitForSecondsRealtime(0.1f);
        lightOn3.SetActive(false);
        lightOff3.SetActive(true);
        yield return new WaitForSecondsRealtime(0.1f);
        lightOn4.SetActive(false);
        lightOff4.SetActive(true);
        yield return new WaitForSecondsRealtime(0.2f);
        lightOn5.SetActive(false);
        lightOff5.SetActive(true);
    }
}
