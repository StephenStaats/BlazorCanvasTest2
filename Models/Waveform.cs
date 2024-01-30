using Blazor.Extensions.Canvas.Canvas2D;
using Blazor.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCanvasTest2.Shared.Data;


namespace BlazorCanvasTest2.Models
{
    public class Waveform
    {
        Enums.Z_WAVEFORM_ID WaveformID;
        public double Top { get; private set; }
        public double Bottom { get; private set; }
        public double Left { get; private set; }
        public double Right { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        public string Color { get; private set; }

        public double DrawX { get; set; }
        public double EraseX { get; set; }
        public double SweepSpeed { get; set; }
        public double DrawY { get; set; }
        public double YOffset { get; set; }
        public double YScaleFactor { get; set; }
        public int SampleIndex { get; set; }
        public int MaxSampleIndex { get; set; }
        public double[] Samples { get; set; }


        public bool AutoScale { get; set; }
        public bool Fill { get; set; }
        public double YMin { get; set; }
        public double YMax { get; set; }
        public double Range { get; set; }

        BlazorCanvasTest2.Shared.Data.SampleData MySampleData = new SampleData() ;

        public Waveform(Enums.Z_WAVEFORM_ID WaveformId, double left, double top, double width, double height, string color, bool fill, double drawX, double eraseX, double sweepSpeed, double drawY, bool autoScale, double yMin, double yMax, double yScaleFactor, int sampleIndex)
        {
            (WaveformID, Left, Top, Width, Height, Color, Fill, DrawX, EraseX, SweepSpeed, DrawY, AutoScale, YMin, YMax, YScaleFactor, SampleIndex) = (WaveformId, left, top, width, height, color, fill, drawX, eraseX, sweepSpeed, drawY, autoScale, yMin, yMax, yScaleFactor, sampleIndex);

            Bottom = Top + Height ;

            Right = Left + Width ;

            YOffset = Top + Height / 2 ;

            AddSampleData(WaveformID) ;

            if (AutoScale) { 

                YMin = double.MaxValue;
                YMax = double.MinValue;

                for (int s = 0; s < Samples.Length; s++) {
                   if (Samples[s] < YMin) { YMin = Samples[s]; }
                   if (Samples[s] > YMax) { YMax = Samples[s]; }
                }

                Range = YMax - YMin;

                YMax += Range * 3.0;
                //YMin -= Range * 1.0;
            }

            Range = YMax - YMin;

        }

        public void AddSampleData(Enums.Z_WAVEFORM_ID WaveformId)
        {
            switch (WaveformId)
            {
                case Enums.Z_WAVEFORM_ID.Z_WAVEFORM_ECGII:
                    Samples = MySampleData.GetECGIISamples();
                    break;
                case Enums.Z_WAVEFORM_ID.Z_WAVEFORM_CO2:
                    Samples = MySampleData.GetCO2Samples();
                    break;
                default:
                    Samples = MySampleData.GetECGIISamples();
                    break;
            }

            MaxSampleIndex = Samples.Count();
        }

    }

}
