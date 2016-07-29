using UnityEngine;
using System.Collections;
public class TextLayerFix : MonoBehaviour {
    public int SortLayer = 0;
    public int SortingLayerID;
    // Use this for initialization
    void Start () {
        Renderer renderer = this.gameObject.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.sortingOrder = SortLayer;
            renderer.sortingLayerID = SortingLayerID;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
