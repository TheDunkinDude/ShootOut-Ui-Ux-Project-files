using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 3f;

    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
    public GameObject Screen;
    public GameObject pl;
    
  

    public void GameOver(){
        Screen.SetActive(true);
    }


    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "EnemyBullet"){
             Destroy(collision.gameObject);
             health = health - 1;
             if (health == 2){
                Destroy(h1);
             }
             if (health == 1){
                Destroy(h2);
             }
             if (health <= 0){
                Destroy(h3);
                Destroy(pl);
                GameOver();
             }
       }
    }
}

