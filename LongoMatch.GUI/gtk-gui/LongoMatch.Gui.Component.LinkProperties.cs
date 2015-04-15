
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class LinkProperties
	{
		private global::Gtk.VBox totalbox;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.CheckButton checkbuttonkeepcommontags;
		
		private global::Gtk.CheckButton checkbuttonkeepplayertags;
		
		private global::Gtk.ComboBox comboboxaction;
		
		private global::Gtk.ComboBox comboboxteamaction;
		
		private global::Gtk.Entry entryfrom;
		
		private global::Gtk.Entry entryfromtags;
		
		private global::Gtk.Entry entryto;
		
		private global::Gtk.Entry entrytotags;
		
		private global::Gtk.Label labelaction;
		
		private global::Gtk.Label labelfrom;
		
		private global::Gtk.Label labelkeepcommontags;
		
		private global::Gtk.Label labelkeepplayertags;
		
		private global::Gtk.Label labelteamaction;
		
		private global::Gtk.Label labelto;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.LinkProperties
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.LinkProperties";
			// Container child LongoMatch.Gui.Component.LinkProperties.Gtk.Container+ContainerChild
			this.totalbox = new global::Gtk.VBox ();
			this.totalbox.Name = "totalbox";
			this.totalbox.Spacing = 6;
			// Container child totalbox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(8)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.checkbuttonkeepcommontags = new global::Gtk.CheckButton ();
			this.checkbuttonkeepcommontags.Name = "checkbuttonkeepcommontags";
			this.checkbuttonkeepcommontags.Label = "";
			this.checkbuttonkeepcommontags.DrawIndicator = true;
			this.checkbuttonkeepcommontags.UseUnderline = true;
			this.table1.Add (this.checkbuttonkeepcommontags);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbuttonkeepcommontags]));
			w1.TopAttach = ((uint)(7));
			w1.BottomAttach = ((uint)(8));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbuttonkeepplayertags = new global::Gtk.CheckButton ();
			this.checkbuttonkeepplayertags.Name = "checkbuttonkeepplayertags";
			this.checkbuttonkeepplayertags.Label = "";
			this.checkbuttonkeepplayertags.DrawIndicator = true;
			this.checkbuttonkeepplayertags.UseUnderline = true;
			this.checkbuttonkeepplayertags.FocusOnClick = false;
			this.table1.Add (this.checkbuttonkeepplayertags);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbuttonkeepplayertags]));
			w2.TopAttach = ((uint)(6));
			w2.BottomAttach = ((uint)(7));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxaction = global::Gtk.ComboBox.NewText ();
			this.comboboxaction.AppendText (global::Mono.Unix.Catalog.GetString ("Toggle"));
			this.comboboxaction.AppendText (global::Mono.Unix.Catalog.GetString ("Replicate"));
			this.comboboxaction.Name = "comboboxaction";
			this.comboboxaction.FocusOnClick = false;
			this.table1.Add (this.comboboxaction);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboboxaction]));
			w3.TopAttach = ((uint)(4));
			w3.BottomAttach = ((uint)(5));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxteamaction = global::Gtk.ComboBox.NewText ();
			this.comboboxteamaction.AppendText (global::Mono.Unix.Catalog.GetString ("Clear"));
			this.comboboxteamaction.AppendText (global::Mono.Unix.Catalog.GetString ("Keep"));
			this.comboboxteamaction.AppendText (global::Mono.Unix.Catalog.GetString ("Invert"));
			this.comboboxteamaction.Name = "comboboxteamaction";
			this.table1.Add (this.comboboxteamaction);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboboxteamaction]));
			w4.TopAttach = ((uint)(5));
			w4.BottomAttach = ((uint)(6));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryfrom = new global::Gtk.Entry ();
			this.entryfrom.Name = "entryfrom";
			this.entryfrom.IsEditable = false;
			this.entryfrom.InvisibleChar = '●';
			this.table1.Add (this.entryfrom);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryfrom]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryfromtags = new global::Gtk.Entry ();
			this.entryfromtags.Name = "entryfromtags";
			this.entryfromtags.IsEditable = false;
			this.entryfromtags.InvisibleChar = '●';
			this.table1.Add (this.entryfromtags);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryfromtags]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryto = new global::Gtk.Entry ();
			this.entryto.Name = "entryto";
			this.entryto.IsEditable = false;
			this.entryto.InvisibleChar = '●';
			this.table1.Add (this.entryto);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryto]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entrytotags = new global::Gtk.Entry ();
			this.entrytotags.Name = "entrytotags";
			this.entrytotags.IsEditable = false;
			this.entrytotags.InvisibleChar = '●';
			this.table1.Add (this.entrytotags);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.entrytotags]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelaction = new global::Gtk.Label ();
			this.labelaction.Name = "labelaction";
			this.labelaction.Xalign = 1F;
			this.labelaction.LabelProp = global::Mono.Unix.Catalog.GetString ("Action");
			this.table1.Add (this.labelaction);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelaction]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelfrom = new global::Gtk.Label ();
			this.labelfrom.Name = "labelfrom";
			this.labelfrom.Xalign = 1F;
			this.labelfrom.LabelProp = global::Mono.Unix.Catalog.GetString ("From");
			this.table1.Add (this.labelfrom);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelfrom]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelkeepcommontags = new global::Gtk.Label ();
			this.labelkeepcommontags.Name = "labelkeepcommontags";
			this.labelkeepcommontags.Xalign = 1F;
			this.labelkeepcommontags.LabelProp = global::Mono.Unix.Catalog.GetString ("Keep common tags");
			this.table1.Add (this.labelkeepcommontags);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelkeepcommontags]));
			w11.TopAttach = ((uint)(7));
			w11.BottomAttach = ((uint)(8));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelkeepplayertags = new global::Gtk.Label ();
			this.labelkeepplayertags.Name = "labelkeepplayertags";
			this.labelkeepplayertags.Xalign = 1F;
			this.labelkeepplayertags.LabelProp = global::Mono.Unix.Catalog.GetString ("Keep player tags");
			this.table1.Add (this.labelkeepplayertags);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelkeepplayertags]));
			w12.TopAttach = ((uint)(6));
			w12.BottomAttach = ((uint)(7));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelteamaction = new global::Gtk.Label ();
			this.labelteamaction.Name = "labelteamaction";
			this.labelteamaction.Xalign = 1F;
			this.labelteamaction.LabelProp = global::Mono.Unix.Catalog.GetString ("Team action");
			this.table1.Add (this.labelteamaction);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelteamaction]));
			w13.TopAttach = ((uint)(5));
			w13.BottomAttach = ((uint)(6));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelto = new global::Gtk.Label ();
			this.labelto.Name = "labelto";
			this.labelto.Xalign = 1F;
			this.labelto.LabelProp = global::Mono.Unix.Catalog.GetString ("To");
			this.table1.Add (this.labelto);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelto]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.totalbox.Add (this.table1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.totalbox [this.table1]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			this.Add (this.totalbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}