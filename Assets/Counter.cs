using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    public int count;

    Text counter;

    private void Awake()
    {
        count = 15;
    }
    void Start () {
        counter = GetComponent<Text>();
        StartCoroutine(StartCounter());
	}

    IEnumerator StartCounter()
    {
        while (count >= 0)
        {
            counter.text = count.ToString();
            count--;    
            yield return new WaitForSeconds(1f);
        }
    }
    private void Update()
    {
        if (count < 10)
            counter.color = Color.red;
    }

}
