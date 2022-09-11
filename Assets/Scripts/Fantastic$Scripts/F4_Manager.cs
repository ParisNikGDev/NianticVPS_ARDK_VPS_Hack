using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Niantic.ARDKExamples.WayspotAnchors;
using ARDKExamples.VpsCoverage;

public class F4_Manager : MonoBehaviour
{
    public static F4_Manager instance;
    public VpsCoverageExampleManager vpsCoverageExampleManager;
    public GameObject user;
    public WayspotAnchorController wayspotAnchorExampleManager;
    public GameObject ScreenEmoji;
    [HideInInspector]
    public  GameObject activeAnchorOnScreen;
    // Start is called before the first frame update
    void Start()
    {
        F4_Manager.instance = this;
        wayspotAnchorExampleManager.LocalizationReady += () =>
        {
            Debug.Log("Localization Ready...!!!");
            wayspotAnchorExampleManager.LoadWayspotAnchors();
        };
        NewAnchor();
        //vpsCoverageExampleManager.init();
    }
    public void SliderVal(float v)
    {
        if (v == 0)
        {
            wayspotAnchorExampleManager.anchor.SetActive(false);
            wayspotAnchorExampleManager.anchor.GetComponent<AnchorScreenToWorld>().SprayMode(false);
            WayspotAnchorController.spaymode = false;
        }
        else if (v == 1)
        {
            wayspotAnchorExampleManager.anchor.SetActive(true);
            wayspotAnchorExampleManager.anchor.GetComponent<AnchorScreenToWorld>().SprayMode(true);
            WayspotAnchorController.spaymode = true;

        }
    }
    public void NewAnchor()
    {
        activeAnchorOnScreen = Instantiate(ScreenEmoji, this.transform);
        activeAnchorOnScreen.GetComponent<AnchorScreenToWorld>().user = user;
        wayspotAnchorExampleManager.anchor = activeAnchorOnScreen;
        wayspotAnchorExampleManager.anchor.SetActive(false);
        wayspotAnchorExampleManager.SaveWayspotAnchors();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
