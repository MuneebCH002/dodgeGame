using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            

            SceneManager.LoadScene("level 2");
            AudioManger.instance.PlaySfx("levelcomplete");

        }

    }
}
