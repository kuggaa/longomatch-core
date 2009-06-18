// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Dialog {
    
    
    public partial class VideoEditionProperties {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label filenamelabel;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Entry fileentry;
        
        private Gtk.Button openbutton;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label label1;
        
        private Gtk.ComboBox qualitycombobox;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label label2;
        
        private Gtk.ComboBox sizecombobox;
        
        private Gtk.HBox hbox5;
        
        private Gtk.Label label3;
        
        private Gtk.ComboBox formatcombobox;
        
        private Gtk.HBox hbox6;
        
        private Gtk.CheckButton descriptioncheckbutton;
        
        private Gtk.CheckButton audiocheckbutton;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Dialog.VideoEditionProperties
            this.Name = "LongoMatch.Gui.Dialog.VideoEditionProperties";
            this.Title = Mono.Unix.Catalog.GetString("Video Properties");
            this.Icon = Gdk.Pixbuf.LoadFromResource("longomatch_logo.png");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            this.HasSeparator = false;
            // Internal child LongoMatch.Gui.Dialog.VideoEditionProperties.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.filenamelabel = new Gtk.Label();
            this.filenamelabel.Name = "filenamelabel";
            this.filenamelabel.LabelProp = Mono.Unix.Catalog.GetString("File name: ");
            this.hbox1.Add(this.filenamelabel);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.filenamelabel]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.fileentry = new Gtk.Entry();
            this.fileentry.CanFocus = true;
            this.fileentry.Name = "fileentry";
            this.fileentry.IsEditable = false;
            this.fileentry.InvisibleChar = '●';
            this.hbox3.Add(this.fileentry);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox3[this.fileentry]));
            w3.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.openbutton = new Gtk.Button();
            this.openbutton.CanFocus = true;
            this.openbutton.Name = "openbutton";
            this.openbutton.UseStock = true;
            this.openbutton.UseUnderline = true;
            this.openbutton.Label = "gtk-save-as";
            this.hbox3.Add(this.openbutton);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox3[this.openbutton]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            this.hbox1.Add(this.hbox3);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.hbox3]));
            w5.Position = 1;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Homogeneous = true;
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Video Quality:");
            this.hbox2.Add(this.label1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox2[this.label1]));
            w7.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.qualitycombobox = Gtk.ComboBox.NewText();
            this.qualitycombobox.AppendText(Mono.Unix.Catalog.GetString("Low"));
            this.qualitycombobox.AppendText(Mono.Unix.Catalog.GetString("Normal"));
            this.qualitycombobox.AppendText(Mono.Unix.Catalog.GetString("Good"));
            this.qualitycombobox.AppendText(Mono.Unix.Catalog.GetString("Extra"));
            this.qualitycombobox.Name = "qualitycombobox";
            this.qualitycombobox.Active = 1;
            this.hbox2.Add(this.qualitycombobox);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox2[this.qualitycombobox]));
            w8.Position = 1;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Homogeneous = true;
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Size: ");
            this.hbox4.Add(this.label2);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox4[this.label2]));
            w10.Position = 0;
            // Container child hbox4.Gtk.Box+BoxChild
            this.sizecombobox = Gtk.ComboBox.NewText();
            this.sizecombobox.AppendText(Mono.Unix.Catalog.GetString("TV (4:3 - 720x540)"));
            this.sizecombobox.AppendText(Mono.Unix.Catalog.GetString("HD 720p (16:9 - 1280x720)"));
            this.sizecombobox.AppendText(Mono.Unix.Catalog.GetString("Full HD 1080p (16:9 - 1920x1080)"));
            this.sizecombobox.Name = "sizecombobox";
            this.sizecombobox.Active = 0;
            this.hbox4.Add(this.sizecombobox);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox4[this.sizecombobox]));
            w11.Position = 1;
            this.vbox2.Add(this.hbox4);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Homogeneous = true;
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("OuputFormat:");
            this.hbox5.Add(this.label3);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox5[this.label3]));
            w13.Position = 0;
            // Container child hbox5.Gtk.Box+BoxChild
            this.formatcombobox = Gtk.ComboBox.NewText();
            this.formatcombobox.AppendText(Mono.Unix.Catalog.GetString("Matroska (H.264+AAC)"));
            this.formatcombobox.AppendText(Mono.Unix.Catalog.GetString("Avi (Xvid+MP3)"));
            this.formatcombobox.AppendText(Mono.Unix.Catalog.GetString("DVD (MPEG-2)"));
            this.formatcombobox.Name = "formatcombobox";
            this.formatcombobox.Active = 0;
            this.hbox5.Add(this.formatcombobox);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox5[this.formatcombobox]));
            w14.Position = 1;
            this.vbox2.Add(this.hbox5);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
            w15.Position = 3;
            w15.Expand = false;
            w15.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox6 = new Gtk.HBox();
            this.hbox6.Name = "hbox6";
            this.hbox6.Spacing = 6;
            // Container child hbox6.Gtk.Box+BoxChild
            this.descriptioncheckbutton = new Gtk.CheckButton();
            this.descriptioncheckbutton.CanFocus = true;
            this.descriptioncheckbutton.Name = "descriptioncheckbutton";
            this.descriptioncheckbutton.Label = Mono.Unix.Catalog.GetString("Enable Title Overlay");
            this.descriptioncheckbutton.Active = true;
            this.descriptioncheckbutton.DrawIndicator = true;
            this.descriptioncheckbutton.UseUnderline = true;
            this.hbox6.Add(this.descriptioncheckbutton);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.hbox6[this.descriptioncheckbutton]));
            w16.Position = 0;
            // Container child hbox6.Gtk.Box+BoxChild
            this.audiocheckbutton = new Gtk.CheckButton();
            this.audiocheckbutton.CanFocus = true;
            this.audiocheckbutton.Name = "audiocheckbutton";
            this.audiocheckbutton.Label = Mono.Unix.Catalog.GetString("Enable Sound");
            this.audiocheckbutton.Active = true;
            this.audiocheckbutton.DrawIndicator = true;
            this.audiocheckbutton.UseUnderline = true;
            this.hbox6.Add(this.audiocheckbutton);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.hbox6[this.audiocheckbutton]));
            w17.Position = 1;
            this.vbox2.Add(this.hbox6);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox6]));
            w18.Position = 4;
            w18.Expand = false;
            w18.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w19.Position = 0;
            w19.Expand = false;
            w19.Fill = false;
            // Internal child LongoMatch.Gui.Dialog.VideoEditionProperties.ActionArea
            Gtk.HButtonBox w20 = this.ActionArea;
            w20.Name = "dialog1_ActionArea";
            w20.Spacing = 6;
            w20.BorderWidth = ((uint)(5));
            w20.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w21 = ((Gtk.ButtonBox.ButtonBoxChild)(w20[this.buttonCancel]));
            w21.Expand = false;
            w21.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w22 = ((Gtk.ButtonBox.ButtonBoxChild)(w20[this.buttonOk]));
            w22.Position = 1;
            w22.Expand = false;
            w22.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 514;
            this.DefaultHeight = 205;
            this.Show();
            this.openbutton.Clicked += new System.EventHandler(this.OnOpenbuttonClicked);
            this.buttonOk.Clicked += new System.EventHandler(this.OnButtonOkClicked);
        }
    }
}
