//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class HealBehaviour : MonoBehaviour //change from monobehaviour to the players generic behaviour!
//{
    
//    public string healButton = "Heal";
//    private int healBool;
//    private bool heal = false;
//    public bool healTrigger = false;

//    //TASSSS!!! CHANGE MONOBEHAVIOUR ALSO CHANGE THE BEHAVIOUR MANG TO WHATEVER U NAMED IT ON THE OTHER SCRIPT THAT YOU ARE CHANGING MONOBEHAVIOUR
//    //TO AND THEN JUST BEHAV MANAGER AND THE CODE CHANGE TO THOSE!!!!!!!!!!!! PLEASEEEEEEEEEEEEEEEE IDK WHAT U SET YOURS TO!!!!
//    //I CANT SEE UR SCRIPT SO CHANGE IT HERE AND THEN DELETE THIS PLEASE#!
//    private void Start()
//    {
//        healBool = Animator.StringToHash("Heal");
//        behaviourManager.SubscribeBehaviour(this);
//    }

//    private void Update()
//    {
//        if((Input.GetButtonDown(healButton) || healTrigger) && !behaviorManager.IsOverriding() && !behaviourManager.GetTempLockStatus(behaviourManager.GetDefaultBehaviour))
//        {//if heal button is true then heal it but if the heal trigger is true also heal it so add two codes here together 
//            heal = !heal;
//            healTrigger = false; //setit back to false so it runs once then sets back to false
//            behaviourManager.UnlockTempBehaviour(behaviourManager.GetDefaultBehaviour);

//            if (heal)
//            {
//                behaviourManager.RegisterBehaviour(this.behaviourCode);
//            }
//            else
//            {
//                behaviourManager.GetCamScript.ResetTargetOffsets();
//                behaviourManager.UnregisterBehaviour(this.behaviourCode);
//            }
//        }

//        heal = heal && behaviourManager.IsCurrentBehaviuor(this.behaviourCode);
//        behaviourManager.GetAnim.SetBool(healBool, heal);
//    }

//    public override void LocalFixedUpdate()
//    {
//        AttackManagement(behaviourManager.GetH, behaviourManager.GetV);
//    }
//    void AttackManagement(float horizontal, float vertical)
//    {
//        if(behaviourManager.GetAnim.GetCurrentAnimatorStateInfo ( 0 ).normalizedTime > 1 && !behaviourManager.GetAnim.IsTransition(0))
//        {
//            heal = false;
//            behaviourManager.GetAnim.SetBool(tauntBool, heal);
//            behaviourManager.UnregisteredBehaviour(this.behaviourCode);
//        }
//    }

//}
