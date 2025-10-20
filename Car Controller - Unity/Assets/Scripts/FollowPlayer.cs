using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Player;
    public bool frstPerson = false;
    private Vector3 offset = new Vector3(0, 5, -7);
    public TextMeshProUGUI camaraText;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
        if(frstPerson)transform.rotation = Player.transform.rotation;
        else transform.rotation = Quaternion.Euler(16, 0, 0);

    }
    
    public void ChangeCamara(){
        
        if (!frstPerson){
            offset = new Vector3(0.02f, 3.26f, 0.5f);
            camaraText.text = "Third\nPerson\nView";
        }else {
            offset = new Vector3(0, 5, -7);
            camaraText.text = "First\nPerson\nView";
        }
        frstPerson = !frstPerson;
        
    }
    
}
