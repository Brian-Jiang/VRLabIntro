using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneController : MonoBehaviour {
    public Slider slider;

    private AsyncOperation async;

    public void Load(String name) {
        StartCoroutine(LoadScene(name));
    }

    IEnumerator LoadScene(String name) {
        async = SceneManager.LoadSceneAsync(name);
        async.allowSceneActivation = false;
        while(async.progress <= 0.89f){
            slider.value = async.progress;
            yield return null;
        }
        async.allowSceneActivation = true;
    }
}
