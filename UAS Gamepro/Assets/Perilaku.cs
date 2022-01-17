using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Perilaku : MonoBehaviour
{
    public Text PowerText;
    private string PowerNum;

    void OnCollisionEnter2D(Collision2D coll){
if (coll.gameObject.tag == "enemyTag"){
    if(PowerNum == "Off"){
        Debug.Log("Game Over");
        Die();
    }
    else{
        
    }
    
}
    }

    // Start is called before the first frame update
    void Start()
    {
        PowerNum = "Off";
        PowerText.text = "Power : " +PowerNum;
    }

    private void OnTriggerEnter2D(Collider2D Power){

        if(Power.tag =="powerTag"){

        PowerNum = "On";
        Destroy(Power.gameObject);
        PowerText.text = "Power : " +PowerNum;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void Die(){
        Debug.Log("GAME OVER");
        SceneManager.LoadScene ("Menu");
    }
}
