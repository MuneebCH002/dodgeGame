using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin_2 : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "level2")
        {
            //mr = GetComponent<MeshRenderer>();
            //mr.material.color= Color.red;
            // gameObject.tag = "hits";
            Debug.Log("level 2 completed");
            SceneManager.LoadScene("level 3");
            AudioManger.instance.PlaySfx("levelcomplete");

        }

    }
}
