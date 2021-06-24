using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject btnObject;
    // Start is called before the first frame update
    void Start()
    {
        btnObject.SetActive(false);
        EventController.ON_TARGET_LOST+=ResetBtn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PopUpBtn(){
        btnObject.SetActive(true);
        LeanTween.moveY(btnObject,btnObject.transform.position.y+1.5f,.5f).setEaseOutCubic();

    }
    public void PopdownBtn(){
        LeanTween.moveY(btnObject,btnObject.transform.position.y-1.5f,.5f).setEaseInCubic().setOnComplete(()=>{
            ResetBtn();
        });

    }
    public void ResetBtn(){
        btnObject.transform.localPosition=Vector3.zero;
        btnObject.SetActive(false);
    }
    public void SetPositionBtn(Vector3 pos){
        btnObject.transform.position=new Vector3( pos.x,pos.y+5f,pos.z);

    }
}
