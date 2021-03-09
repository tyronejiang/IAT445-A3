using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
  [SerializeField] private string selectableTag = "Selectable";
  [SerializeField] private Material highlightMaterial;
  [SerializeField] private Material defaultMaterial;

  private Transform _selection;

  private void Update()
  {
      // check what has been selected 
      if (_selection != null)
      {
          var selectionRenderer = _selection.GetComponent<Renderer>(); //get object render
          selectionRenderer.material = defaultMaterial; // set object render to default material
          _selection = null;
      }
      // create raycasting
      var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hit;
      if (Physics.Raycast(ray, out hit))
      {
          var selection = hit.transform;
          // check if selected object is selectable
          if (selection.CompareTag(selectableTag))
          {
              var selectionRenderer = selection.GetComponent<Renderer>(); // get object render
              if (selectionRenderer != null)
              {
                selectionRenderer.material = highlightMaterial; // set object render to highlight material
              }
              _selection = selection;
          }
          
      }
  }

}