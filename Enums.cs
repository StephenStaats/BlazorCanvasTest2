namespace BlazorCanvasTest2.Enums
{ 
    public enum Z_WAVEFORM_ID
    {

        Z_WAVEFORM_ECGI = 0,                 //   0
        Z_WAVEFORM_ECGII,                    //   1
        Z_WAVEFORM_ECGIII,                   //   2
        Z_WAVEFORM_ECGV,                     //   3
        Z_WAVEFORM_NCO,                      //   4 
        Z_WAVEFORM_Z0NCO,                    //   5
        Z_WAVEFORM_SPO2RED,                  //   6
        Z_WAVEFORM_SPO2IR,                   //   7     (is used for display in PPM world)
        Z_WAVEFORM_SPO2OHMS,                 //   8
        Z_WAVEFORM_SPO2REDDC,                //   9
        Z_WAVEFORM_SPO2IRDC,                 //  10
        Z_WAVEFORM_RESP,                     //  11
        Z_WAVEFORM_RESP_AUTO,                //  12     (auto-scaled for display)
        Z_WAVEFORM_TEMP,                     //  13
        Z_WAVEFORM_NBP,                      //  14
        Z_WAVEFORM_NBPAC,                    //  15     (for display - DC offset removed at each step)
        Z_WAVEFORM_IBP,                      //  16     (for alg)
        Z_WAVEFORM_IBP_DISPLAY,              //  17     (for display - DC offset removed)
        Z_WAVEFORM_SPO2RED_NOAMB,            //  18     (SpO2 RED without ambient subtracted)
        Z_WAVEFORM_SPO2,                     //  19     (used for display in PPM2 world)
        Z_WAVEFORM_CO2,                      //  20     (from CO2 module or Gas Bench)
        Z_WAVEFORM_CO2_TREND,                //  21
        Z_WAVEFORM_ECGAVL,                   //  22
        Z_WAVEFORM_ECGAVR,                   //  23
        Z_WAVEFORM_ECGAVF,                   //  24
        Z_WAVEFORM_IBP2,                     //  25     (for alg)
        Z_WAVEFORM_IBP2_DISPLAY,             //  26     (for display - DC offset removed)
        Z_WAVEFORM_ECGV1,                    //  27
        Z_WAVEFORM_ECGV2,                    //  28
        Z_WAVEFORM_ECGV3,                    //  29
        Z_WAVEFORM_ECGV4,                    //  30
        Z_WAVEFORM_ECGV5,                    //  31
        Z_WAVEFORM_ECGV6,                    //  32
        Z_WAVEFORM_ECGTHUMB,                 //  33
        Z_WAVEFORM_SPO2_SIGNAL_IQ,           //  34
        Z_WAVEFORM_IBP3,                     //  35
        Z_WAVEFORM_IBP3_DISPLAY,             //  36
        Z_WAVEFORM_IBP4,                     //  37
        Z_WAVEFORM_IBP4_DISPLAY,             //  38
        Z_WAVEFORM_CO,                       //  39     Cardiac Output - Blood Temp, inverted, baseline removed
        Z_WAVEFORM_CO_BT,                    //  40     Cardiac Output - Blood Temp
        Z_WAVEFORM_CO_IT,                    //  41     Cardiac Output - Injectate Temp
        Z_WAVEFORM_TEMP2,                    //  42
        Z_WAVEFORM_RRA,                      //  43
        Z_WAVEFORM_PULMONARY_AIR_FLOW,       //  44     Spirometery run-time waveform (Flow(t))
        Z_WAVEFORM_O2,                       //  45     O2 (from Gas Bench)
        Z_WAVEFORM_AGENT,                    //  46     Primary Anesthetic Agent (from Gas Bench)
        Z_WAVEFORM_N2O,                      //  47     N2O (from Gas Bench)
        Z_WAVEFORM_OFF,                      //  48
        Z_WAVEFORM_INVALID                   //  49

    }

}

