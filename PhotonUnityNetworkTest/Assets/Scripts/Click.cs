using UnityEngine;
using System.Collections;
using ExitGames.Client.Photon;
using UnityEngine.UI;
public class Click : MonoBehaviour
{
    public GameObject prefab;
  //  public Button btn ;
    public GameObject ga;
    void Start()
    {
         Button btn = this.GetComponent<Button> ();
        btn.onClick.AddListener (OnClick);
    }

    
    void OnClick()
    {
        Debug.Log(InputToEvent.inputHitPos);
        ga =  PhotonNetwork.Instantiate(prefab.name, InputToEvent.inputHitPos, Quaternion.identity, 0);

    }


    private void Update() {
        if (Input.GetKey(KeyCode.DownArrow)){
                ga.transform.Rotate(Vector3.up);
        }
    }

/* 
    void Start () {
        Button btn = this.GetComponent<Button> ();
        btn.onClick.AddListener (OnClick);
    }

    private void OnClick(){
        Debug.Log ("Button Clicked. ClickHandler.");
    }

    */

}

