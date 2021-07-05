﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progile.KeysymHelper
{

    //Source Reference: https://msdn.microsoft.com/en-us/library/windows/desktop/dd375731(v=vs.85).aspx
    public enum Keys
    {
        Unknown = 0x0,
        Cancel = 0x03,
        Backspace = 0x08,
        Tab = 0x09,
        Clear = 0x0C,
        Enter = 0x0D,
        Shift = 0xA0, // Maps to ShiftLeft
        Ctrl = 0xA2,  // Maps to CtrlLeft
        Alt = 0xA4,   // Maps to MenuLeft
        Pause = 0x13,
        Capslock = 0x14,
        Esc = 0x1B,
        Space = 0x20,
        PageUp = 0x21,
        PageDown = 0x22,
        End = 0x23,
        Home = 0x24,
        ArrowLeft = 0x25,
        ArrowUp = 0x26,
        ArrowRight = 0x27,
        ArrowDown = 0x28,
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        Printscreen = 0x2C,
        Insert = 0x2D,
        Delete = 0x2E,
        Help = 0x2F,
        Zero = 0x30,
        One = 0x31,
        Two = 0x32,
        Three = 0x33,
        Four = 0x34,
        Five = 0x35,
        Six = 0x36,
        Seven = 0x37,
        Eight = 0x38,
        Nine = 0x39,
        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,
        WindowsLeft = 0x5B,
        WindowsRight = 0x5C,
        Apps = 0x5D,
        Sleep = 0x5F,
        Numpad0 = 0x60,
        Numpad1 = 0x61,
        Numpad2 = 0x62,
        Numpad3 = 0x63,
        Numpad4 = 0x64,
        Numpad5 = 0x65,
        Numpad6 = 0x66,
        Numpad7 = 0x67,
        Numpad8 = 0x68,
        Numpad9 = 0x69,
        NumpadMultiply = 0x6A,
        NumpadAdd = 0x6B,
        NumpadSeparator = 0x6C,
        NumpadSubtract = 0x6D,
        NumpadDecimal = 0x6E,
        NumpadDevide = 0x6F,
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,
        Numlock = 0x90,
        Scrolllock = 0x91,
        ShiftLeft = 0xA0,
        ShiftRight = 0xA1,
        CtrlLeft = 0xA2,
        CtrlRight = 0xA3,
        MenuLeft = 0xA4,
        AltLeft = 0xA4,
        MenuRight = 0xA5,
        AltRight = 0xA5,
        OEM_PLUS = 0xBB,
        VolumeMute = 0xAD,
        VolumeDown = 0xAE,
        VolumeUp = 0xAF,
        MediaPlayPause = 0xB3,
    }
}