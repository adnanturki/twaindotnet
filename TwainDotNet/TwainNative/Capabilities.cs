﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwainDotNet.TwainNative
{
    public enum Capabilities : short
    {
        XferCount = 0x0001,
        ICompression = 0x0100,
        IPixelType = 0x0101,
        IUnits = 0x0102,
        IXferMech = 0x0103,

        Author = 0x1000,
        Caption = 0x1001,
        FeederEnabled = 0x1002,
        FeederLoaded = 0x1003,
        Timedate = 0x1004,
        Supportedcaps = 0x1005,
        Extendedcaps = 0x1006,
        AutoFeed = 0x1007,
        ClearPage = 0x1008,
        FeedPage = 0x1009,
        RewindPage = 0x100a,
        Indicators = 0x100b,
        SupportedCapsExt = 0x100c,
        PaperDetectable = 0x100d,
        UIControllable = 0x100e,
        DeviceOnline = 0x100f,
        AutoScan = 0x1010,
        ThumbnailsEnabled = 0x1011,
        Duplex = 0x1012,
        DuplexEnabled = 0x1013,
        Enabledsuionly = 0x1014,
        CustomdsData = 0x1015,
        Endorser = 0x1016,
        JobControl = 0x1017,
        Alarms = 0x1018,
        AlarmVolume = 0x1019,
        AutomaticCapture = 0x101a,
        TimeBeforeFirstCapture = 0x101b,
        TimeBetweenCaptures = 0x101c,
        ClearBuffers = 0x101d,
        MaxBatchBuffers = 0x101e,
        DeviceTimeDate = 0x101f,
        PowerSupply = 0x1020,
        CameraPreviewUI = 0x1021,
        DeviceEvent = 0x1022,
        SerialNumber = 0x1024,
        Printer = 0x1026,
        PrinterEnabled = 0x1027,
        PrinterIndex = 0x1028,
        PrinterMode = 0x1029,
        PrinterString = 0x102a,
        PrinterSuffix = 0x102b,
        Language = 0x102c,
        FeederAlignment = 0x102d,
        FeederOrder = 0x102e,
        ReAcquireAllowed = 0x1030,
        BatteryMinutes = 0x1032,
        BatteryPercentage = 0x1033,
        CameraSide = 0x1034,
        Segmented = 0x1035,
        CameraEnabled = 0x1036,
        CameraOrder = 0x1037,
        MicrEnabled = 0x1038,
        FeederPrep = 0x1039,
        Feederpocket = 0x103a,
        Autobright = 0x1100,
        Brightness = 0x1101,
        Contrast = 0x1103,
        CustHalftone = 0x1104,
        ExposureTime = 0x1105,
        Filter = 0x1106,
        Flashused = 0x1107,
        Gamma = 0x1108,
        Halftones = 0x1109,
        Highlight = 0x110a,
        ImageFileFormat = 0x110c,
        LampState = 0x110d,
        LightSource = 0x110e,
        Orientation = 0x1110,
        PhysicalWidth = 0x1111,
        PhysicalHeight = 0x1112,
        Shadow = 0x1113,
        Frames = 0x1114,
        XNativeResolution = 0x1116,
        YNativeResolution = 0x1117,
        XResolution = 0x1118,
        YResolution = 0x1119,
        MaxFrames = 0x111a,

        Tiles = 0x111b,
        Bitorder = 0x111c,
        Ccittkfactor = 0x111d,
        Lightpath = 0x111e,
        Pixelflavor = 0x111f,
        Planarchunky = 0x1120,
        Rotation = 0x1121,
        Supportedsizes = 0x1122,
        Threshold = 0x1123,
        Xscaling = 0x1124,
        Yscaling = 0x1125,
        Bitordercodes = 0x1126,
        Pixelflavorcodes = 0x1127,
        Jpegpixeltype = 0x1128,
        Timefill = 0x112a,
        BitDepth = 0x112b,
        Bitdepthreduction = 0x112c,
        Undefinedimagesize = 0x112d,
        Imagedataset = 0x112e,
        Extimageinfo = 0x112f,
        Minimumheight = 0x1130,
        Minimumwidth = 0x1131,
        Fliprotation = 0x1136,
        Barcodedetectionenabled = 0x1137,
        Supportedbarcodetypes = 0x1138,
        Barcodemaxsearchpriorities = 0x1139,
        Barcodesearchpriorities = 0x113a,
        Barcodesearchmode = 0x113b,
        Barcodemaxretries = 0x113c,
        Barcodetimeout = 0x113d,
        Zoomfactor = 0x113e,
        Patchcodedetectionenabled = 0x113f,
        Supportedpatchcodetypes = 0x1140,
        Patchcodemaxsearchpriorities = 0x1141,
        Patchcodesearchpriorities = 0x1142,
        Patchcodesearchmode = 0x1143,
        Patchcodemaxretries = 0x1144,
        Patchcodetimeout = 0x1145,
        Flashused2 = 0x1146,
        Imagefilter = 0x1147,
        Noisefilter = 0x1148,
        Overscan = 0x1149,
        Automaticborderdetection = 0x1150,
        Automaticdeskew = 0x1151,
        Automaticrotate = 0x1152,
        Jpegquality = 0x1153,
        Feedertype = 0x1154,
        Iccprofile = 0x1155,
        Autosize = 0x1156,
        Audiofileformat = 0x1201,
        Xfermech = 0x1202
    }
}
