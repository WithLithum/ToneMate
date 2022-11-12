namespace ToneMate.Providers;

using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class SilenceWaveProvider : IWaveProvider
{
    public WaveFormat WaveFormat { get; } = new WaveFormat(32000, 16, 1);

    public int Read(byte[] buffer, int offset, int count)
    {
        for (int n = 0; n < count; n++) buffer[offset++] = 0;
        return count;
    }
}
