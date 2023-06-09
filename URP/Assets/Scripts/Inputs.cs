//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Inputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Inputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""PlayerGameplay"",
            ""id"": ""7809bffd-00c9-4f2c-b3df-b608b9827cd5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e4ff5619-7140-41fd-9f60-4c4cf07c50f8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""5074f0ee-6b6c-4d8b-ab3a-71083cc628f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f7e50188-f878-46ae-bfa3-efa8cf4363b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""1d867037-df68-4fbd-aecc-d1ab50673c54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""fa9c62c8-a8d3-4677-b39b-88c1c4a3ebeb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a464d364-31c7-451c-9d3c-112fdeff2d62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Grenade"",
                    ""type"": ""Button"",
                    ""id"": ""172d08e4-bea2-4a5c-b929-e549bc84b23f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c878af06-9de6-4e0f-a0b6-aa76858cc223"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26b2a9ce-a440-4c64-80a4-71b26cb29e53"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d05524d9-c43b-4469-bd58-316eff213208"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e977d52-9fae-4fb0-97a7-5c84b8c8cd99"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fc8b750-0635-4f82-93ce-c1757705ecc8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5c4cce0-81b1-4397-aa8a-7af88d569fc5"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f92c2db3-215f-49af-8bb5-21d967611dd9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f22ce57e-fded-4645-b076-11f1a5d33916"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""265de0c3-a962-4d33-a081-7d649a543bd2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3008e201-ff58-4695-8a46-4cecaf0f6e9a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3a98487b-9fae-4778-a52f-6d4b92df78ce"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerGameplay
        m_PlayerGameplay = asset.FindActionMap("PlayerGameplay", throwIfNotFound: true);
        m_PlayerGameplay_Movement = m_PlayerGameplay.FindAction("Movement", throwIfNotFound: true);
        m_PlayerGameplay_Aim = m_PlayerGameplay.FindAction("Aim", throwIfNotFound: true);
        m_PlayerGameplay_Shoot = m_PlayerGameplay.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerGameplay_Interact = m_PlayerGameplay.FindAction("Interact", throwIfNotFound: true);
        m_PlayerGameplay_Sprint = m_PlayerGameplay.FindAction("Sprint", throwIfNotFound: true);
        m_PlayerGameplay_Jump = m_PlayerGameplay.FindAction("Jump", throwIfNotFound: true);
        m_PlayerGameplay_Grenade = m_PlayerGameplay.FindAction("Grenade", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerGameplay
    private readonly InputActionMap m_PlayerGameplay;
    private IPlayerGameplayActions m_PlayerGameplayActionsCallbackInterface;
    private readonly InputAction m_PlayerGameplay_Movement;
    private readonly InputAction m_PlayerGameplay_Aim;
    private readonly InputAction m_PlayerGameplay_Shoot;
    private readonly InputAction m_PlayerGameplay_Interact;
    private readonly InputAction m_PlayerGameplay_Sprint;
    private readonly InputAction m_PlayerGameplay_Jump;
    private readonly InputAction m_PlayerGameplay_Grenade;
    public struct PlayerGameplayActions
    {
        private @Inputs m_Wrapper;
        public PlayerGameplayActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerGameplay_Movement;
        public InputAction @Aim => m_Wrapper.m_PlayerGameplay_Aim;
        public InputAction @Shoot => m_Wrapper.m_PlayerGameplay_Shoot;
        public InputAction @Interact => m_Wrapper.m_PlayerGameplay_Interact;
        public InputAction @Sprint => m_Wrapper.m_PlayerGameplay_Sprint;
        public InputAction @Jump => m_Wrapper.m_PlayerGameplay_Jump;
        public InputAction @Grenade => m_Wrapper.m_PlayerGameplay_Grenade;
        public InputActionMap Get() { return m_Wrapper.m_PlayerGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerGameplayActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerGameplayActions instance)
        {
            if (m_Wrapper.m_PlayerGameplayActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnMovement;
                @Aim.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnAim;
                @Shoot.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnShoot;
                @Interact.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnInteract;
                @Sprint.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnSprint;
                @Jump.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnJump;
                @Grenade.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnGrenade;
                @Grenade.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnGrenade;
                @Grenade.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnGrenade;
            }
            m_Wrapper.m_PlayerGameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Grenade.started += instance.OnGrenade;
                @Grenade.performed += instance.OnGrenade;
                @Grenade.canceled += instance.OnGrenade;
            }
        }
    }
    public PlayerGameplayActions @PlayerGameplay => new PlayerGameplayActions(this);
    public interface IPlayerGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnGrenade(InputAction.CallbackContext context);
    }
}
