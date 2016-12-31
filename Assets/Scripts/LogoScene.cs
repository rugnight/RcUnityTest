using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoScene : MonoBehaviour {

    [SerializeField]
    Animator m_animatorLogo = null;


	// Use this for initialization
	void Start () {
         StartCoroutine(CoMain());
    }

    IEnumerator CoMain() {
        var animState = m_animatorLogo.GetCurrentAnimatorStateInfo(0);

        while(true) {
            animState = m_animatorLogo.GetCurrentAnimatorStateInfo(0);
            if (1.0f <= animState.normalizedTime) {
                break;
            }
            yield return null;
        }
        yield return StartCoroutine(RC.SceneTree.CoUnloadScene(gameObject.scene));
    }
}
