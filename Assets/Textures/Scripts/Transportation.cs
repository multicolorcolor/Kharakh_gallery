using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Transportation : MonoBehaviour
{
    public GameObject Point01UI;
    public GameObject Point02UI;
    public GameObject Point03UI;
    public GameObject Point04UI;
    public GameObject Point05UI;
    public GameObject Point06UI;
    public GameObject CurrentPointUI;
    public GameObject NextPointUI;
    public Animator Point01Anim;
    public Animator Point02Anim;
    public Animator Point03Anim;
    public Animator Point04Anim;
    public Animator Point05Anim;
    public Animator Point06Anim;
    public Animator CurrentPointAnim;
    public UnityEvent InteractAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        InteractAction.Invoke();
        CurrentPointUI.SetActive(false);
        CurrentPointAnim.Play("Fade");
    }

    public void Point01active()
    {
        Point01Anim.Play("Appear");
        Point01UI.SetActive(true);
        NextPointUI.SetActive(true);
    }

    public void Point02active()
    {
        Point02Anim.Play("Appear");
        Point02UI.SetActive(true);
        NextPointUI.SetActive(true);
    }

    public void Point03active()
    {
        Point03Anim.Play("Appear");
        Point03UI.SetActive(true);
        NextPointUI.SetActive(true);
    }

    public void Point04active()
    {
        Point04Anim.Play("Appear");
        Point04UI.SetActive(true);
        NextPointUI.SetActive(true);
    }

    public void Point05active()
    {
        Point05Anim.Play("Appear");
        Point05UI.SetActive(true);
        NextPointUI.SetActive(true);
    }

    public void Point06active()
    {
        Point06Anim.Play("Appear");
        Point06UI.SetActive(true);
        NextPointUI.SetActive(true);
    }

}

