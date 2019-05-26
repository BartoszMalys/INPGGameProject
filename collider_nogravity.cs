using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collider_nogravity : MonoBehaviour
{
    public GameObject player;
    public string scen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            SceneManager.LoadScene(scen);
            
    }
}
