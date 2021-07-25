using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.Characters.ThirdPerson;

public class CharacterControl : MonoBehaviour
{
    public GameObject GirlCharacter;
    public GameObject BoyCharacter;
    public AutoCam autoCam;

    private ThirdPersonUserControl girlThirdPersonUserControl;
    private ThirdPersonUserControl boyThirdPersonUserControl;

    private AICharacterControl girlAICharacterControl;
    private AICharacterControl boyAICharacterControl;

    private NavMeshAgent girlNavMeshAgent;
    private NavMeshAgent boyNavMeshAgent;

    private void Awake()
    {
        girlThirdPersonUserControl = GirlCharacter.GetComponent<ThirdPersonUserControl>();
        girlAICharacterControl = GirlCharacter.GetComponent<AICharacterControl>();
        girlNavMeshAgent = GirlCharacter.GetComponent<NavMeshAgent>();
        boyThirdPersonUserControl = BoyCharacter.GetComponent<ThirdPersonUserControl>();
        boyAICharacterControl = BoyCharacter.GetComponent<AICharacterControl>();
        boyNavMeshAgent = BoyCharacter.GetComponent<NavMeshAgent>();
    }

    public void CharacterChange()
    {
        /// playablecharacterIsAGirl���AGirlCharacter��ThirdPersonCharacter���@�\���Ă���Ƃ��ƒ�`����
        var playableCharacterIsAGirl = GirlCharacter.GetComponent<ThirdPersonUserControl>().enabled;
        /// �����L�����N�^�[�𑀍삵�Ă���Ƃ��A�J�������j���L�����N�^�[��Ǐ]����
        if (playableCharacterIsAGirl == true)
        {
            autoCam.SetTarget(BoyCharacter.transform);
        }
        /// ����ȊO�A�܂�j���L�����N�^�[�𑀍삵�Ă���Ƃ��A�J�����������L�����N�^�[��Ǐ]����
        else
        {
            autoCam.SetTarget(GirlCharacter.transform);
        }
        /// ThirdPersonUserControl��AICharacterControl�Ƃ��؂�ւ����A�����ɋ@�\���Ȃ��悤��
        /// girl��boy�Ƃ̑��삪�؂�ւ����A�����ɑ���\�ɂȂ�Ȃ��悤��
        girlThirdPersonUserControl.enabled = !playableCharacterIsAGirl;
        girlAICharacterControl.enabled = playableCharacterIsAGirl;
        girlNavMeshAgent.enabled = playableCharacterIsAGirl;
        boyThirdPersonUserControl.enabled = playableCharacterIsAGirl;
        boyAICharacterControl.enabled = !playableCharacterIsAGirl;
        boyNavMeshAgent.enabled = !playableCharacterIsAGirl;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CharacterChange();
        }
    }

}