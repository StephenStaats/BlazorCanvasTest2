using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCanvasTest2.Models
{
    public class HomeScreen
    {

        public readonly List<Waveform> Waveforms = new List<Waveform>();

        // #define SCREEN_W                        1366   // DSW10 display X resolution
        // #define SCREEN_H                         768   // DSW10 display Y resolution

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

        public void AddWaveforms(int count = 4)
        {
            double WaveformHeight = WaveformAreaHeight / count ;

            for (int i = 0; i < count; i++)
            {
                Waveforms.Add(
                    new Waveform(
                        left: WaveformAreaLeft,
                        top: WaveformAreaTop + i * WaveformHeight,
                        width: WaveformAreaWidth,
                        height: WaveformAreaHeight,
                        color: "#00FF00"
                    )
                );
            }
        }
    }
}
