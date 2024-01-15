using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "2Complete")
        {
            //mr = GetComponent<MeshRenderer>();
            //mr.material.color= Color.red;
            // gameObject.tag = "hits";

            SceneManager.LoadScene("level 3");
            AudioManger.instance.PlaySfx("levelcomplete");

        }

    }
}
