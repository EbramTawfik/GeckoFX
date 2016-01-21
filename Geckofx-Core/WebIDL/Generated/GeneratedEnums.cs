namespace Gecko.WebIDL
{
    using System;
    using System.ComponentModel;
    
    
    public enum AnimationPlayState
    {
        
        [Description("idle")]
        idle,
        
        [Description("pending")]
        pending,
        
        [Description("running")]
        running,
        
        [Description("paused")]
        paused,
        
        [Description("finished")]
        finished,
    }
    
    public enum FillMode
    {
        
        [Description("none")]
        none,
        
        [Description("forwards")]
        forwards,
        
        [Description("backwards")]
        backwards,
        
        [Description("both")]
        both,
        
        [Description("auto")]
        auto,
    }
    
    public enum PlaybackDirection
    {
        
        [Description("normal")]
        normal,
        
        [Description("reverse")]
        reverse,
        
        [Description("alternate")]
        alternate,
        
        [Description("alternate-reverse")]
        alternatereverse,
    }
    
    public enum LocaleResourceType
    {
        
        [Description("binary")]
        binary,
        
        [Description("json")]
        json,
        
        [Description("text")]
        text,
    }
    
    public enum AudioChannel
    {
        
        [Description("normal")]
        normal,
        
        [Description("content")]
        content,
        
        [Description("notification")]
        notification,
        
        [Description("alarm")]
        alarm,
        
        [Description("telephony")]
        telephony,
        
        [Description("ringer")]
        ringer,
        
        [Description("publicnotification")]
        publicnotification,
        
        [Description("system")]
        system,
    }
    
    public enum AudioContextState
    {
        
        [Description("suspended")]
        suspended,
        
        [Description("running")]
        running,
        
        [Description("closed")]
        closed,
    }
    
    public enum ChannelCountMode
    {
        
        [Description("max")]
        max,
        
        [Description("clamped-max")]
        clampedmax,
        
        [Description("explicit")]
        @explicit,
    }
    
    public enum ChannelInterpretation
    {
        
        [Description("speakers")]
        speakers,
        
        [Description("discrete")]
        discrete,
    }
    
    public enum AutoCompleteErrorReason
    {
        
        [Description("cancel")]
        cancel,
        
        [Description("disabled")]
        disabled,
        
        [Description("invalid")]
        invalid,
    }
    
    public enum BiquadFilterType
    {
        
        [Description("lowpass")]
        lowpass,
        
        [Description("highpass")]
        highpass,
        
        [Description("bandpass")]
        bandpass,
        
        [Description("lowshelf")]
        lowshelf,
        
        [Description("highshelf")]
        highshelf,
        
        [Description("peaking")]
        peaking,
        
        [Description("notch")]
        notch,
        
        [Description("allpass")]
        allpass,
    }
    
    public enum EndingTypes
    {
        
        [Description("transparent")]
        transparent,
        
        [Description("native")]
        native,
    }
    
    public enum BluetoothAdapterState
    {
        
        [Description("disabled")]
        disabled,
        
        [Description("disabling")]
        disabling,
        
        [Description("enabled")]
        enabled,
        
        [Description("enabling")]
        enabling,
    }
    
    public enum BluetoothAdapterAttribute
    {
        
        [Description("unknown")]
        unknown,
        
        [Description("state")]
        state,
        
        [Description("address")]
        address,
        
        [Description("name")]
        name,
        
        [Description("discoverable")]
        discoverable,
        
        [Description("discovering")]
        discovering,
    }
    
    public enum BluetoothDeviceType
    {
        
        [Description("unknown")]
        unknown,
        
        [Description("classic")]
        classic,
        
        [Description("le")]
        le,
        
        [Description("dual")]
        dual,
    }
    
    public enum BluetoothDeviceAttribute
    {
        
        [Description("unknown")]
        unknown,
        
        [Description("cod")]
        cod,
        
        [Description("name")]
        name,
        
        [Description("paired")]
        paired,
        
        [Description("uuids")]
        uuids,
    }
    
    public enum BluetoothConnectionState
    {
        
        [Description("disconnected")]
        disconnected,
        
        [Description("disconnecting")]
        disconnecting,
        
        [Description("connected")]
        connected,
        
        [Description("connecting")]
        connecting,
    }
    
    public enum BluetoothManagerAttribute
    {
        
        [Description("unknown")]
        unknown,
        
        [Description("defaultAdapter")]
        defaultAdapter,
    }
    
    public enum MessageType
    {
        
        [Description("no-filtering")]
        nofiltering,
        
        [Description("sms")]
        sms,
        
        [Description("email")]
        email,
        
        [Description("mms")]
        mms,
    }
    
    public enum ReadStatus
    {
        
        [Description("no-filtering")]
        nofiltering,
        
        [Description("unread")]
        unread,
        
        [Description("read")]
        read,
    }
    
    public enum Priority
    {
        
        [Description("no-filtering")]
        nofiltering,
        
        [Description("high-priority")]
        highpriority,
        
        [Description("non-priority")]
        nonpriority,
    }
    
    public enum ParameterMask
    {
        
        [Description("subject")]
        subject,
        
        [Description("datetime")]
        datetime,
        
        [Description("sender_name")]
        sender_name,
        
        [Description("sender_addressing")]
        sender_addressing,
        
        [Description("recipient_name")]
        recipient_name,
        
        [Description("recipient_addressing")]
        recipient_addressing,
        
        [Description("type")]
        type,
        
        [Description("size")]
        size,
        
        [Description("reception_status")]
        reception_status,
        
        [Description("text")]
        text,
        
        [Description("attachment_size")]
        attachment_size,
        
        [Description("priority")]
        priority,
        
        [Description("read")]
        read,
        
        [Description("sent")]
        sent,
        
        [Description("protected")]
        @protected,
        
        [Description("replyto_addressing")]
        replyto_addressing,
    }
    
    public enum FilterCharset
    {
        
        [Description("native")]
        native,
        
        [Description("utf-8")]
        utf8,
    }
    
    public enum StatusIndicators
    {
        
        [Description("readstatus")]
        readstatus,
        
        [Description("deletedstatus")]
        deletedstatus,
    }
    
    public enum VCardProperties
    {
        
        [Description("version")]
        version,
        
        [Description("fn")]
        fn,
        
        [Description("n")]
        n,
        
        [Description("photo")]
        photo,
        
        [Description("bday")]
        bday,
        
        [Description("adr")]
        adr,
        
        [Description("label")]
        label,
        
        [Description("tel")]
        tel,
        
        [Description("email")]
        email,
        
        [Description("mailer")]
        mailer,
        
        [Description("tz")]
        tz,
        
        [Description("geo")]
        geo,
        
        [Description("title")]
        title,
        
        [Description("role")]
        role,
        
        [Description("logo")]
        logo,
        
        [Description("agent")]
        agent,
        
        [Description("org")]
        org,
        
        [Description("note")]
        note,
        
        [Description("rev")]
        rev,
        
        [Description("sound")]
        sound,
        
        [Description("url")]
        url,
        
        [Description("uid")]
        uid,
        
        [Description("key")]
        key,
        
        [Description("nickname")]
        nickname,
        
        [Description("categories")]
        categories,
        
        [Description("proid")]
        proid,
        
        [Description("class")]
        @class,
        
        [Description("sort-string")]
        sortstring,
        
        [Description("x-irmc-call-datetime")]
        xirmccalldatetime,
        
        [Description("x-bt-speeddialkey")]
        xbtspeeddialkey,
        
        [Description("x-bt-uci")]
        xbtuci,
        
        [Description("x-bt-uid")]
        xbtuid,
    }
    
    public enum VCardOrderType
    {
        
        [Description("indexed")]
        indexed,
        
        [Description("alphabetical")]
        alphabetical,
        
        [Description("phonetical")]
        phonetical,
    }
    
    public enum VCardSearchKeyType
    {
        
        [Description("name")]
        name,
        
        [Description("number")]
        number,
        
        [Description("sound")]
        sound,
    }
    
    public enum VCardVersion
    {
        
        [Description("vCard21")]
        vCard21,
        
        [Description("vCard30")]
        vCard30,
    }
    
    public enum VCardSelectorOp
    {
        
        [Description("OR")]
        OR,
        
        [Description("AND")]
        AND,
    }
    
    public enum BrowserFindCaseSensitivity
    {
        
        [Description("case-sensitive")]
        casesensitive,
        
        [Description("case-insensitive")]
        caseinsensitive,
    }
    
    public enum BrowserFindDirection
    {
        
        [Description("forward")]
        forward,
        
        [Description("backward")]
        backward,
    }
    
    public enum CacheStorageNamespace
    {
        
        [Description("content")]
        content,
        
        [Description("chrome")]
        chrome,
    }
    
    public enum CameraMode
    {
        
        [Description("unspecified")]
        unspecified,
        
        [Description("picture")]
        picture,
        
        [Description("video")]
        video,
    }
    
    public enum CanvasWindingRule
    {
        
        [Description("nonzero")]
        nonzero,
        
        [Description("evenodd")]
        evenodd,
    }
    
    public enum CaretChangedReason
    {
        
        [Description("visibilitychange")]
        visibilitychange,
        
        [Description("updateposition")]
        updateposition,
        
        [Description("longpressonemptycontent")]
        longpressonemptycontent,
        
        [Description("taponcaret")]
        taponcaret,
        
        [Description("presscaret")]
        presscaret,
        
        [Description("releasecaret")]
        releasecaret,
    }
    
    public enum FrameType
    {
        
        [Description("auxiliary")]
        auxiliary,
        
        [Description("top-level")]
        toplevel,
        
        [Description("nested")]
        nested,
        
        [Description("none")]
        none,
    }
    
    public enum ClientType
    {
        
        [Description("window")]
        window,
        
        [Description("worker")]
        worker,
        
        [Description("sharedworker")]
        sharedworker,
        
        [Description("all")]
        all,
    }
    
    public enum CSSTokenType
    {
        
        [Description("whitespace")]
        whitespace,
        
        [Description("comment")]
        comment,
        
        [Description("ident")]
        ident,
        
        [Description("function")]
        function,
        
        [Description("at")]
        at,
        
        [Description("id")]
        id,
        
        [Description("hash")]
        hash,
        
        [Description("number")]
        number,
        
        [Description("dimension")]
        dimension,
        
        [Description("percentage")]
        percentage,
        
        [Description("string")]
        @string,
        
        [Description("bad_string")]
        bad_string,
        
        [Description("url")]
        url,
        
        [Description("bad_url")]
        bad_url,
        
        [Description("symbol")]
        symbol,
        
        [Description("includes")]
        includes,
        
        [Description("dashmatch")]
        dashmatch,
        
        [Description("beginsmatch")]
        beginsmatch,
        
        [Description("endsmatch")]
        endsmatch,
        
        [Description("containsmatch")]
        containsmatch,
        
        [Description("urange")]
        urange,
        
        [Description("htmlcomment")]
        htmlcomment,
    }
    
    public enum RTCDataChannelState
    {
        
        [Description("connecting")]
        connecting,
        
        [Description("open")]
        open,
        
        [Description("closing")]
        closing,
        
        [Description("closed")]
        closed,
    }
    
    public enum RTCDataChannelType
    {
        
        [Description("arraybuffer")]
        arraybuffer,
        
        [Description("blob")]
        blob,
    }
    
    public enum DataStoreOperation
    {
        
        [Description("add")]
        add,
        
        [Description("update")]
        update,
        
        [Description("remove")]
        remove,
        
        [Description("clear")]
        clear,
        
        [Description("done")]
        done,
    }
    
    public enum DeviceStorageAreaChangedEventOperation
    {
        
        [Description("added")]
        added,
        
        [Description("removed")]
        removed,
        
        [Description("unknown")]
        unknown,
    }
    
    public enum CreateIfExistsMode
    {
        
        [Description("replace")]
        replace,
        
        [Description("fail")]
        fail,
    }
    
    public enum VisibilityState
    {
        
        [Description("hidden")]
        hidden,
        
        [Description("visible")]
        visible,
    }
    
    public enum SupportedType
    {
        
        [Description("text/html")]
        texthtml,
        
        [Description("text/xml")]
        textxml,
        
        [Description("application/xml")]
        applicationxml,
        
        [Description("application/xhtml+xml")]
        applicationxhtmlxml,
        
        [Description("image/svg+xml")]
        imagesvgxml,
    }
    
    public enum DOMRequestReadyState
    {
        
        [Description("pending")]
        pending,
        
        [Description("done")]
        done,
    }
    
    public enum DownloadState
    {
        
        [Description("downloading")]
        downloading,
        
        [Description("stopped")]
        stopped,
        
        [Description("succeeded")]
        succeeded,
        
        [Description("finalized")]
        finalized,
    }
    
    public enum ScrollLogicalPosition
    {
        
        [Description("start")]
        start,
        
        [Description("end")]
        end,
    }
    
    public enum FileMode
    {
        
        [Description("readonly")]
        @readonly,
        
        [Description("readwrite")]
        readwrite,
    }
    
    public enum FontFaceLoadStatus
    {
        
        [Description("unloaded")]
        unloaded,
        
        [Description("loading")]
        loading,
        
        [Description("loaded")]
        loaded,
        
        [Description("error")]
        error,
    }
    
    public enum FontFaceSetLoadStatus
    {
        
        [Description("loading")]
        loading,
        
        [Description("loaded")]
        loaded,
    }
    
    public enum GamepadMappingType
    {
        
        [Description("standard")]
        standard,
    }
    
    public enum CSSBoxType
    {
        
        [Description("margin")]
        margin,
        
        [Description("border")]
        border,
        
        [Description("padding")]
        padding,
        
        [Description("content")]
        content,
    }
    
    public enum SelectionMode
    {
        
        [Description("select")]
        select,
        
        [Description("start")]
        start,
        
        [Description("end")]
        end,
        
        [Description("preserve")]
        preserve,
    }
    
    public enum IDBCursorDirection
    {
        
        [Description("next")]
        next,
        
        [Description("nextunique")]
        nextunique,
        
        [Description("prev")]
        prev,
        
        [Description("prevunique")]
        prevunique,
    }
    
    public enum IDBRequestReadyState
    {
        
        [Description("pending")]
        pending,
        
        [Description("done")]
        done,
    }
    
    public enum IDBTransactionMode
    {
        
        [Description("readonly")]
        @readonly,
        
        [Description("readwrite")]
        readwrite,
        
        [Description("readwriteflush")]
        readwriteflush,
        
        [Description("versionchange")]
        versionchange,
    }
    
    public enum CompositionClauseSelectionType
    {
        
        [Description("raw-input")]
        rawinput,
        
        [Description("selected-raw-text")]
        selectedrawtext,
        
        [Description("converted-text")]
        convertedtext,
        
        [Description("selected-converted-text")]
        selectedconvertedtext,
    }
    
    public enum MozInputMethodInputContextTypes
    {
        
        [Description("input")]
        input,
        
        [Description("textarea")]
        textarea,
        
        [Description("contenteditable")]
        contenteditable,
        
        [Description("select")]
        select,
    }
    
    public enum MozInputMethodInputContextInputTypes
    {
        
        [Description("text")]
        text,
        
        [Description("search")]
        search,
        
        [Description("textarea")]
        textarea,
        
        [Description("number")]
        number,
        
        [Description("tel")]
        tel,
        
        [Description("url")]
        url,
        
        [Description("email")]
        email,
        
        [Description("password")]
        password,
        
        [Description("datetime")]
        datetime,
        
        [Description("date")]
        date,
        
        [Description("month")]
        month,
        
        [Description("week")]
        week,
        
        [Description("time")]
        time,
        
        [Description("datetime-local")]
        datetimelocal,
        
        [Description("color")]
        color,
        
        [Description("select-one")]
        selectone,
        
        [Description("select-multiple")]
        selectmultiple,
    }
    
    public enum CompositeOperation
    {
        
        [Description("replace")]
        replace,
        
        [Description("add")]
        add,
        
        [Description("accumulate")]
        accumulate,
    }
    
    public enum IterationCompositeOperation
    {
        
        [Description("replace")]
        replace,
        
        [Description("accumulate")]
        accumulate,
    }
    
    public enum MediaDeviceKind
    {
        
        [Description("audioinput")]
        audioinput,
        
        [Description("audiooutput")]
        audiooutput,
        
        [Description("videoinput")]
        videoinput,
    }
    
    public enum MediaKeyMessageType
    {
        
        [Description("license-request")]
        licenserequest,
        
        [Description("license-renewal")]
        licenserenewal,
        
        [Description("license-release")]
        licenserelease,
        
        [Description("individualization-request")]
        individualizationrequest,
    }
    
    public enum SessionType
    {
        
        [Description("temporary")]
        temporary,
        
        [Description("persistent")]
        persistent,
    }
    
    public enum MediaKeySystemStatus
    {
        
        [Description("available")]
        available,
        
        [Description("api-disabled")]
        apidisabled,
        
        [Description("cdm-disabled")]
        cdmdisabled,
        
        [Description("cdm-not-supported")]
        cdmnotsupported,
        
        [Description("cdm-not-installed")]
        cdmnotinstalled,
        
        [Description("cdm-insufficient-version")]
        cdminsufficientversion,
        
        [Description("cdm-created")]
        cdmcreated,
        
        [Description("error")]
        error,
    }
    
    public enum MediaKeyStatus
    {
        
        [Description("usable")]
        usable,
        
        [Description("expired")]
        expired,
        
        [Description("released")]
        released,
        
        [Description("output-restricted")]
        outputrestricted,
        
        [Description("output-downscaled")]
        outputdownscaled,
        
        [Description("status-pending")]
        statuspending,
        
        [Description("internal-error")]
        internalerror,
    }
    
    public enum RecordingState
    {
        
        [Description("inactive")]
        inactive,
        
        [Description("recording")]
        recording,
        
        [Description("paused")]
        paused,
    }
    
    public enum MediaSourceReadyState
    {
        
        [Description("closed")]
        closed,
        
        [Description("open")]
        open,
        
        [Description("ended")]
        ended,
    }
    
    public enum MediaSourceEndOfStreamError
    {
        
        [Description("network")]
        network,
        
        [Description("decode")]
        decode,
    }
    
    public enum VideoFacingModeEnum
    {
        
        [Description("user")]
        user,
        
        [Description("environment")]
        environment,
        
        [Description("left")]
        left,
        
        [Description("right")]
        right,
    }
    
    public enum MediaSourceEnum
    {
        
        [Description("camera")]
        camera,
        
        [Description("screen")]
        screen,
        
        [Description("application")]
        application,
        
        [Description("window")]
        window,
        
        [Description("browser")]
        browser,
        
        [Description("microphone")]
        microphone,
        
        [Description("audioCapture")]
        audioCapture,
        
        [Description("other")]
        other,
    }
    
    public enum CellBroadcastGsmGeographicalScope
    {
        
        [Description("cell-immediate")]
        cellimmediate,
        
        [Description("plmn")]
        plmn,
        
        [Description("location-area")]
        locationarea,
        
        [Description("cell")]
        cell,
    }
    
    public enum CellBroadcastMessageClass
    {
        
        [Description("class-0")]
        class0,
        
        [Description("class-1")]
        class1,
        
        [Description("class-2")]
        class2,
        
        [Description("class-3")]
        class3,
        
        [Description("user-1")]
        user1,
        
        [Description("user-2")]
        user2,
        
        [Description("normal")]
        normal,
    }
    
    public enum CellBroadcastEtwsWarningType
    {
        
        [Description("earthquake")]
        earthquake,
        
        [Description("tsunami")]
        tsunami,
        
        [Description("earthquake-tsunami")]
        earthquaketsunami,
        
        [Description("test")]
        test,
        
        [Description("other")]
        other,
    }
    
    public enum IccCardState
    {
        
        [Description("unknown")]
        unknown,
        
        [Description("ready")]
        ready,
        
        [Description("pinRequired")]
        pinRequired,
        
        [Description("pukRequired")]
        pukRequired,
        
        [Description("permanentBlocked")]
        permanentBlocked,
        
        [Description("personalizationInProgress")]
        personalizationInProgress,
        
        [Description("personalizationReady")]
        personalizationReady,
        
        [Description("networkLocked")]
        networkLocked,
        
        [Description("networkSubsetLocked")]
        networkSubsetLocked,
        
        [Description("corporateLocked")]
        corporateLocked,
        
        [Description("serviceProviderLocked")]
        serviceProviderLocked,
        
        [Description("simPersonalizationLocked")]
        simPersonalizationLocked,
        
        [Description("networkPukRequired")]
        networkPukRequired,
        
        [Description("networkSubsetPukRequired")]
        networkSubsetPukRequired,
        
        [Description("corporatePukRequired")]
        corporatePukRequired,
        
        [Description("serviceProviderPukRequired")]
        serviceProviderPukRequired,
        
        [Description("simPersonalizationPukRequired")]
        simPersonalizationPukRequired,
        
        [Description("network1Locked")]
        network1Locked,
        
        [Description("network2Locked")]
        network2Locked,
        
        [Description("hrpdNetworkLocked")]
        hrpdNetworkLocked,
        
        [Description("ruimCorporateLocked")]
        ruimCorporateLocked,
        
        [Description("ruimServiceProviderLocked")]
        ruimServiceProviderLocked,
        
        [Description("ruimPersonalizationLocked")]
        ruimPersonalizationLocked,
        
        [Description("network1PukRequired")]
        network1PukRequired,
        
        [Description("network2PukRequired")]
        network2PukRequired,
        
        [Description("hrpdNetworkPukRequired")]
        hrpdNetworkPukRequired,
        
        [Description("ruimCorporatePukRequired")]
        ruimCorporatePukRequired,
        
        [Description("ruimServiceProviderPukRequired")]
        ruimServiceProviderPukRequired,
        
        [Description("ruimPersonalizationPukRequired")]
        ruimPersonalizationPukRequired,
        
        [Description("illegal")]
        illegal,
    }
    
    public enum IccLockType
    {
        
        [Description("pin")]
        pin,
        
        [Description("pin2")]
        pin2,
        
        [Description("puk")]
        puk,
        
        [Description("puk2")]
        puk2,
        
        [Description("nck")]
        nck,
        
        [Description("nsck")]
        nsck,
        
        [Description("nck1")]
        nck1,
        
        [Description("nck2")]
        nck2,
        
        [Description("hnck")]
        hnck,
        
        [Description("cck")]
        cck,
        
        [Description("spck")]
        spck,
        
        [Description("pck")]
        pck,
        
        [Description("rcck")]
        rcck,
        
        [Description("rspck")]
        rspck,
        
        [Description("nckPuk")]
        nckPuk,
        
        [Description("nsckPuk")]
        nsckPuk,
        
        [Description("nck1Puk")]
        nck1Puk,
        
        [Description("nck2Puk")]
        nck2Puk,
        
        [Description("hnckPuk")]
        hnckPuk,
        
        [Description("cckPuk")]
        cckPuk,
        
        [Description("spckPuk")]
        spckPuk,
        
        [Description("pckPuk")]
        pckPuk,
        
        [Description("rcckPuk")]
        rcckPuk,
        
        [Description("rspckPuk")]
        rspckPuk,
        
        [Description("fdn")]
        fdn,
    }
    
    public enum IccContactType
    {
        
        [Description("adn")]
        adn,
        
        [Description("fdn")]
        fdn,
        
        [Description("sdn")]
        sdn,
    }
    
    public enum IccMvnoType
    {
        
        [Description("imsi")]
        imsi,
        
        [Description("spn")]
        spn,
        
        [Description("gid")]
        gid,
    }
    
    public enum IccService
    {
        
        [Description("fdn")]
        fdn,
    }
    
    public enum IccType
    {
        
        [Description("sim")]
        sim,
        
        [Description("usim")]
        usim,
        
        [Description("csim")]
        csim,
        
        [Description("ruim")]
        ruim,
    }
    
    public enum MobileNetworkSelectionMode
    {
        
        [Description("automatic")]
        automatic,
        
        [Description("manual")]
        manual,
    }
    
    public enum MobileRadioState
    {
        
        [Description("enabling")]
        enabling,
        
        [Description("enabled")]
        enabled,
        
        [Description("disabling")]
        disabling,
        
        [Description("disabled")]
        disabled,
    }
    
    public enum MobileNetworkType
    {
        
        [Description("gsm")]
        gsm,
        
        [Description("wcdma")]
        wcdma,
        
        [Description("cdma")]
        cdma,
        
        [Description("evdo")]
        evdo,
        
        [Description("lte")]
        lte,
    }
    
    public enum MobilePreferredNetworkType
    {
        
        [Description("wcdma/gsm")]
        wcdmagsm,
        
        [Description("gsm")]
        gsm,
        
        [Description("wcdma")]
        wcdma,
        
        [Description("wcdma/gsm-auto")]
        wcdmagsmauto,
        
        [Description("cdma/evdo")]
        cdmaevdo,
        
        [Description("cdma")]
        cdma,
        
        [Description("evdo")]
        evdo,
        
        [Description("wcdma/gsm/cdma/evdo")]
        wcdmagsmcdmaevdo,
        
        [Description("lte/cdma/evdo")]
        ltecdmaevdo,
        
        [Description("lte/wcdma/gsm")]
        ltewcdmagsm,
        
        [Description("lte/wcdma/gsm/cdma/evdo")]
        ltewcdmagsmcdmaevdo,
        
        [Description("lte")]
        lte,
        
        [Description("lte/wcdma")]
        ltewcdma,
    }
    
    public enum MobileRoamingMode
    {
        
        [Description("home")]
        home,
        
        [Description("affiliated")]
        affiliated,
        
        [Description("any")]
        any,
    }
    
    public enum MobileConnectionState
    {
        
        [Description("notSearching")]
        notSearching,
        
        [Description("searching")]
        searching,
        
        [Description("denied")]
        denied,
        
        [Description("registered")]
        registered,
    }
    
    public enum MobileConnectionType
    {
        
        [Description("gsm")]
        gsm,
        
        [Description("gprs")]
        gprs,
        
        [Description("edge")]
        edge,
        
        [Description("umts")]
        umts,
        
        [Description("hsdpa")]
        hsdpa,
        
        [Description("hsupa")]
        hsupa,
        
        [Description("hspa")]
        hspa,
        
        [Description("hspa+")]
        hspa7,
        
        [Description("is95a")]
        is95a,
        
        [Description("is95b")]
        is95b,
        
        [Description("1xrtt")]
        _1xrtt,
        
        [Description("evdo0")]
        evdo0,
        
        [Description("evdoa")]
        evdoa,
        
        [Description("evdob")]
        evdob,
        
        [Description("ehrpd")]
        ehrpd,
        
        [Description("lte")]
        lte,
    }
    
    public enum MobileMessageFilterDelivery
    {
        
        [Description("sent")]
        sent,
        
        [Description("received")]
        received,
    }
    
    public enum TypeOfNumber
    {
        
        [Description("unknown")]
        unknown,
        
        [Description("international")]
        international,
        
        [Description("national")]
        national,
        
        [Description("network-specific")]
        networkspecific,
        
        [Description("dedicated-access-short-code")]
        dedicatedaccessshortcode,
    }
    
    public enum NumberPlanIdentification
    {
        
        [Description("unknown")]
        unknown,
        
        [Description("isdn")]
        isdn,
        
        [Description("data")]
        data,
        
        [Description("telex")]
        telex,
        
        [Description("national")]
        national,
        
        [Description("private")]
        @private,
    }
    
    public enum MobileNetworkState
    {
        
        [Description("available")]
        available,
        
        [Description("connected")]
        connected,
        
        [Description("forbidden")]
        forbidden,
    }
    
    public enum TNF
    {
        
        [Description("empty")]
        empty,
        
        [Description("well-known")]
        wellknown,
        
        [Description("media-type")]
        mediatype,
        
        [Description("absolute-uri")]
        absoluteuri,
        
        [Description("external")]
        external,
        
        [Description("unknown")]
        unknown,
        
        [Description("unchanged")]
        unchanged,
    }
    
    public enum WellKnownURIPrefix
    {
        
        [Description("http://www.")]
        httpwww,
        
        [Description("https://www.")]
        httpswww,
        
        [Description("http://")]
        http,
        
        [Description("https://")]
        https,
        
        [Description("tel:")]
        tel,
        
        [Description("mailto:")]
        mailto,
        
        [Description("ftp://anonymous:anonymous@")]
        ftpanonymousanonymous,
        
        [Description("ftp://ftp.")]
        ftpftp,
        
        [Description("ftps://")]
        ftps,
        
        [Description("sftp://")]
        sftp,
        
        [Description("smb://")]
        smb,
        
        [Description("nfs://")]
        nfs,
        
        [Description("ftp://")]
        ftp,
        
        [Description("dav://")]
        dav,
        
        [Description("news:")]
        news,
        
        [Description("telnet://")]
        telnet,
        
        [Description("imap:")]
        imap,
        
        [Description("rtsp://")]
        rtsp,
        
        [Description("urn:")]
        urn,
        
        [Description("pop:")]
        pop,
        
        [Description("sip:")]
        sip,
        
        [Description("sips:")]
        sips,
        
        [Description("tftp:")]
        tftp,
        
        [Description("btspp://")]
        btspp,
        
        [Description("btl2cap://")]
        btl2cap,
        
        [Description("btgoep://")]
        btgoep,
        
        [Description("tcpobex://")]
        tcpobex,
        
        [Description("irdaobex://")]
        irdaobex,
        
        [Description("file://")]
        file,
        
        [Description("urn:epc:id:")]
        urnepcid,
        
        [Description("urn:epc:tag:")]
        urnepctag,
        
        [Description("urn:epc:pat:")]
        urnepcpat,
        
        [Description("urn:epc:raw:")]
        urnepcraw,
        
        [Description("urn:epc:")]
        urnepc,
        
        [Description("urn:nfc:")]
        urnnfc,
    }
    
    public enum RTD
    {
        
        [Description("U")]
        U,
    }
    
    public enum NfcErrorMessage
    {
        
        [Description("IOError")]
        IOError,
        
        [Description("Timeout")]
        Timeout,
        
        [Description("Busy")]
        Busy,
        
        [Description("ErrorConnect")]
        ErrorConnect,
        
        [Description("ErrorDisconnect")]
        ErrorDisconnect,
        
        [Description("ErrorRead")]
        ErrorRead,
        
        [Description("ErrorWrite")]
        ErrorWrite,
        
        [Description("InvalidParameter")]
        InvalidParameter,
        
        [Description("InsufficientResource")]
        InsufficientResource,
        
        [Description("ErrorSocketCreation")]
        ErrorSocketCreation,
        
        [Description("FailEnableDiscovery")]
        FailEnableDiscovery,
        
        [Description("FailDisableDiscovery")]
        FailDisableDiscovery,
        
        [Description("NotInitialize")]
        NotInitialize,
        
        [Description("InitializeFail")]
        InitializeFail,
        
        [Description("DeinitializeFail")]
        DeinitializeFail,
        
        [Description("NotSupport")]
        NotSupport,
        
        [Description("FailEnableLowPowerMode")]
        FailEnableLowPowerMode,
        
        [Description("FailDisableLowPowerMode")]
        FailDisableLowPowerMode,
    }
    
    public enum NFCTechType
    {
        
        [Description("NFC-A")]
        NFCA,
        
        [Description("NFC-B")]
        NFCB,
        
        [Description("NFC-F")]
        NFCF,
        
        [Description("NFC-V")]
        NFCV,
        
        [Description("ISO-DEP")]
        ISODEP,
        
        [Description("MIFARE-Classic")]
        MIFAREClassic,
        
        [Description("MIFARE-Ultralight")]
        MIFAREUltralight,
        
        [Description("NFC-Barcode")]
        NFCBarcode,
        
        [Description("Unknown")]
        Unknown,
    }
    
    public enum NFCTagType
    {
        
        [Description("Type1")]
        Type1,
        
        [Description("Type2")]
        Type2,
        
        [Description("Type3")]
        Type3,
        
        [Description("Type4")]
        Type4,
        
        [Description("MIFARE-Classic")]
        MIFAREClassic,
    }
    
    public enum FactoryResetReason
    {
        
        [Description("normal")]
        normal,
        
        [Description("wipe")]
        wipe,
        
        [Description("root")]
        root,
    }
    
    public enum IccImageCodingScheme
    {
        
        [Description("basic")]
        basic,
        
        [Description("color")]
        color,
        
        [Description("color-transparency")]
        colortransparency,
    }
    
    public enum TetheringType
    {
        
        [Description("bluetooth")]
        bluetooth,
        
        [Description("usb")]
        usb,
        
        [Description("wifi")]
        wifi,
    }
    
    public enum SecurityType
    {
        
        [Description("open")]
        open,
        
        [Description("wpa-psk")]
        wpapsk,
        
        [Description("wpa2-psk")]
        wpa2psk,
    }
    
    public enum WifiSecurityMethod
    {
        
        [Description("OPEN")]
        OPEN,
        
        [Description("WEP")]
        WEP,
        
        [Description("WPA-PSK")]
        WPAPSK,
        
        [Description("WPA-EAP")]
        WPAEAP,
    }
    
    public enum WifiWpaMethod
    {
        
        [Description("SIM")]
        SIM,
        
        [Description("PEAP")]
        PEAP,
        
        [Description("TTLS")]
        TTLS,
        
        [Description("TLS")]
        TLS,
    }
    
    public enum WifiWpaPhase2Method
    {
        
        [Description("MSCHAPV2")]
        MSCHAPV2,
        
        [Description("GTC")]
        GTC,
    }
    
    public enum WifiWpaCertificate
    {
        
        [Description("SERVER")]
        SERVER,
        
        [Description("USER")]
        USER,
    }
    
    public enum WifiWPSMethod
    {
        
        [Description("pbc")]
        pbc,
        
        [Description("pin")]
        pin,
        
        [Description("cancel")]
        cancel,
    }
    
    public enum ConnectionStatus
    {
        
        [Description("connecting")]
        connecting,
        
        [Description("authenticating")]
        authenticating,
        
        [Description("associated")]
        associated,
        
        [Description("connected")]
        connected,
        
        [Description("disconnected")]
        disconnected,
        
        [Description("wps-timedout")]
        wpstimedout,
        
        [Description("wps-failed")]
        wpsfailed,
        
        [Description("wps-overlapped")]
        wpsoverlapped,
        
        [Description("connectingfailed")]
        connectingfailed,
    }
    
    public enum WPSMethod
    {
        
        [Description("pbc")]
        pbc,
        
        [Description("keypad")]
        keypad,
        
        [Description("display")]
        display,
    }
    
    public enum ConnectionType
    {
        
        [Description("cellular")]
        cellular,
        
        [Description("bluetooth")]
        bluetooth,
        
        [Description("ethernet")]
        ethernet,
        
        [Description("wifi")]
        wifi,
        
        [Description("other")]
        other,
        
        [Description("none")]
        none,
        
        [Description("unknown")]
        unknown,
    }
    
    public enum RFState
    {
        
        [Description("idle")]
        idle,
        
        [Description("listen")]
        listen,
        
        [Description("discovery")]
        discovery,
    }
    
    public enum NfcRequestType
    {
        
        [Description("changeRFState")]
        changeRFState,
        
        [Description("readNDEF")]
        readNDEF,
        
        [Description("writeNDEF")]
        writeNDEF,
        
        [Description("makeReadOnly")]
        makeReadOnly,
        
        [Description("format")]
        format,
        
        [Description("transceive")]
        transceive,
    }
    
    public enum NfcResponseType
    {
        
        [Description("changeRFStateRsp")]
        changeRFStateRsp,
        
        [Description("readNDEFRsp")]
        readNDEFRsp,
        
        [Description("writeNDEFRsp")]
        writeNDEFRsp,
        
        [Description("makeReadOnlyRsp")]
        makeReadOnlyRsp,
        
        [Description("formatRsp")]
        formatRsp,
        
        [Description("transceiveRsp")]
        transceiveRsp,
    }
    
    public enum NfcNotificationType
    {
        
        [Description("initialized")]
        initialized,
        
        [Description("techDiscovered")]
        techDiscovered,
        
        [Description("techLost")]
        techLost,
        
        [Description("hciEventTransaction")]
        hciEventTransaction,
        
        [Description("ndefReceived")]
        ndefReceived,
    }
    
    public enum HCIEventOrigin
    {
        
        [Description("SIM")]
        SIM,
        
        [Description("eSE")]
        eSE,
        
        [Description("ASSD")]
        ASSD,
    }
    
    public enum NotificationPermission
    {
        
        [Description("default")]
        @default,
        
        [Description("denied")]
        denied,
        
        [Description("granted")]
        granted,
    }
    
    public enum NotificationDirection
    {
        
        [Description("auto")]
        auto,
        
        [Description("ltr")]
        ltr,
        
        [Description("rtl")]
        rtl,
    }
    
    public enum OscillatorType
    {
        
        [Description("sine")]
        sine,
        
        [Description("square")]
        square,
        
        [Description("sawtooth")]
        sawtooth,
        
        [Description("triangle")]
        triangle,
        
        [Description("custom")]
        custom,
    }
    
    public enum PanningModelType
    {
        
        [Description("equalpower")]
        equalpower,
        
        [Description("HRTF")]
        HRTF,
    }
    
    public enum DistanceModelType
    {
        
        [Description("linear")]
        linear,
        
        [Description("inverse")]
        inverse,
        
        [Description("exponential")]
        exponential,
    }
    
    public enum PCImplSignalingState
    {
        
        [Description("SignalingInvalid")]
        SignalingInvalid,
        
        [Description("SignalingStable")]
        SignalingStable,
        
        [Description("SignalingHaveLocalOffer")]
        SignalingHaveLocalOffer,
        
        [Description("SignalingHaveRemoteOffer")]
        SignalingHaveRemoteOffer,
        
        [Description("SignalingHaveLocalPranswer")]
        SignalingHaveLocalPranswer,
        
        [Description("SignalingHaveRemotePranswer")]
        SignalingHaveRemotePranswer,
        
        [Description("SignalingClosed")]
        SignalingClosed,
    }
    
    public enum PCImplSipccState
    {
        
        [Description("Idle")]
        Idle,
        
        [Description("Starting")]
        Starting,
        
        [Description("Started")]
        Started,
    }
    
    public enum PCImplIceConnectionState
    {
        
        [Description("new")]
        @new,
        
        [Description("checking")]
        checking,
        
        [Description("connected")]
        connected,
        
        [Description("completed")]
        completed,
        
        [Description("failed")]
        failed,
        
        [Description("disconnected")]
        disconnected,
        
        [Description("closed")]
        closed,
    }
    
    public enum PCImplIceGatheringState
    {
        
        [Description("new")]
        @new,
        
        [Description("gathering")]
        gathering,
        
        [Description("complete")]
        complete,
    }
    
    public enum PCObserverStateType
    {
        
        [Description("None")]
        None,
        
        [Description("IceConnectionState")]
        IceConnectionState,
        
        [Description("IceGatheringState")]
        IceGatheringState,
        
        [Description("SdpState")]
        SdpState,
        
        [Description("SipccState")]
        SipccState,
        
        [Description("SignalingState")]
        SignalingState,
    }
    
    public enum PermissionName
    {
        
        [Description("geolocation")]
        geolocation,
        
        [Description("notifications")]
        notifications,
        
        [Description("push")]
        push,
        
        [Description("midi")]
        midi,
    }
    
    public enum PermissionState
    {
        
        [Description("granted")]
        granted,
        
        [Description("denied")]
        denied,
        
        [Description("prompt")]
        prompt,
    }
    
    public enum PresentationConnectionState
    {
        
        [Description("connected")]
        connected,
        
        [Description("closed")]
        closed,
        
        [Description("terminated")]
        terminated,
    }
    
    public enum ProfileTimelineWorkerOperationType
    {
        
        [Description("serializeDataOffMainThread")]
        serializeDataOffMainThread,
        
        [Description("serializeDataOnMainThread")]
        serializeDataOnMainThread,
        
        [Description("deserializeDataOffMainThread")]
        deserializeDataOffMainThread,
        
        [Description("deserializeDataOnMainThread")]
        deserializeDataOnMainThread,
    }
    
    public enum PromiseDebuggingState
    {
        
        [Description("pending")]
        pending,
        
        [Description("fulfilled")]
        fulfilled,
        
        [Description("rejected")]
        rejected,
    }
    
    public enum PushPermissionState
    {
        
        [Description("granted")]
        granted,
        
        [Description("denied")]
        denied,
        
        [Description("prompt")]
        prompt,
    }
    
    public enum PushEncryptionKeyName
    {
        
        [Description("p256dh")]
        p256dh,
        
        [Description("auth")]
        auth,
    }
    
    public enum RequestContext
    {
        
        [Description("audio")]
        audio,
        
        [Description("beacon")]
        beacon,
        
        [Description("cspreport")]
        cspreport,
        
        [Description("download")]
        download,
        
        [Description("embed")]
        embed,
        
        [Description("eventsource")]
        eventsource,
        
        [Description("favicon")]
        favicon,
        
        [Description("fetch")]
        fetch,
        
        [Description("font")]
        font,
        
        [Description("form")]
        form,
        
        [Description("frame")]
        frame,
        
        [Description("hyperlink")]
        hyperlink,
        
        [Description("iframe")]
        iframe,
        
        [Description("image")]
        image,
        
        [Description("imageset")]
        imageset,
        
        [Description("import")]
        import,
        
        [Description("internal")]
        @internal,
        
        [Description("location")]
        location,
        
        [Description("manifest")]
        manifest,
        
        [Description("object")]
        @object,
        
        [Description("ping")]
        ping,
        
        [Description("plugin")]
        plugin,
        
        [Description("prefetch")]
        prefetch,
        
        [Description("script")]
        script,
        
        [Description("sharedworker")]
        sharedworker,
        
        [Description("subresource")]
        subresource,
        
        [Description("style")]
        style,
        
        [Description("track")]
        track,
        
        [Description("video")]
        video,
        
        [Description("worker")]
        worker,
        
        [Description("xmlhttprequest")]
        xmlhttprequest,
        
        [Description("xslt")]
        xslt,
    }
    
    public enum RequestMode
    {
        
        [Description("same-origin")]
        sameorigin,
        
        [Description("no-cors")]
        nocors,
        
        [Description("cors")]
        cors,
    }
    
    public enum RequestCredentials
    {
        
        [Description("omit")]
        omit,
        
        [Description("same-origin")]
        sameorigin,
        
        [Description("include")]
        include,
    }
    
    public enum RequestCache
    {
        
        [Description("default")]
        @default,
        
        [Description("no-store")]
        nostore,
        
        [Description("reload")]
        reload,
        
        [Description("no-cache")]
        nocache,
        
        [Description("force-cache")]
        forcecache,
        
        [Description("only-if-cached")]
        onlyifcached,
    }
    
    public enum RequestRedirect
    {
        
        [Description("follow")]
        follow,
        
        [Description("error")]
        error,
        
        [Description("manual")]
        manual,
    }
    
    public enum RequestSyncTaskPolicyState
    {
        
        [Description("enabled")]
        enabled,
        
        [Description("disabled")]
        disabled,
        
        [Description("wifiOnly")]
        wifiOnly,
    }
    
    public enum ResourceType
    {
        
        [Description("network")]
        network,
        
        [Description("power")]
        power,
    }
    
    public enum SystemService
    {
        
        [Description("ota")]
        ota,
        
        [Description("tethering")]
        tethering,
    }
    
    public enum ResponseType
    {
        
        [Description("basic")]
        basic,
        
        [Description("cors")]
        cors,
        
        [Description("default")]
        @default,
        
        [Description("error")]
        error,
        
        [Description("opaque")]
        opaque,
        
        [Description("opaqueredirect")]
        opaqueredirect,
    }
    
    public enum RTCIceTransportPolicy
    {
        
        [Description("none")]
        none,
        
        [Description("relay")]
        relay,
        
        [Description("all")]
        all,
    }
    
    public enum RTCBundlePolicy
    {
        
        [Description("balanced")]
        balanced,
        
        [Description("max-compat")]
        maxcompat,
        
        [Description("max-bundle")]
        maxbundle,
    }
    
    public enum RTCSignalingState
    {
        
        [Description("stable")]
        stable,
        
        [Description("have-local-offer")]
        havelocaloffer,
        
        [Description("have-remote-offer")]
        haveremoteoffer,
        
        [Description("have-local-pranswer")]
        havelocalpranswer,
        
        [Description("have-remote-pranswer")]
        haveremotepranswer,
        
        [Description("closed")]
        closed,
    }
    
    public enum RTCIceGatheringState
    {
        
        [Description("new")]
        @new,
        
        [Description("gathering")]
        gathering,
        
        [Description("complete")]
        complete,
    }
    
    public enum RTCIceConnectionState
    {
        
        [Description("new")]
        @new,
        
        [Description("checking")]
        checking,
        
        [Description("connected")]
        connected,
        
        [Description("completed")]
        completed,
        
        [Description("failed")]
        failed,
        
        [Description("disconnected")]
        disconnected,
        
        [Description("closed")]
        closed,
    }
    
    public enum RTCLifecycleEvent
    {
        
        [Description("initialized")]
        initialized,
        
        [Description("icegatheringstatechange")]
        icegatheringstatechange,
        
        [Description("iceconnectionstatechange")]
        iceconnectionstatechange,
    }
    
    public enum RTCSdpType
    {
        
        [Description("offer")]
        offer,
        
        [Description("pranswer")]
        pranswer,
        
        [Description("answer")]
        answer,
        
        [Description("rollback")]
        rollback,
    }
    
    public enum RTCStatsType
    {
        
        [Description("inboundrtp")]
        inboundrtp,
        
        [Description("outboundrtp")]
        outboundrtp,
        
        [Description("session")]
        session,
        
        [Description("track")]
        track,
        
        [Description("transport")]
        transport,
        
        [Description("candidatepair")]
        candidatepair,
        
        [Description("localcandidate")]
        localcandidate,
        
        [Description("remotecandidate")]
        remotecandidate,
    }
    
    public enum RTCStatsIceCandidatePairState
    {
        
        [Description("frozen")]
        frozen,
        
        [Description("waiting")]
        waiting,
        
        [Description("inprogress")]
        inprogress,
        
        [Description("failed")]
        failed,
        
        [Description("succeeded")]
        succeeded,
        
        [Description("cancelled")]
        cancelled,
    }
    
    public enum RTCStatsIceCandidateType
    {
        
        [Description("host")]
        host,
        
        [Description("serverreflexive")]
        serverreflexive,
        
        [Description("peerreflexive")]
        peerreflexive,
        
        [Description("relayed")]
        relayed,
    }
    
    public enum OrientationType
    {
        
        [Description("portrait-primary")]
        portraitprimary,
        
        [Description("portrait-secondary")]
        portraitsecondary,
        
        [Description("landscape-primary")]
        landscapeprimary,
        
        [Description("landscape-secondary")]
        landscapesecondary,
    }
    
    public enum OrientationLockType
    {
        
        [Description("any")]
        any,
        
        [Description("natural")]
        natural,
        
        [Description("landscape")]
        landscape,
        
        [Description("portrait")]
        portrait,
        
        [Description("portrait-primary")]
        portraitprimary,
        
        [Description("portrait-secondary")]
        portraitsecondary,
        
        [Description("landscape-primary")]
        landscapeprimary,
        
        [Description("landscape-secondary")]
        landscapesecondary,
    }
    
    public enum ScrollState
    {
        
        [Description("started")]
        started,
        
        [Description("stopped")]
        stopped,
    }
    
    public enum SEType
    {
        
        [Description("uicc")]
        uicc,
        
        [Description("eSE")]
        eSE,
    }
    
    public enum SEError
    {
        
        [Description("SESecurityError")]
        SESecurityError,
        
        [Description("SEIoError")]
        SEIoError,
        
        [Description("SEBadStateError")]
        SEBadStateError,
        
        [Description("SEInvalidChannelError")]
        SEInvalidChannelError,
        
        [Description("SEInvalidApplicationError")]
        SEInvalidApplicationError,
        
        [Description("SENotPresentError")]
        SENotPresentError,
        
        [Description("SEIllegalParameterError")]
        SEIllegalParameterError,
        
        [Description("SEGenericError")]
        SEGenericError,
    }
    
    public enum SEChannelType
    {
        
        [Description("basic")]
        basic,
        
        [Description("logical")]
        logical,
    }
    
    public enum SelectionState
    {
        
        [Description("drag")]
        drag,
        
        [Description("mousedown")]
        mousedown,
        
        [Description("mouseup")]
        mouseup,
        
        [Description("keypress")]
        keypress,
        
        [Description("selectall")]
        selectall,
        
        [Description("collapsetostart")]
        collapsetostart,
        
        [Description("collapsetoend")]
        collapsetoend,
        
        [Description("blur")]
        blur,
        
        [Description("updateposition")]
        updateposition,
        
        [Description("taponcaret")]
        taponcaret,
    }
    
    public enum ServiceWorkerState
    {
        
        [Description("installing")]
        installing,
        
        [Description("installed")]
        installed,
        
        [Description("activating")]
        activating,
        
        [Description("activated")]
        activated,
        
        [Description("redundant")]
        redundant,
    }
    
    public enum SocketReadyState
    {
        
        [Description("opening")]
        opening,
        
        [Description("open")]
        open,
        
        [Description("closing")]
        closing,
        
        [Description("closed")]
        closed,
        
        [Description("halfclosed")]
        halfclosed,
    }
    
    public enum SourceBufferAppendMode
    {
        
        [Description("segments")]
        segments,
        
        [Description("sequence")]
        sequence,
    }
    
    public enum SpeechRecognitionErrorCode
    {
        
        [Description("no-speech")]
        nospeech,
        
        [Description("aborted")]
        aborted,
        
        [Description("audio-capture")]
        audiocapture,
        
        [Description("network")]
        network,
        
        [Description("not-allowed")]
        notallowed,
        
        [Description("service-not-allowed")]
        servicenotallowed,
        
        [Description("bad-grammar")]
        badgrammar,
        
        [Description("language-not-supported")]
        languagenotsupported,
    }
    
    public enum SpeechSynthesisErrorCode
    {
        
        [Description("canceled")]
        canceled,
        
        [Description("interrupted")]
        interrupted,
        
        [Description("audio-busy")]
        audiobusy,
        
        [Description("audio-hardware")]
        audiohardware,
        
        [Description("network")]
        network,
        
        [Description("synthesis-unavailable")]
        synthesisunavailable,
        
        [Description("synthesis-failed")]
        synthesisfailed,
        
        [Description("language-unavailable")]
        languageunavailable,
        
        [Description("voice-unavailable")]
        voiceunavailable,
        
        [Description("text-too-long")]
        texttoolong,
        
        [Description("invalid-argument")]
        invalidargument,
    }
    
    public enum StorageType
    {
        
        [Description("persistent")]
        persistent,
        
        [Description("temporary")]
        temporary,
        
        [Description("default")]
        @default,
    }
    
    public enum TCPSocketBinaryType
    {
        
        [Description("arraybuffer")]
        arraybuffer,
        
        [Description("string")]
        @string,
    }
    
    public enum TCPReadyState
    {
        
        [Description("connecting")]
        connecting,
        
        [Description("open")]
        open,
        
        [Description("closing")]
        closing,
        
        [Description("closed")]
        closed,
    }
    
    public enum TelephonyCallState
    {
        
        [Description("dialing")]
        dialing,
        
        [Description("alerting")]
        alerting,
        
        [Description("connected")]
        connected,
        
        [Description("held")]
        held,
        
        [Description("disconnected")]
        disconnected,
        
        [Description("incoming")]
        incoming,
    }
    
    public enum TelephonyCallDisconnectedReason
    {
        
        [Description("BadNumber")]
        BadNumber,
        
        [Description("NoRouteToDestination")]
        NoRouteToDestination,
        
        [Description("ChannelUnacceptable")]
        ChannelUnacceptable,
        
        [Description("OperatorDeterminedBarring")]
        OperatorDeterminedBarring,
        
        [Description("NormalCallClearing")]
        NormalCallClearing,
        
        [Description("Busy")]
        Busy,
        
        [Description("NoUserResponding")]
        NoUserResponding,
        
        [Description("UserAlertingNoAnswer")]
        UserAlertingNoAnswer,
        
        [Description("CallRejected")]
        CallRejected,
        
        [Description("NumberChanged")]
        NumberChanged,
        
        [Description("CallRejectedDestinationFeature")]
        CallRejectedDestinationFeature,
        
        [Description("PreEmption")]
        PreEmption,
        
        [Description("DestinationOutOfOrder")]
        DestinationOutOfOrder,
        
        [Description("InvalidNumberFormat")]
        InvalidNumberFormat,
        
        [Description("FacilityRejected")]
        FacilityRejected,
        
        [Description("ResponseToStatusEnquiry")]
        ResponseToStatusEnquiry,
        
        [Description("Congestion")]
        Congestion,
        
        [Description("NetworkOutOfOrder")]
        NetworkOutOfOrder,
        
        [Description("NetworkTempFailure")]
        NetworkTempFailure,
        
        [Description("SwitchingEquipCongestion")]
        SwitchingEquipCongestion,
        
        [Description("AccessInfoDiscarded")]
        AccessInfoDiscarded,
        
        [Description("RequestedChannelNotAvailable")]
        RequestedChannelNotAvailable,
        
        [Description("ResourceUnavailable")]
        ResourceUnavailable,
        
        [Description("QosUnavailable")]
        QosUnavailable,
        
        [Description("RequestedFacilityNotSubscribed")]
        RequestedFacilityNotSubscribed,
        
        [Description("IncomingCallsBarredWithinCug")]
        IncomingCallsBarredWithinCug,
        
        [Description("BearerCapabilityNotAuthorized")]
        BearerCapabilityNotAuthorized,
        
        [Description("BearerCapabilityNotAvailable")]
        BearerCapabilityNotAvailable,
        
        [Description("BearerNotImplemented")]
        BearerNotImplemented,
        
        [Description("ServiceNotAvailable")]
        ServiceNotAvailable,
        
        [Description("IncomingCallExceeded")]
        IncomingCallExceeded,
        
        [Description("RequestedFacilityNotImplemented")]
        RequestedFacilityNotImplemented,
        
        [Description("UnrestrictedBearerNotAvailable")]
        UnrestrictedBearerNotAvailable,
        
        [Description("ServiceNotImplemented")]
        ServiceNotImplemented,
        
        [Description("InvalidTransactionId")]
        InvalidTransactionId,
        
        [Description("NotCugMember")]
        NotCugMember,
        
        [Description("IncompatibleDestination")]
        IncompatibleDestination,
        
        [Description("InvalidTransitNetworkSelection")]
        InvalidTransitNetworkSelection,
        
        [Description("SemanticallyIncorrectMessage")]
        SemanticallyIncorrectMessage,
        
        [Description("InvalidMandatoryInfo")]
        InvalidMandatoryInfo,
        
        [Description("MessageTypeNotImplemented")]
        MessageTypeNotImplemented,
        
        [Description("MessageTypeIncompatibleProtocolState")]
        MessageTypeIncompatibleProtocolState,
        
        [Description("InfoElementNotImplemented")]
        InfoElementNotImplemented,
        
        [Description("ConditionalIe")]
        ConditionalIe,
        
        [Description("MessageIncompatibleProtocolState")]
        MessageIncompatibleProtocolState,
        
        [Description("RecoveryOnTimerExpiry")]
        RecoveryOnTimerExpiry,
        
        [Description("Protocol")]
        Protocol,
        
        [Description("Interworking")]
        Interworking,
        
        [Description("Barred")]
        Barred,
        
        [Description("FDNBlocked")]
        FDNBlocked,
        
        [Description("SubscriberUnknown")]
        SubscriberUnknown,
        
        [Description("DeviceNotAccepted")]
        DeviceNotAccepted,
        
        [Description("ModifiedDial")]
        ModifiedDial,
        
        [Description("CdmaLockedUntilPowerCycle")]
        CdmaLockedUntilPowerCycle,
        
        [Description("CdmaDrop")]
        CdmaDrop,
        
        [Description("CdmaIntercept")]
        CdmaIntercept,
        
        [Description("CdmaReorder")]
        CdmaReorder,
        
        [Description("CdmaSoReject")]
        CdmaSoReject,
        
        [Description("CdmaRetryOrder")]
        CdmaRetryOrder,
        
        [Description("CdmaAcess")]
        CdmaAcess,
        
        [Description("CdmaPreempted")]
        CdmaPreempted,
        
        [Description("CdmaNotEmergency")]
        CdmaNotEmergency,
        
        [Description("CdmaAccessBlocked")]
        CdmaAccessBlocked,
        
        [Description("Unspecified")]
        Unspecified,
    }
    
    public enum TelephonyCallGroupState
    {
        
        [Description("connected")]
        connected,
        
        [Description("held")]
        held,
    }
    
    public enum CallIdPresentation
    {
        
        [Description("allowed")]
        allowed,
        
        [Description("restricted")]
        restricted,
        
        [Description("payphone")]
        payphone,
        
        [Description("unknown")]
        unknown,
    }
    
    public enum TextTrackKind
    {
        
        [Description("subtitles")]
        subtitles,
        
        [Description("captions")]
        captions,
        
        [Description("descriptions")]
        descriptions,
        
        [Description("chapters")]
        chapters,
        
        [Description("metadata")]
        metadata,
    }
    
    public enum TextTrackMode
    {
        
        [Description("disabled")]
        disabled,
        
        [Description("hidden")]
        hidden,
        
        [Description("showing")]
        showing,
    }
    
    public enum TVChannelType
    {
        
        [Description("tv")]
        tv,
        
        [Description("radio")]
        radio,
        
        [Description("data")]
        data,
    }
    
    public enum TVScanningState
    {
        
        [Description("cleared")]
        cleared,
        
        [Description("scanned")]
        scanned,
        
        [Description("completed")]
        completed,
        
        [Description("stopped")]
        stopped,
    }
    
    public enum TVSourceType
    {
        
        [Description("dvb-t")]
        dvbt,
        
        [Description("dvb-t2")]
        dvbt2,
        
        [Description("dvb-c")]
        dvbc,
        
        [Description("dvb-c2")]
        dvbc2,
        
        [Description("dvb-s")]
        dvbs,
        
        [Description("dvb-s2")]
        dvbs2,
        
        [Description("dvb-h")]
        dvbh,
        
        [Description("dvb-sh")]
        dvbsh,
        
        [Description("atsc")]
        atsc,
        
        [Description("atsc-m/h")]
        atscmh,
        
        [Description("isdb-t")]
        isdbt,
        
        [Description("isdb-tb")]
        isdbtb,
        
        [Description("isdb-s")]
        isdbs,
        
        [Description("isdb-c")]
        isdbc,
        
        [Description("1seg")]
        _1seg,
        
        [Description("dtmb")]
        dtmb,
        
        [Description("cmmb")]
        cmmb,
        
        [Description("t-dmb")]
        tdmb,
        
        [Description("s-dmb")]
        sdmb,
    }
    
    public enum VREye
    {
        
        [Description("left")]
        left,
        
        [Description("right")]
        right,
    }
    
    public enum AutoKeyword
    {
        
        [Description("auto")]
        auto,
    }
    
    public enum AlignSetting
    {
        
        [Description("start")]
        start,
        
        [Description("middle")]
        middle,
        
        [Description("end")]
        end,
        
        [Description("left")]
        left,
        
        [Description("right")]
        right,
    }
    
    public enum DirectionSetting
    {
        
        [Description("rl")]
        rl,
        
        [Description("lr")]
        lr,
    }
    
    public enum OverSampleType
    {
        
        [Description("none")]
        none,
        
        [Description("2x")]
        _2x,
        
        [Description("4x")]
        _4x,
    }
    
    public enum BinaryType
    {
        
        [Description("blob")]
        blob,
        
        [Description("arraybuffer")]
        arraybuffer,
    }
    
    public enum ScrollBehavior
    {
        
        [Description("auto")]
        auto,
        
        [Description("instant")]
        instant,
        
        [Description("smooth")]
        smooth,
    }
    
    public enum XMLHttpRequestResponseType
    {
        
        [Description("arraybuffer")]
        arraybuffer,
        
        [Description("blob")]
        blob,
        
        [Description("document")]
        document,
        
        [Description("json")]
        json,
        
        [Description("text")]
        text,
        
        [Description("moz-chunked-text")]
        mozchunkedtext,
        
        [Description("moz-chunked-arraybuffer")]
        mozchunkedarraybuffer,
        
        [Description("moz-blob")]
        mozblob,
    }
}
