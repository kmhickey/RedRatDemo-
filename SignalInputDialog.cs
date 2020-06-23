using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using RedRat.IR;
using RedRat.RedRat3;

namespace RedRat.TestRemote {

  /// <summary>
  /// Dialog box used to wait for IR input. It closes when IR data received, or Cancel pressed.
  /// </summary>
  public class SignalInputDialog : System.Windows.Forms.Form {

    /// <summary>
    /// Input IR event
    /// </summary>
    protected SignalEventArgs sigInEvent;

    /// <summary>
    /// If some error has been encountered, it is stored here.
    /// </summary>
    protected Exception irInEx;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button cancelButton;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    private IRedRat3 rr3;

    protected delegate void CloseCallback();

    public SignalInputDialog(IRedRat3 initRR3) {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();
      rr3 = initRR3;
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing ) {
      if( disposing ) {
        if(components != null) {
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
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.cancelButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(40, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(168, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Waiting for IR signal input....";
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(80, 64);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.TabIndex = 1;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // SignalInputDialog
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(234, 103);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.cancelButton,
                                                                  this.label1});
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "SignalInputDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Signal Input";
      this.ResumeLayout(false);

    }
		#endregion
 
    /// <summary>
    /// Handles input signal (or error) from the RedRat3.
    /// </summary>
    public void SignalDataIn(object sender, EventArgs e) {
      if (e is SignalEventArgs) {
        sigInEvent = (SignalEventArgs)e;

        if (this.InvokeRequired) {
          CloseCallback cb = new CloseCallback(this.Close);
          this.Invoke(cb, null);
        }
        else {
          this.Close();
        }
      }
    }

    /// <summary>
    /// Cancel button on this dialog pressed.
    /// </summary>
    private void cancelButton_Click(object sender, System.EventArgs e) {
      //cancelled = true;
      // Right, when the user requests that the signal input is cancelled,
      // the RedRat3 has to be informed....
      rr3.CancelSignalInput();
      // ... but this program is still waiting for input, so the RR3 sends
      // back a message to indicate that signal input has been terminated.
      // Now have a look at SignalDataIn method.
    }

    public SignalEventArgs SignalInEvent {
      get { return sigInEvent; }
    }
  }
}
