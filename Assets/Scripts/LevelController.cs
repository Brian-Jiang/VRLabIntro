using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {
    public Animator faderAnimator;

    public Image fader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(String name) {
        StartCoroutine(LoadScene(name));
    }

    IEnumerator LoadScene(String name) {
        faderAnimator.SetTrigger("fade");
        yield return new WaitUntil(() => Math.Abs(fader.color.a - 1f) < Mathf.Epsilon);
        SceneManager.LoadScene(name);
    }
}
