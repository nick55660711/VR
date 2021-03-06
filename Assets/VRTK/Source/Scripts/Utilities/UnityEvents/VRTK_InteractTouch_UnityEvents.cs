﻿namespace VRTK.UnityEventHelper
{
    using UnityEngine.UI;
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    [AddComponentMenu("VRTK/Scripts/Utilities/Unity Events/VRTK_InteractTouch_UnityEvents")]
    public sealed class VRTK_InteractTouch_UnityEvents : VRTK_UnityEvents<VRTK_InteractTouch>
    {
        [Serializable]
        public sealed class ObjectInteractEvent : UnityEvent<object, ObjectInteractEventArgs> { }

        public ObjectInteractEvent OnControllerStartTouchInteractableObject = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerTouchInteractableObject = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerStartUntouchInteractableObject = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerUntouchInteractableObject = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerRigidbodyActivated = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerRigidbodyDeactivated = new ObjectInteractEvent();

        protected override void AddListeners(VRTK_InteractTouch component)
        {
            component.ControllerStartTouchInteractableObject += ControllerStartTouchInteractableObject;
            component.ControllerTouchInteractableObject += ControllerTouchInteractableObject;
            component.ControllerStartUntouchInteractableObject += ControllerStartUntouchInteractableObject;
            component.ControllerUntouchInteractableObject += ControllerUntouchInteractableObject;
            component.ControllerRigidbodyActivated += ControllerRigidbodyActivated;
            component.ControllerRigidbodyDeactivated += ControllerRigidbodyDeactivated;
        }

        protected override void RemoveListeners(VRTK_InteractTouch component)
        {
            component.ControllerStartTouchInteractableObject -= ControllerStartTouchInteractableObject;
            component.ControllerTouchInteractableObject -= ControllerTouchInteractableObject;
            component.ControllerStartUntouchInteractableObject -= ControllerStartUntouchInteractableObject;
            component.ControllerUntouchInteractableObject -= ControllerUntouchInteractableObject;
            component.ControllerRigidbodyActivated -= ControllerRigidbodyActivated;
            component.ControllerRigidbodyDeactivated -= ControllerRigidbodyDeactivated;
        }

        private void ControllerStartTouchInteractableObject(object o, ObjectInteractEventArgs e)
        {

            OnControllerStartTouchInteractableObject.Invoke(o, e);

            if (e.target.name == "Cube" )
            {
                GameObject.Find("RawImage").GetComponent<RawImage>().enabled = true;
                e.target.GetComponent<Rigidbody>().AddForce(400, 400, 400);
                GameObject.Find("TextUI").GetComponent<Text>().text = "Fly Box";
                GameObject.Find("RawImage").GetComponent<RawImage>().texture = Miyamoto;
            } 
            
            else if (e.target.name == "Door" )
            {
                GameObject.Find("RawImage").GetComponent<RawImage>().enabled = true;
                GameObject.Find("TextUI").GetComponent<Text>().text = "Door can open";
                GameObject.Find("RawImage").GetComponent<RawImage>().texture = Miyabi;
                e.target.GetComponentInParent<OpenDoor>().trigger();


            }
            
            else
            {
                GameObject.Find("RawImage").GetComponent<RawImage>().enabled = false;
                //GameObject.Find("RawImage").GetComponent<RawImage>().texture = Nozomi;

            }
            
                /*
                CancelInvoke();
                Invoke("clean",3);
                */
        }

        




        public Texture Miyabi;
        public Texture Nozomi;
        public Texture Miyamoto;


        public void clean()
        {
            GameObject.Find("RawImage").GetComponent<RawImage>().enabled = false;
            GameObject.Find("TextUI").GetComponent<Text>().text = "";
        }


        private void ControllerTouchInteractableObject(object o, ObjectInteractEventArgs e)
        {
            OnControllerTouchInteractableObject.Invoke(o, e);
        }

        private void ControllerStartUntouchInteractableObject(object o, ObjectInteractEventArgs e)
        {
            OnControllerStartUntouchInteractableObject.Invoke(o, e);
        }

        private void ControllerUntouchInteractableObject(object o, ObjectInteractEventArgs e)
        {
            OnControllerUntouchInteractableObject.Invoke(o, e);
        }

        private void ControllerRigidbodyActivated(object o, ObjectInteractEventArgs e)
        {
            OnControllerRigidbodyActivated.Invoke(o, e);
        }

        private void ControllerRigidbodyDeactivated(object o, ObjectInteractEventArgs e)
        {
            OnControllerRigidbodyDeactivated.Invoke(o, e);
        }
    }
}