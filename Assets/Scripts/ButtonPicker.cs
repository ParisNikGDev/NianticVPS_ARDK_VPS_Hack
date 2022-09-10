using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonPicker : MonoBehaviour
{
    private float OnPressScale = 0.9f;


    private Texture thisTexture;
    void Start()
    {

        thisTexture = this.GetComponent<RawImage>().texture;
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("You have clicked the button!");
        StartCoroutine(ClickAnimation());

        var theRend = F4_Manager.instance.wayspotAnchorExampleManager.anchor.GetComponent<AnchorScreenToWorld>();
        F4_Manager.instance.wayspotAnchorExampleManager.anchor.SetActive(true);
        theRend.newText = this.thisTexture;
        theRend.rend.material.mainTexture = thisTexture;   
    }

    IEnumerator ClickAnimation()
    {
        transform.localScale = new Vector3(OnPressScale, OnPressScale, OnPressScale);
        yield return new WaitForSeconds(0.1f);
        transform.localScale = new Vector3(1, 1, 1);
    }
}
