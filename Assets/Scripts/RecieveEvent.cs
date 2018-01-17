using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecieveEvent : MonoBehaviour {

    private bool isTouch;
    private GameObject parent;

    private void Start()
    {
        isTouch = false;

        parent = transform.root.gameObject;
    }

    private void Update()
    {
        if ( isTouch )
        {

            if (OVRInput.GetDown(OVRInput.RawButton.A))
            {
                SceneManager.LoadScene("Test");
            }
        }
    }

    public void touchObject()
    {
        isTouch = true;
        parent.GetComponent<RectTransform>().sizeDelta = new Vector2(parent.GetComponent<RectTransform>().sizeDelta.x * 2f, parent.GetComponent<RectTransform>().sizeDelta.y * 2f);
    }

    public void unTouchObject()
    {
        isTouch = false;
        parent.GetComponent<RectTransform>().sizeDelta = new Vector2(parent.GetComponent<RectTransform>().sizeDelta.x * 0.5f, parent.GetComponent<RectTransform>().sizeDelta.y * 0.5f);
    }
}
