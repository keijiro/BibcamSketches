using UnityEngine;

sealed class AppController : MonoBehaviour
{
    void Start()
      => Application.targetFrameRate = 60;
}
