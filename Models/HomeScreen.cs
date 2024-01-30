using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCanvasTest2.Models
{
    public class HomeScreen
    {

        public readonly List<Waveform> Waveforms = new List<Waveform>();

        // #define SCREEN_W                        1366   // DSW10 display X resolution
        // #define SCREEN_H                         768   // DSW10 display Y resolution

        //Enums.Z_WAVEFORM_ID[] WaveformIDs ;

        public double Width { get; private set; }
        public double Height { get; private set; }

        public double HeaderWidth { get; set; }
        public double HeaderHeight { get; set; }
        public double HeaderLeft { get; set; }
        public double HeaderRight { get; set; }
        public double HeaderTop { get; set; }
        public double HeaderBottom { get; set; }

        public double WaveformAreaWidth { get; set; }
        public double WaveformAreaHeight { get; set; }
        public double WaveformAreaLeft { get; set; }
        public double WaveformAreaRight { get; set; }
        public double WaveformAreaTop { get; set; }
        public double WaveformAreaBottom { get; set; }

        public double RightParamAreaWidth { get; set; }
        public double RightParamAreaHeight { get; set; }
        public double RightParamAreaLeft { get; set; }
        public double RightParamAreaRight { get; set; }
        public double RightParamAreaTop { get; set; }
        public double RightParamAreaBottom { get; set; }

        public double BottomParamAreaWidth { get; set; }
        public double BottomParamAreaHeight { get; set; }
        public double BottomParamAreaLeft { get; set; }
        public double BottomParamAreaRight { get; set; }
        public double BottomParamAreaTop { get; set; }
        public double BottomParamAreaBottom { get; set; }

        public double MessageAreaWidth { get; set; }
        public double MessageAreaHeight { get; set; }
        public double MessageAreaLeft { get; set; }
        public double MessageAreaRight { get; set; }
        public double MessageAreaTop { get; set; }
        public double MessageAreaBottom { get; set; }

        public void Resize(double width, double height) =>
            (Width, Height) = (width, height);

        //public void AddWaveforms(Enums.Z_WAVEFORM_ID[] WaveformSet)
        //{
        //    double WaveformHeight = WaveformAreaHeight / WaveformSet.Count();

        //    for (int w = 0; w < WaveformSet.Count(); w++)
        //    {
        //        Waveforms.Add(
        //            new Waveform(
        //                WaveformId: WaveformSet[w],
        //                left: WaveformAreaLeft,
        //                top: WaveformAreaTop + w * WaveformHeight,
        //                width: WaveformAreaWidth,
        //                height: WaveformAreaHeight,
        //                color: "#00FF00"
        //            )
        //        );
        //    }
        //}

        public void ClearWaveformList()
        {
            Waveforms.Clear() ;
        }

        public void AddWaveform(Enums.Z_WAVEFORM_ID WaveformId, double WaveformAreaLeft, double WaveformAreaTop, double WaveformAreaWidth, double WaveformAreaHeight, string WaveformColor, bool Fill, double DrawX, double EraseX, double SweepSpeed, double DrawY, bool AutoScale, double YMin, double YMax, double YScaleFactor, int SampleIndex)
        {
            Waveforms.Add(
                new Waveform(
                    WaveformId: WaveformId,
                    left: WaveformAreaLeft,
                    top: WaveformAreaTop,
                    width: WaveformAreaWidth,
                    height: WaveformAreaHeight,
                    color: WaveformColor,
                    fill: Fill,
                    drawX: DrawX,
                    eraseX: EraseX,
                    sweepSpeed: SweepSpeed,
                    drawY: DrawY,
                    autoScale: AutoScale,
                    yMin: YMin,
                    yMax: YMax,
                    yScaleFactor: YScaleFactor,
                    sampleIndex: SampleIndex
                )
            );
            
        }
    }
}
