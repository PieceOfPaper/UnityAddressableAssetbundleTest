using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.U2D;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Addressables.LoadAssetAsync<SpriteAtlas>("Atlas/Buttons").Completed += OnLoadAtlas;;
        Addressables.LoadAssetAsync<GameObject>("Assets/UI Prefabs/TestUI.prefab").Completed += OnLoadPrefab;;
    }

    private void OnLoadAtlas(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<SpriteAtlas> handle)
    {
        Debug.Log($"OnLoadAtlas - {(handle.Result == null ? "NULL" : handle.Result.name)}");
    }
    
    private void OnLoadPrefab(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> handle)
    {
        Debug.Log($"OnLoadPrefab - {(handle.Result == null ? "NULL" : handle.Result.name)}");
        GameObject.Instantiate(handle.Result);
    }
}
