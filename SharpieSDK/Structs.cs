using System;
using ObjCRuntime;

namespace SharpieSDK
{
    using System;
    using ObjCRuntime;

    [Native]
    public enum AdPositionType : long
    {
        PreRoll = 0,
        MidRoll = 1,
        PostRoll = 2
    }

    [Native]
    public enum AssetType : long
    {
        Media = 0,
        Epg = 1,
        Unknown = 2
    }

    [Native]
    public enum MediaFormat : long
    {
        Dash = 0,
        Hls = 1,
        Wvm = 2,
        Mp4 = 3,
        Mp3 = 4,
        Mov = 5,
        Unknown = 6
    }

    [Native]
    public enum MediaType : long
    {
        Live = 0,
        Vod = 1,
        Unknown = 2
    }

    [Native]
    public enum PKLogLevel : long
    {
        Verbose = 0,
        Debug = 1,
        Info = 2,
        Warning = 3,
        Error = 4
    }

    [Native]
    public enum PlaybackContextType : long
    {
        Trailer = 0,
        Catchup = 1,
        StartOver = 2,
        Playback = 3,
        Unknown = 4
    }

    [Native]
    public enum PlayerState : long
    {
        Idle = 0,
        Ready = 1,
        Buffering = 2,
        Ended = 3,
        Error = 4,
        Unknown = -1
    }
}

