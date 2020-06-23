using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using RedRat.IR;
using RedRat.RedRat3;

namespace RedRat.TestRemote {

	/// <summary>
	/// Allows configuration of properties associated with a button.
	/// </summary>
	public class ButtonPropertiesDialog : System.Windows.Forms.Form {
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox buttonTextBox;
    private System.Windows.Forms.Button learnIRButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;

	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.Container components = null;

    protected IRButton thisButton;

    protected NewRemote parent;

    protected IRPacket irPacket;

    protected bool changed;

	public ButtonPropertiesDialog(IRButton initIRButton, NewRemote initParent) 
    {
		InitializeComponent();

        thisButton = initIRButton;
        parent     = initParent;

        // Set GUI state from button
        buttonTextBox.Text = thisButton.Text;
	}

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	protected override void Dispose( bool disposing )
	{
		if( disposing )
		{
			if(components != null)
			{
				components.Dispose();
			}
		}
		base.Dispose( disposing );
	}

	#region Windows Form Designer generated code
	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
        this.label1 = new System.Windows.Forms.Label();
        this.buttonTextBox = new System.Windows.Forms.TextBox();
        this.learnIRButton = new System.Windows.Forms.Button();
        this.okButton = new System.Windows.Forms.Button();
        this.cancelButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(29, 41);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(129, 27);
        this.label1.TabIndex = 0;
        this.label1.Text = "Button Text:";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // buttonTextBox
        // 
        this.buttonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.buttonTextBox.Location = new System.Drawing.Point(187, 41);
        this.buttonTextBox.Name = "buttonTextBox";
        this.buttonTextBox.Size = new System.Drawing.Size(180, 29);
        this.buttonTextBox.TabIndex = 1;
        this.buttonTextBox.TextChanged += new System.EventHandler(this.buttonTextBox_TextChanged);
        // 
        // learnIRButton
        // 
        this.learnIRButton.Location = new System.Drawing.Point(130, 108);
        this.learnIRButton.Name = "learnIRButton";
        this.learnIRButton.Size = new System.Drawing.Size(135, 39);
        this.learnIRButton.TabIndex = 2;
        this.learnIRButton.Text = "Learn IR";
        this.learnIRButton.Click += new System.EventHandler(this.learnIRButton_Click);
        // 
        // okButton
        // 
        this.okButton.Location = new System.Drawing.Point(43, 190);
        this.okButton.Name = "okButton";
        this.okButton.Size = new System.Drawing.Size(135, 38);
        this.okButton.TabIndex = 3;
        this.okButton.Text = "OK";
        this.okButton.Click += new System.EventHandler(this.okButton_Click);
        // 
        // cancelButton
        // 
        this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.cancelButton.Location = new System.Drawing.Point(245, 190);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new System.Drawing.Size(135, 38);
        this.cancelButton.TabIndex = 4;
        this.cancelButton.Text = "Cancel";
        // 
        // ButtonPropertiesDialog
        // 
        this.AcceptButton = this.okButton;
        this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
        this.CancelButton = this.cancelButton;
        this.ClientSize = new System.Drawing.Size(450, 277);
        this.Controls.Add(this.cancelButton);
        this.Controls.Add(this.okButton);
        this.Controls.Add(this.learnIRButton);
        this.Controls.Add(this.buttonTextBox);
        this.Controls.Add(this.label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Name = "ButtonPropertiesDialog";
        this.Text = "Properties";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
	#endregion

    private void okButton_Click(object sender, System.EventArgs e) 
    {
        // Set IRButton state from info here..
        thisButton.Text = buttonTextBox.Text;
        thisButton.Info.Text = buttonTextBox.Text;
        thisButton.Info.IRPacket = irPacket;
        parent.Changed = changed;
        this.Close();
    }

    private void buttonTextBox_TextChanged(object sender, System.EventArgs e) 
    {
        changed = true;
    }

    /// <summary>
    /// Capture/learn a remote control signal.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void learnIRButton_Click(object sender, System.EventArgs e) {
      IRedRat3 rr3 = parent.RedRat3;
      if (rr3 == null) {
        return;
      }

      SignalInputDialog signalInputDialog = null;

      // == Right, this is probably the most complicated bit of interaction ==
      // == with the RR3 in this program - but its not too bad really.      ==
      try {
        // 1. Tell the RR3 we want to input a demodulated signal (learn)
        rr3.GetModulatedSignal(0);

        // 2. Create modal dialog that allows us to cancel the operation if required.
        signalInputDialog = new SignalInputDialog(rr3);

        // 3. The dialog box has to handle the input signal event from the RR3.
        rr3.LearningSignalIn += new EventHandler(signalInputDialog.SignalDataIn);

        // 4. Popup dialog....
        signalInputDialog.ShowDialog(this);

        // 5. Once finished, get the event object
        SignalEventArgs siea = signalInputDialog.SignalInEvent;

        // Have input data of some kind...
        if (siea.Action == SignalEventAction.MODULATED_SIGNAL) {
          irPacket = siea.IRPacket;
          changed = true;
        }
          
          // We have had some error from the comms with the USB device, so read exception and throw it.
        else if (siea.Action == SignalEventAction.EXCEPTION) {
          throw siea.Exception;
        } 
          
          // The user has pressed cancel
        else if (siea.Action == SignalEventAction.INPUT_CANCELLED) {
          // Don't need to do anything here.
        }

      } catch (Exception ex) {
        string msg = ex.Message;
        if (ex.InnerException != null) {
          msg += ": " + ex.InnerException.Message;
        }
        MessageBox.Show(msg, "Communication Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      finally {
        // Remove listener...
        if (signalInputDialog != null) {
          rr3.LearningSignalIn -= new EventHandler(signalInputDialog.SignalDataIn);
        }
        signalInputDialog.Close();
      }
    }
	}
}
