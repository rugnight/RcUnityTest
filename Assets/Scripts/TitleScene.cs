using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScene : MonoBehaviour {

    [SerializeField]
    Button m_buttonStart = null;
    [SerializeField]
    Button m_buttonLoad = null;
    [SerializeField]
    Button m_buttonConfig = null;

    // Use this for initialization
    void Start () {
        m_buttonStart.Select();
        m_buttonConfig.onClick.AddListener(() => {
            RC.SceneTree.LoadScene(gameObject.scene, "Config");
        });
    }

    // Update is called once per frame
    void Update () {
	}

}
