using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine;

public class AddressablesExample : MonoBehaviour 
{
    GameObject myGameObject;
    
    async void Start()
    {
        // 콜백 방식
        Addressables.LoadAssetAsync<GameObject>("AssetAddress").Completed += OnLoadDone;
        
        // 대기 방식
        var asset = await Addressables.LoadAssetAsync<GameObject>("AssetAddress").Task;
    }
    
    private void OnLoadDone(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj)
    {
        // In a production environment, you should add exception handling to catch scenarios such as a null result.
        myGameObject = obj.Result;
    }
}
