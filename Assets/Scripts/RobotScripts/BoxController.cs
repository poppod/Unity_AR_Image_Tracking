using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class BoxController : MonoBehaviour
{
    [SerializeField]
    GameObject pickupBtn;
    Vector3 boxOrigin=new Vector3(-23.34f,0f,-12.71f);
    Collider playerCollider;
    Button pickup;
    [SerializeField]
    GameObject boxOriginalParent;
    bool boolPckup=false;
    // Start is called before the first frame update
    private void Awake() {
        
    }
    void Start()
    {
        pickupBtn.SetActive(false);
        //pickup=pickupBtn.GetComponent<Button>();
        EventController.ON_TARGET_LOST+=UnPickup;
        EventController.ON_TARGET_LOST+=DisableBtn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag=="Player"){
            if(!boolPckup){
                pickupBtn.SetActive(true);
            }
             playerCollider=other;
        }
       
    }
    private void OnTriggerExit(Collider other) {
        
        if(other.tag=="Player"){
             pickupBtn.SetActive(false);
             playerCollider=null;
             UnPickup();
        }
        if(other.tag=="Finish"){
            UnPickup();
        }
    }
    public void PickUpObject(){
        if(playerCollider!=null){
            transform.position=new Vector3(playerCollider.transform.position.x,playerCollider.transform.position.y+3,playerCollider.transform.position.z);
            transform.SetParent(playerCollider.transform);
            pickupBtn.SetActive(false);
            boolPckup=true;
            //pickup.text="Unpick";
        }
    }
    public void UnPickup(){
        transform.SetParent(boxOriginalParent.transform);
        transform.localPosition=boxOrigin;
        transform.localRotation=Quaternion.Euler(0f,0f,0f);
        boolPckup=false;
        //pickup.text="Pickup";
    }
    void DisableBtn(){
        pickupBtn.SetActive(false);
    }
}
