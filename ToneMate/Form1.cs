namespace ToneMate;

using NAudio.Wave;
using NAudio.Wave.SampleProviders;

public partial class Form1 : Form
{
    private WaveOutEvent? playback;

    public Form1()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private SignalGenerator Create()
    {
        var result = new SignalGenerator(32000, 1)
        {
            Frequency = (int)numericFrequency.Value
        };

        if (radioSine.Checked)
        {
            result.Type = SignalGeneratorType.Sin;
        }
        else if (buttonSawtooth.Checked)
        {
            result.Type = SignalGeneratorType.SawTooth;
        }
        else if (radioTriangle.Checked)
        {
            result.Type = SignalGeneratorType.Triangle;
        }
        else if (radioSquare.Checked)
        {
            result.Type = SignalGeneratorType.Square;
        }
        else if (radioPink.Checked)
        {
            result.Type = SignalGeneratorType.Pink;
        }
        else
        {
            result.Type = SignalGeneratorType.Sin;
        }

        return result;
    }

    private void buttonPreview_Click(object sender, EventArgs e)
    {
        var wo = new WaveOutEvent();

        wo.Init(Create().Take(TimeSpan.FromMilliseconds((double)numericLength.Value)));
        wo.Play();

        this.Enabled = false;
        playback = wo;

        wo.PlaybackStopped += Wo_PlaybackStopped;
    }

    private void Wo_PlaybackStopped(object? sender, StoppedEventArgs e)
    {
        if (playback != null)
        {
            playback.PlaybackStopped -= Wo_PlaybackStopped;
            playback = null;
        }

        this.Enabled = true;
    }

    private void radioSilence_CheckedChanged(object sender, EventArgs e)
    {
        if (radioSilence.Checked)
        {
            numericFrequency.Enabled = false;
            buttonPreview.Enabled = false;
        }
        else
        {
            buttonPreview.Enabled = true;
            numericFrequency.Enabled = true;
        }
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        this.Enabled = false;
        var sfd = new SaveFileDialog()
        {
            Filter = "Wave file|*.wav",
            CheckWriteAccess = true,
            OverwritePrompt = true,
        };

        if (sfd.ShowDialog() != DialogResult.OK)
        {
            this.Enabled = true;
            return;
        }

        var format = new WaveFormat(32000, 16, 1);
        
        if (radioSilence.Checked)
        {
            WaveFileWriter.CreateWaveFile(sfd.FileName, new SilenceProvider(format).ToSampleProvider().Take(
                TimeSpan.FromMilliseconds((double)numericLength.Value)).ToWaveProvider());
            this.Enabled = true;
            return;
        }

        var provider = Create().Take(TimeSpan.FromMilliseconds((double)numericLength.Value));

        WaveFileWriter.CreateWaveFile(sfd.FileName, provider.ToWaveProvider());
        this.Enabled = true;
    }
}
