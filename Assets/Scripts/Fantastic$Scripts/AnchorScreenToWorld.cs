using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnchorScreenToWorld : MonoBehaviour
{
    public GameObject user;
    private bool _init = false;
    public bool init
    {
        get { return _init; }
        set
        {
            if (!value)
            {
                curved.SetActive(false);
                straight.SetActive(true);
                Debug.Log("Destroyed the old and added the new");
                //straight.transform.position = Vector3.zero;
                //straight.transform.localScale = Vector3.one * 3;
                //straight.transform.rotation = Quaternion.identity;
                rend = straight.transform.GetComponentInChildren<Renderer>();
                rend.material.mainTexture = newText;
            }
            _init = value;
        }
    }
    public Texture newText;
    public GameObject curved;
    public GameObject straight;
    public GameObject spray;
    public Button btn;
    public Renderer rend;

    // Start is called before the first frame update
    void Awake()
    {
        newText = this.GetComponentInChildren<Renderer>().material.mainTexture;
        rend = curved.GetComponentInChildren<Renderer>();
        init = true;
    }
    public void SprayMode(bool a)
    {
        if (a)
        {
            straight.SetActive(false);
            curved.SetActive(false);
            spray.SetActive(true);
            btn.onClick.AddListener(()=>throwSpray());
        }
        else
        {
            straight.SetActive(true);
            curved.SetActive(true);
            spray.SetActive(false);
            btn.onClick.RemoveAllListeners();
        }
    }
    private void throwSpray()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!init) return;
        this.transform.position = user.transform.position + (user.transform.forward*0.5f);
        this.transform.LookAt(user.transform);
    }
}
