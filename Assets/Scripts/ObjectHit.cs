using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer mr;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //mr = GetComponent<MeshRenderer>();
            //mr.material.color= Color.red;
            // gameObject.tag = "hits";
            AudioManger.instance.PlaySfx("end");
            SceneManager.LoadScene("end");
            

        }
        
    }
}
