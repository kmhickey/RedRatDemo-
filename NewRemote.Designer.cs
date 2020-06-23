using RedRat.IR;
using RedRat.USB;
using RedRat.Util;
using RedRat.RedRat3;
using RedRat.RedRat3.USB;

namespace RedRat.TestRemote
{
    partial class NewRemote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                // Clear up RR3s and their resources.
                RedRat3USBImpl.DisposeOfAll();

                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            RedRat.TestRemote.ButtonInfo buttonInfo41 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo42 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo43 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo44 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo45 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo46 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo24 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo25 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo26 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo27 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo28 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo29 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo30 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo31 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo32 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo33 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo34 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo35 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo36 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo37 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo38 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo39 = new RedRat.TestRemote.ButtonInfo();
            RedRat.TestRemote.ButtonInfo buttonInfo40 = new RedRat.TestRemote.ButtonInfo();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.openMenuItem = new System.Windows.Forms.MenuItem();
            this.saveMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.rr3InfoMenuItem = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.irButton5 = new RedRat.TestRemote.IRButton();
            this.irButton10 = new RedRat.TestRemote.IRButton();
            this.irButton13 = new RedRat.TestRemote.IRButton();
            this.irButton15 = new RedRat.TestRemote.IRButton();
            this.irButton17 = new RedRat.TestRemote.IRButton();
            this.irButton4 = new RedRat.TestRemote.IRButton();
            this.irButton27 = new RedRat.TestRemote.IRButton();
            this.irButton28 = new RedRat.TestRemote.IRButton();
            this.irButton29 = new RedRat.TestRemote.IRButton();
            this.irButton30 = new RedRat.TestRemote.IRButton();
            this.irButton23 = new RedRat.TestRemote.IRButton();
            this.irButton24 = new RedRat.TestRemote.IRButton();
            this.irButton25 = new RedRat.TestRemote.IRButton();
            this.irButton26 = new RedRat.TestRemote.IRButton();
            this.irButton1 = new RedRat.TestRemote.IRButton();
            this.irButton2 = new RedRat.TestRemote.IRButton();
            this.irButton3 = new RedRat.TestRemote.IRButton();
            this.irButton22 = new RedRat.TestRemote.IRButton();
            this.nbutton1 = new RedRat.TestRemote.IRButton();
            this.nbutton8 = new RedRat.TestRemote.IRButton();
            this.nbutton9 = new RedRat.TestRemote.IRButton();
            this.nbutton3 = new RedRat.TestRemote.IRButton();
            this.nbutton2 = new RedRat.TestRemote.IRButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.helpMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.menuItem1,
            this.exitMenuItem});
            this.fileMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Index = 0;
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Index = 1;
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 3;
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Index = 1;
            this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.aboutMenuItem,
            this.rr3InfoMenuItem});
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 0;
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // rr3InfoMenuItem
            // 
            this.rr3InfoMenuItem.Index = 1;
            this.rr3InfoMenuItem.Text = "RedRat3 Info";
            this.rr3InfoMenuItem.Click += new System.EventHandler(this.rr3InfoMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.irButton27);
            this.panel1.Controls.Add(this.irButton28);
            this.panel1.Controls.Add(this.irButton29);
            this.panel1.Controls.Add(this.irButton30);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.irButton23);
            this.panel1.Controls.Add(this.irButton24);
            this.panel1.Controls.Add(this.irButton25);
            this.panel1.Controls.Add(this.irButton26);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.irButton1);
            this.panel1.Controls.Add(this.irButton2);
            this.panel1.Controls.Add(this.irButton3);
            this.panel1.Controls.Add(this.irButton22);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nbutton1);
            this.panel1.Controls.Add(this.nbutton8);
            this.panel1.Controls.Add(this.nbutton9);
            this.panel1.Controls.Add(this.nbutton3);
            this.panel1.Controls.Add(this.nbutton2);
            this.panel1.Location = new System.Drawing.Point(50, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 649);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.irButton5);
            this.panel2.Controls.Add(this.irButton10);
            this.panel2.Controls.Add(this.irButton13);
            this.panel2.Controls.Add(this.irButton15);
            this.panel2.Controls.Add(this.irButton17);
            this.panel2.Controls.Add(this.irButton4);
            this.panel2.Location = new System.Drawing.Point(70, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 284);
            this.panel2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "TV Power";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 58;
            this.label2.Text = "HDMI 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 59;
            this.label3.Text = "HDMI 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 60;
            this.label4.Text = "HDMI 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 61;
            this.label5.Text = "HDMI 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 31);
            this.label6.TabIndex = 58;
            this.label6.Text = "Denon Power";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 31);
            this.label7.TabIndex = 59;
            this.label7.Text = "Cbl/Sat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 31);
            this.label8.TabIndex = 60;
            this.label8.Text = "DVD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(382, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 31);
            this.label9.TabIndex = 61;
            this.label9.Text = "Media Player";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(554, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 31);
            this.label10.TabIndex = 62;
            this.label10.Text = "TV Audio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(554, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 31);
            this.label11.TabIndex = 70;
            this.label11.Text = "Bluetooth";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(382, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 31);
            this.label12.TabIndex = 69;
            this.label12.Text = "Tuner";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(213, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 31);
            this.label13.TabIndex = 68;
            this.label13.Text = "AUX1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(54, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 31);
            this.label14.TabIndex = 67;
            this.label14.Text = "Blu-ray";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(554, 374);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 31);
            this.label15.TabIndex = 78;
            this.label15.Text = "Ipod/USB";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(382, 374);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 31);
            this.label16.TabIndex = 77;
            this.label16.Text = "Phono";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(213, 374);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 31);
            this.label17.TabIndex = 76;
            this.label17.Text = "AUX2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 374);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 31);
            this.label18.TabIndex = 75;
            this.label18.Text = "Gane";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(554, 493);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(185, 31);
            this.label19.TabIndex = 86;
            this.label19.Text = "Internet Radio";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(382, 493);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(174, 31);
            this.label20.TabIndex = 85;
            this.label20.Text = "Media Server";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(213, 493);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(170, 31);
            this.label21.TabIndex = 84;
            this.label21.Text = "Online Music";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(54, 493);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 31);
            this.label22.TabIndex = 83;
            this.label22.Text = "CD";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(544, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(159, 31);
            this.label23.TabIndex = 62;
            this.label23.Text = "Sound Mute";
            // 
            // irButton5
            // 
            buttonInfo41.BtnName = null;
            buttonInfo41.IRPacket = null;
            buttonInfo41.Text = null;
            this.irButton5.Info = buttonInfo41;
            this.irButton5.Location = new System.Drawing.Point(43, 76);
            this.irButton5.Name = "irButton5";
            this.irButton5.Size = new System.Drawing.Size(130, 39);
            this.irButton5.TabIndex = 32;
            // 
            // irButton10
            // 
            buttonInfo42.BtnName = null;
            buttonInfo42.IRPacket = null;
            buttonInfo42.Text = null;
            this.irButton10.Info = buttonInfo42;
            this.irButton10.Location = new System.Drawing.Point(381, 183);
            this.irButton10.Name = "irButton10";
            this.irButton10.Size = new System.Drawing.Size(130, 39);
            this.irButton10.TabIndex = 25;
            // 
            // irButton13
            // 
            buttonInfo43.BtnName = null;
            buttonInfo43.IRPacket = null;
            buttonInfo43.Text = null;
            this.irButton13.Info = buttonInfo43;
            this.irButton13.Location = new System.Drawing.Point(212, 183);
            this.irButton13.Name = "irButton13";
            this.irButton13.Size = new System.Drawing.Size(130, 39);
            this.irButton13.TabIndex = 38;
            // 
            // irButton15
            // 
            this.irButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            buttonInfo44.BtnName = null;
            buttonInfo44.IRPacket = null;
            buttonInfo44.Text = null;
            this.irButton15.Info = buttonInfo44;
            this.irButton15.Location = new System.Drawing.Point(550, 183);
            this.irButton15.Name = "irButton15";
            this.irButton15.Size = new System.Drawing.Size(130, 39);
            this.irButton15.TabIndex = 30;
            this.irButton15.UseVisualStyleBackColor = false;
            // 
            // irButton17
            // 
            buttonInfo45.BtnName = null;
            buttonInfo45.IRPacket = null;
            buttonInfo45.Text = null;
            this.irButton17.Info = buttonInfo45;
            this.irButton17.Location = new System.Drawing.Point(43, 183);
            this.irButton17.Name = "irButton17";
            this.irButton17.Size = new System.Drawing.Size(130, 39);
            this.irButton17.TabIndex = 31;
            // 
            // irButton4
            // 
            buttonInfo46.BtnName = null;
            buttonInfo46.IRPacket = null;
            buttonInfo46.Text = null;
            this.irButton4.Info = buttonInfo46;
            this.irButton4.Location = new System.Drawing.Point(550, 76);
            this.irButton4.Name = "irButton4";
            this.irButton4.Size = new System.Drawing.Size(130, 39);
            this.irButton4.TabIndex = 42;
            // 
            // irButton27
            // 
            buttonInfo24.BtnName = null;
            buttonInfo24.IRPacket = null;
            buttonInfo24.Text = null;
            this.irButton27.Info = buttonInfo24;
            this.irButton27.Location = new System.Drawing.Point(388, 537);
            this.irButton27.Name = "irButton27";
            this.irButton27.Size = new System.Drawing.Size(130, 39);
            this.irButton27.TabIndex = 79;
            // 
            // irButton28
            // 
            buttonInfo25.BtnName = null;
            buttonInfo25.IRPacket = null;
            buttonInfo25.Text = null;
            this.irButton28.Info = buttonInfo25;
            this.irButton28.Location = new System.Drawing.Point(219, 537);
            this.irButton28.Name = "irButton28";
            this.irButton28.Size = new System.Drawing.Size(130, 39);
            this.irButton28.TabIndex = 82;
            // 
            // irButton29
            // 
            buttonInfo26.BtnName = null;
            buttonInfo26.IRPacket = null;
            buttonInfo26.Text = null;
            this.irButton29.Info = buttonInfo26;
            this.irButton29.Location = new System.Drawing.Point(557, 537);
            this.irButton29.Name = "irButton29";
            this.irButton29.Size = new System.Drawing.Size(130, 39);
            this.irButton29.TabIndex = 80;
            // 
            // irButton30
            // 
            buttonInfo27.BtnName = null;
            buttonInfo27.IRPacket = null;
            buttonInfo27.Text = null;
            this.irButton30.Info = buttonInfo27;
            this.irButton30.Location = new System.Drawing.Point(50, 537);
            this.irButton30.Name = "irButton30";
            this.irButton30.Size = new System.Drawing.Size(130, 39);
            this.irButton30.TabIndex = 81;
            // 
            // irButton23
            // 
            buttonInfo28.BtnName = null;
            buttonInfo28.IRPacket = null;
            buttonInfo28.Text = null;
            this.irButton23.Info = buttonInfo28;
            this.irButton23.Location = new System.Drawing.Point(388, 418);
            this.irButton23.Name = "irButton23";
            this.irButton23.Size = new System.Drawing.Size(130, 39);
            this.irButton23.TabIndex = 71;
            // 
            // irButton24
            // 
            buttonInfo29.BtnName = null;
            buttonInfo29.IRPacket = null;
            buttonInfo29.Text = null;
            this.irButton24.Info = buttonInfo29;
            this.irButton24.Location = new System.Drawing.Point(219, 418);
            this.irButton24.Name = "irButton24";
            this.irButton24.Size = new System.Drawing.Size(130, 39);
            this.irButton24.TabIndex = 74;
            // 
            // irButton25
            // 
            buttonInfo30.BtnName = null;
            buttonInfo30.IRPacket = null;
            buttonInfo30.Text = null;
            this.irButton25.Info = buttonInfo30;
            this.irButton25.Location = new System.Drawing.Point(557, 418);
            this.irButton25.Name = "irButton25";
            this.irButton25.Size = new System.Drawing.Size(130, 39);
            this.irButton25.TabIndex = 72;
            // 
            // irButton26
            // 
            buttonInfo31.BtnName = null;
            buttonInfo31.IRPacket = null;
            buttonInfo31.Text = null;
            this.irButton26.Info = buttonInfo31;
            this.irButton26.Location = new System.Drawing.Point(50, 418);
            this.irButton26.Name = "irButton26";
            this.irButton26.Size = new System.Drawing.Size(130, 39);
            this.irButton26.TabIndex = 73;
            // 
            // irButton1
            // 
            buttonInfo32.BtnName = null;
            buttonInfo32.IRPacket = null;
            buttonInfo32.Text = null;
            this.irButton1.Info = buttonInfo32;
            this.irButton1.Location = new System.Drawing.Point(388, 306);
            this.irButton1.Name = "irButton1";
            this.irButton1.Size = new System.Drawing.Size(130, 39);
            this.irButton1.TabIndex = 63;
            // 
            // irButton2
            // 
            buttonInfo33.BtnName = null;
            buttonInfo33.IRPacket = null;
            buttonInfo33.Text = null;
            this.irButton2.Info = buttonInfo33;
            this.irButton2.Location = new System.Drawing.Point(219, 306);
            this.irButton2.Name = "irButton2";
            this.irButton2.Size = new System.Drawing.Size(130, 39);
            this.irButton2.TabIndex = 66;
            // 
            // irButton3
            // 
            buttonInfo34.BtnName = null;
            buttonInfo34.IRPacket = null;
            buttonInfo34.Text = null;
            this.irButton3.Info = buttonInfo34;
            this.irButton3.Location = new System.Drawing.Point(557, 306);
            this.irButton3.Name = "irButton3";
            this.irButton3.Size = new System.Drawing.Size(130, 39);
            this.irButton3.TabIndex = 64;
            // 
            // irButton22
            // 
            buttonInfo35.BtnName = null;
            buttonInfo35.IRPacket = null;
            buttonInfo35.Text = null;
            this.irButton22.Info = buttonInfo35;
            this.irButton22.Location = new System.Drawing.Point(50, 306);
            this.irButton22.Name = "irButton22";
            this.irButton22.Size = new System.Drawing.Size(130, 39);
            this.irButton22.TabIndex = 65;
            // 
            // nbutton1
            // 
            buttonInfo36.BtnName = null;
            buttonInfo36.IRPacket = null;
            buttonInfo36.Text = null;
            this.nbutton1.Info = buttonInfo36;
            this.nbutton1.Location = new System.Drawing.Point(50, 106);
            this.nbutton1.Name = "nbutton1";
            this.nbutton1.Size = new System.Drawing.Size(130, 39);
            this.nbutton1.TabIndex = 32;
            // 
            // nbutton8
            // 
            buttonInfo37.BtnName = null;
            buttonInfo37.IRPacket = null;
            buttonInfo37.Text = null;
            this.nbutton8.Info = buttonInfo37;
            this.nbutton8.Location = new System.Drawing.Point(388, 202);
            this.nbutton8.Name = "nbutton8";
            this.nbutton8.Size = new System.Drawing.Size(130, 39);
            this.nbutton8.TabIndex = 25;
            // 
            // nbutton9
            // 
            buttonInfo38.BtnName = null;
            buttonInfo38.IRPacket = null;
            buttonInfo38.Text = null;
            this.nbutton9.Info = buttonInfo38;
            this.nbutton9.Location = new System.Drawing.Point(219, 202);
            this.nbutton9.Name = "nbutton9";
            this.nbutton9.Size = new System.Drawing.Size(130, 39);
            this.nbutton9.TabIndex = 38;
            this.nbutton9.Click += new System.EventHandler(this.button_Click);
            this.nbutton9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            // 
            // nbutton3
            // 
            buttonInfo39.BtnName = null;
            buttonInfo39.IRPacket = null;
            buttonInfo39.Text = null;
            this.nbutton3.Info = buttonInfo39;
            this.nbutton3.Location = new System.Drawing.Point(557, 202);
            this.nbutton3.Name = "nbutton3";
            this.nbutton3.Size = new System.Drawing.Size(130, 39);
            this.nbutton3.TabIndex = 30;
            // 
            // nbutton2
            // 
            buttonInfo40.BtnName = null;
            buttonInfo40.IRPacket = null;
            buttonInfo40.Text = null;
            this.nbutton2.Info = buttonInfo40;
            this.nbutton2.Location = new System.Drawing.Point(50, 202);
            this.nbutton2.Name = "nbutton2";
            this.nbutton2.Size = new System.Drawing.Size(130, 39);
            this.nbutton2.TabIndex = 31;
            // 
            // NewRemote
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
            this.ClientSize = new System.Drawing.Size(883, 1051);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Menu = this.mainMenu;
            this.Name = "NewRemote";
            this.Text = "Remote Control";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.TestRemote_Closing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem helpMenuItem;
        private System.Windows.Forms.MenuItem aboutMenuItem;
        private System.Windows.Forms.MenuItem openMenuItem;
        private System.Windows.Forms.MenuItem saveMenuItem;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem rr3InfoMenuItem;
        private IRButton nbutton1;
        private IRButton nbutton2;
        private IRButton nbutton3;
        private IRButton nbutton8;
        private IRButton nbutton9;
        private IRButton irButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private IRButton irButton27;
        private IRButton irButton28;
        private IRButton irButton29;
        private IRButton irButton30;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private IRButton irButton23;
        private IRButton irButton24;
        private IRButton irButton25;
        private IRButton irButton26;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private IRButton irButton1;
        private IRButton irButton2;
        private IRButton irButton3;
        private IRButton irButton22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private IRButton irButton5;
        private IRButton irButton10;
        private IRButton irButton13;
        private IRButton irButton15;
        private IRButton irButton17;
        //       private IContainer components;
    }
}
