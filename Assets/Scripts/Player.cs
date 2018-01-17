using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>

public class Player : MonoBehaviour {

	// パネル1のシーン遷移（パネルに触れていて、aボタンを押したら）
    void update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "panel1")
        {
            if (OVRInput.GetDown(OVRInput.RawButton.A))
            {
                Debug.Log("シーン1遷移");
            }
        }

        if (collision.gameObject.name == "panel2")
        {
            if (OVRInput.GetDown(OVRInput.RawButton.A))
            {
                Debug.Log("シーン2遷移");
            }
        }
    }

}
