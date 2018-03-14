using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damaged : MonoBehaviour {

    Image im;
    float hp;

	void Start () {
        im = GetComponent<Image>();
        hp = im.rectTransform.localScale.x;
	}

    void Update () {

        if (Input.GetKeyDown(KeyCode.Alpha1))
            im.rectTransform.localScale += Vector3.left * 0.1f;

        if (im.rectTransform.localScale.x <= 0f)
            im.rectTransform.localScale = new Vector3(0f, 1f, 1f);

        //if (im.rectTransform.localScale.x >= 1f)
        //    im.rectTransform.localScale = new Vector3(1f, 1f, 1f);

    }
}
