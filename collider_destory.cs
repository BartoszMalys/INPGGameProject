using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collider_destroy : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" )
        {
            Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
