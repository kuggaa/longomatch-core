// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
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
        
        private Gtk.ComboBox combobox1;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Dialog.VideoEditionProperties
            this.Name = "LongoMatch.Gui.Dialog.VideoEditionProperties";
            this.Title = Mono.Unix.Catalog.GetString("Video Properties");
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
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Video Quality:");
            this.hbox2.Add(this.label1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox2[this.label1]));
            w7.Position = 0;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.combobox1 = Gtk.ComboBox.NewText();
            this.combobox1.AppendText(Mono.Unix.Catalog.GetString("Low"));
            this.combobox1.AppendText(Mono.Unix.Catalog.GetString("Normal"));
            this.combobox1.AppendText(Mono.Unix.Catalog.GetString("Good"));
            this.combobox1.AppendText(Mono.Unix.Catalog.GetString("Extra"));
            this.combobox1.Name = "combobox1";
            this.combobox1.Active = 2;
            this.hbox2.Add(this.combobox1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox2[this.combobox1]));
            w8.Position = 1;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Internal child LongoMatch.Gui.Dialog.VideoEditionProperties.ActionArea
            Gtk.HButtonBox w11 = this.ActionArea;
            w11.Name = "dialog1_ActionArea";
            w11.Spacing = 6;
            w11.BorderWidth = ((uint)(5));
            w11.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w11[this.buttonCancel]));
            w12.Expand = false;
            w12.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(w11[this.buttonOk]));
            w13.Position = 1;
            w13.Expand = false;
            w13.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 377;
            this.DefaultHeight = 144;
            this.Show();
            this.openbutton.Clicked += new System.EventHandler(this.OnOpenbuttonClicked);
            this.buttonOk.Clicked += new System.EventHandler(this.OnButtonOkClicked);
        }
    }
}
