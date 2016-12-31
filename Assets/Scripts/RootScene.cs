using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(CoMain());
    }

    IEnumerator CoMain() {
        yield return RC.SceneTree.CoLoadScene(gameObject.scene, "Logo", RC.SceneTree.LoadOption.SceneEnd);

        yield return RC.SceneTree.CoLoadScene(gameObject.scene, "Title", RC.SceneTree.LoadOption.SceneEnd);

        //yield return LoadScene("Title", LoadOption.LoadEnd);
    }
}
