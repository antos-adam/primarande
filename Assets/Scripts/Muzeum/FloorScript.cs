using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FloorScript : MonoBehaviour
{
    public Text ChybyText;
    public int PocetChybProhra;
    public GameObject postup;

    private int _chyby;

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.CompareTag("Item"))
        {
                collider.gameObject.SetActive(false);
                GameObject[] itemy = GameObject.FindGameObjectsWithTag("Item");
                if(itemy.Length >= 4) {
                    itemy[0].GetComponent<Rigidbody2D>().WakeUp();
                    itemy[1].GetComponent<Rigidbody2D>().WakeUp();
                    itemy[2].GetComponent<Rigidbody2D>().WakeUp();
                    itemy[3].GetComponent<Rigidbody2D>().WakeUp();
                } 
                else if (itemy.Length != 0) itemy[0].GetComponent<Rigidbody2D>().WakeUp();
                else {
                    postup.SetActive(true);
                    Time.timeScale = 0;
                }
        }
    }
}
