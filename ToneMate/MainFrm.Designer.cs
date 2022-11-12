namespace ToneMate;

partial class MainFrm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.groupTone = new System.Windows.Forms.GroupBox();
            this.radioPink = new System.Windows.Forms.RadioButton();
            this.radioSquare = new System.Windows.Forms.RadioButton();
            this.radioTriangle = new System.Windows.Forms.RadioButton();
            this.buttonSawtooth = new System.Windows.Forms.RadioButton();
            this.radioSine = new System.Windows.Forms.RadioButton();
            this.radioSilence = new System.Windows.Forms.RadioButton();
            this.numericFrequency = new System.Windows.Forms.NumericUpDown();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.numericLength = new System.Windows.Forms.NumericUpDown();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupTone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTone
            // 
            this.groupTone.Controls.Add(this.radioPink);
            this.groupTone.Controls.Add(this.radioSquare);
            this.groupTone.Controls.Add(this.radioTriangle);
            this.groupTone.Controls.Add(this.buttonSawtooth);
            this.groupTone.Controls.Add(this.radioSine);
            this.groupTone.Controls.Add(this.radioSilence);
            this.groupTone.Location = new System.Drawing.Point(11, 12);
            this.groupTone.Name = "groupTone";
            this.groupTone.Size = new System.Drawing.Size(222, 125);
            this.groupTone.TabIndex = 0;
            this.groupTone.TabStop = false;
            this.groupTone.Text = "Tone";
            // 
            // radioPink
            // 
            this.radioPink.AutoSize = true;
            this.radioPink.Location = new System.Drawing.Point(122, 86);
            this.radioPink.Name = "radioPink";
            this.radioPink.Size = new System.Drawing.Size(57, 24);
            this.radioPink.TabIndex = 5;
            this.radioPink.TabStop = true;
            this.radioPink.Text = "Pink";
            this.radioPink.UseVisualStyleBackColor = true;
            // 
            // radioSquare
            // 
            this.radioSquare.AutoSize = true;
            this.radioSquare.Location = new System.Drawing.Point(6, 86);
            this.radioSquare.Name = "radioSquare";
            this.radioSquare.Size = new System.Drawing.Size(76, 24);
            this.radioSquare.TabIndex = 4;
            this.radioSquare.TabStop = true;
            this.radioSquare.Text = "Square";
            this.radioSquare.UseVisualStyleBackColor = true;
            // 
            // radioTriangle
            // 
            this.radioTriangle.AutoSize = true;
            this.radioTriangle.Location = new System.Drawing.Point(122, 56);
            this.radioTriangle.Name = "radioTriangle";
            this.radioTriangle.Size = new System.Drawing.Size(83, 24);
            this.radioTriangle.TabIndex = 3;
            this.radioTriangle.TabStop = true;
            this.radioTriangle.Text = "Triangle";
            this.radioTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonSawtooth
            // 
            this.buttonSawtooth.AutoSize = true;
            this.buttonSawtooth.Location = new System.Drawing.Point(6, 56);
            this.buttonSawtooth.Name = "buttonSawtooth";
            this.buttonSawtooth.Size = new System.Drawing.Size(93, 24);
            this.buttonSawtooth.TabIndex = 2;
            this.buttonSawtooth.TabStop = true;
            this.buttonSawtooth.Text = "Sawtooth";
            this.buttonSawtooth.UseVisualStyleBackColor = true;
            // 
            // radioSine
            // 
            this.radioSine.AutoSize = true;
            this.radioSine.Checked = true;
            this.radioSine.Location = new System.Drawing.Point(122, 26);
            this.radioSine.Name = "radioSine";
            this.radioSine.Size = new System.Drawing.Size(58, 24);
            this.radioSine.TabIndex = 1;
            this.radioSine.TabStop = true;
            this.radioSine.Text = "Sine";
            this.radioSine.UseVisualStyleBackColor = true;
            // 
            // radioSilence
            // 
            this.radioSilence.AutoSize = true;
            this.radioSilence.Location = new System.Drawing.Point(6, 26);
            this.radioSilence.Name = "radioSilence";
            this.radioSilence.Size = new System.Drawing.Size(77, 24);
            this.radioSilence.TabIndex = 0;
            this.radioSilence.TabStop = true;
            this.radioSilence.Text = "Silence";
            this.radioSilence.UseVisualStyleBackColor = true;
            this.radioSilence.CheckedChanged += new System.EventHandler(this.radioSilence_CheckedChanged);
            // 
            // numericFrequency
            // 
            this.numericFrequency.Location = new System.Drawing.Point(321, 24);
            this.numericFrequency.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericFrequency.Name = "numericFrequency";
            this.numericFrequency.Size = new System.Drawing.Size(207, 27);
            this.numericFrequency.TabIndex = 1;
            this.numericFrequency.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(239, 26);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(76, 20);
            this.labelFrequency.TabIndex = 2;
            this.labelFrequency.Text = "Frequency";
            this.labelFrequency.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(239, 58);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(54, 20);
            this.labelLength.TabIndex = 3;
            this.labelLength.Text = "Length";
            // 
            // numericLength
            // 
            this.numericLength.Location = new System.Drawing.Point(321, 56);
            this.numericLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericLength.Name = "numericLength";
            this.numericLength.Size = new System.Drawing.Size(207, 27);
            this.numericLength.TabIndex = 4;
            this.numericLength.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(11, 143);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(94, 29);
            this.buttonPreview.TabIndex = 5;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(434, 143);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 180);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.numericLength);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.numericFrequency);
            this.Controls.Add(this.groupTone);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ToneMate";
            this.groupTone.ResumeLayout(false);
            this.groupTone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private GroupBox groupTone;
    private RadioButton radioSilence;
    private RadioButton radioSine;
    private NumericUpDown numericFrequency;
    private Label labelFrequency;
    private Label labelLength;
    private NumericUpDown numericLength;
    private Button buttonPreview;
    private Button buttonSave;
    private RadioButton buttonSawtooth;
    private RadioButton radioTriangle;
    private RadioButton radioSquare;
    private RadioButton radioPink;
}
