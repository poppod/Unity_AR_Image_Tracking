using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour
{
    [SerializeField]
    GameObject btnObject;
    [SerializeField]
    GameObject scriptObject;
    [SerializeField]
    Transform pos1;
    [SerializeField]
    Transform pos2;
    [SerializeField]
    Transform pos3;
    ButtonAnimation buttonAnimation;
    // Start is called before the first frame update
    void Start()
    {
        buttonAnimation=scriptObject.GetComponent<ButtonAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PopupButton(){
        buttonAnimation.PopUpBtn();
    }
    public void GotoPos1(){
        buttonAnimation.SetPositionBtn(pos1.transform.position);
        PopupButton();
    }
    public void GotoPos2(){
        buttonAnimation.SetPositionBtn(pos2.transform.position);
        PopupButton();
    }
    public void GotoPos3(){
        buttonAnimation.SetPositionBtn(pos3.transform.position);
        PopupButton();
    }
    public void MovedownBtn(){

    }

}
