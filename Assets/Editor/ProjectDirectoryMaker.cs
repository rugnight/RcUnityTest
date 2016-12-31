using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

static public class ProjectDirectoryMaker {

    [MenuItem("RC/シーン用フォルダセットを作成")]
    static public void MakeProjectFolders() {
        if ( !AssetDatabase.IsValidFolder("Assets/Scenes")) {
            AssetDatabase.CreateFolder("Assets", "Scenes");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Prefabs")) {
            AssetDatabase.CreateFolder("Assets", "Prefabs");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Scripts")) {
            AssetDatabase.CreateFolder("Assets", "Scripts");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Animations")) {
            AssetDatabase.CreateFolder("Assets", "Animations");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Materials")) {
            AssetDatabase.CreateFolder("Assets", "Materials");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Physics Materials")) {
            AssetDatabase.CreateFolder("Assets", "Physics Materials");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Fonts")) {
            AssetDatabase.CreateFolder("Assets", "Fonts");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Textures")) {
            AssetDatabase.CreateFolder("Assets", "Textures");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Audio")) {
            AssetDatabase.CreateFolder("Assets", "Audio");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Resources")) {
            AssetDatabase.CreateFolder("Assets", "Resources");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Editor")) {
            AssetDatabase.CreateFolder("Assets", "Editor");
        }
        if ( !AssetDatabase.IsValidFolder("Assets/Plugins")) {
            AssetDatabase.CreateFolder("Assets", "Plugins");
        }



        //foreach(string guid in Selection.assetGUIDs) {
        //    string path = AssetDatabase.GUIDToAssetPath(guid);
        //    if ( AssetDatabase.IsValidFolder(path) ) {
        //        AssetDatabase.CreateFolder(path, "");
        //    }
        //}
    }
}
