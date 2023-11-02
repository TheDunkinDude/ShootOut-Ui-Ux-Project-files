using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urlbuttons : MonoBehaviour
{
      public void OpenURL()
      {
          Application.OpenURL("https://forms.gle/NdrLGQMQrsj1imHu7");
          Debug.Log("is this working?");
      }
}
