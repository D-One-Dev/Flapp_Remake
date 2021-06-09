// GENERATED AUTOMATICALLY FROM 'Assets/Input actions/Game.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Game : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Game()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Game"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""125cb675-ecfa-4937-9db5-0c3ab272ecfe"",
            ""actions"": [
                {
                    ""name"": ""Touch"",
                    ""type"": ""Button"",
                    ""id"": ""f1c66ba9-eb71-4b6d-ab3b-0be958b05e4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""01bf779f-fd65-49e0-816b-ab174e60e0c8"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee7c1cd9-bb2e-4a57-84d4-f862ca2d02bd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": []
        },
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": []
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Touch = m_Gameplay.FindAction("Touch", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Touch;
    public struct GameplayActions
    {
        private @Game m_Wrapper;
        public GameplayActions(@Game wrapper) { m_Wrapper = wrapper; }
        public InputAction @Touch => m_Wrapper.m_Gameplay_Touch;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Touch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouch;
                @Touch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouch;
                @Touch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouch;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Touch.started += instance.OnTouch;
                @Touch.performed += instance.OnTouch;
                @Touch.canceled += instance.OnTouch;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnTouch(InputAction.CallbackContext context);
    }
}
