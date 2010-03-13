// CapturerBin.cs
//
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
//

using System;
using Gtk;
using Gdk;
using GLib;
using LongoMatch.Video;
using LongoMatch.Video.Capturer;
using LongoMatch.Video.Utils;
using Mono.Unix;

namespace LongoMatch.Gui
{
	
	
	[System.ComponentModel.Category("CesarPlayer")]
	[System.ComponentModel.ToolboxItem(true)]
	public partial class CapturerBin : Gtk.Bin
	{
		public event EventHandler CaptureFinished;
		
		private Pixbuf logopix;
		
		ICapturer capturer;
		
		public CapturerBin()
		{
			this.Build();
			Type = CapturerType.FAKE;	
		}		
		
		public CapturerType Type {
			set{
				if (capturer != null){
					capturer.Stop();
					capturerhbox.Remove(capturer as Gtk.Widget);
				}
				MultimediaFactory factory = new MultimediaFactory();
				capturer = factory.getCapturer(value);	
				capturer.EllapsedTime += OnTick;
				capturerhbox.Add((Widget)capturer);
				((Widget)capturer).Show();
			}
		}
		
		public string Logo{
			set{
				try{
					this.logopix = new Pixbuf(value);
					Console.WriteLine("Setting logo");
				}catch{
					// Ignore errors if the file doesn't exists
				}
			}
		}
		 
		public string OutputFile {
			set{
				capturer.OutputFile= value;
			}			
		}		
				
		public uint VideoBitrate {
			set{capturer.VideoBitrate=value;}			
		}
		
		public uint AudioBitrate {
			set{capturer.AudioBitrate=value;}
		}
		
		public int CurrentTime {
			get{
				return capturer.CurrentTime;
			}
		}
		public void TogglePause(){
			capturer.TogglePause();
		}
		
		public void Start(){
			capturer.Start();
		}
		
		public void Stop(){
			capturer.Stop();
		}
		
		public void SetVideoEncoder(LongoMatch.Video.Capturer.GccVideoEncoderType type){
			capturer.SetVideoEncoder(type);
		}
		
		public void SetAudioEncoder(LongoMatch.Video.Capturer.GccAudioEncoderType type){
			capturer.SetAudioEncoder(type);
		}
		
		public void SetVideoMuxer(LongoMatch.Video.Capturer.GccVideoMuxerType type){
			capturer.SetVideoMuxer(type);
		}

		protected virtual void OnRecbuttonClicked (object sender, System.EventArgs e)
		{
			Start();
			recbutton.Visible = false;
			pausebutton.Visible = true;
			stopbutton.Visible = true;
		}

		protected virtual void OnPausebuttonClicked (object sender, System.EventArgs e)
		{
			TogglePause();
			recbutton.Visible = true;
			pausebutton.Visible = false;			
		}

		protected virtual void OnStopbuttonClicked (object sender, System.EventArgs e)
		{
			MessageDialog md = new MessageDialog((Gtk.Window)this.Toplevel, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo,
			                                     Catalog.GetString("You are going to stop and finish the current capture."+"\n"+
			                                                       "Do you want to proceed?"));
			if (md.Run() == (int)ResponseType.Yes){
				Stop();
				recbutton.Visible = true;
				pausebutton.Visible = false;
				stopbutton.Visible = false;
				if (CaptureFinished != null)
					CaptureFinished(this, new EventArgs());
			}
			md.Destroy();
		}				
		
		protected virtual void OnTick (int ellapsedTime){
			timelabel.Text = "Time: " + TimeString.MSecondsToSecondsString(CurrentTime);
		}
		
		protected virtual void OnLogodrawingareaExposeEvent (object o, Gtk.ExposeEventArgs args)
		{	
			Gdk.Window win;
			Rectangle area;
			Pixbuf frame;
			Pixbuf drawing;
			int width, height, allocWidth, allocHeight, logoX, logoY;
			float ratio;
			
			if (logopix == null)
				return;

			win = logodrawingarea.GdkWindow;
			width = logopix.Width;
			height = logopix.Height;
			allocWidth = logodrawingarea.Allocation.Width;
			allocHeight = logodrawingarea.Allocation.Height;
			area = args.Event.Area;
			
			/* Checking if allocated space is smaller than our logo */
			if ((float) allocWidth / width > (float) allocHeight / height) {
				ratio = (float) allocHeight / height;
			} else {
				ratio = (float) allocWidth / width;
			}
			width = (int) (width * ratio);
			height = (int) (height * ratio);
			
			logoX = (allocWidth / 2) - (width / 2);
			logoY = (allocHeight / 2) - (height / 2);

			/* Drawing our frame */
			frame = logopix.ScaleSimple(width, height, InterpType.Bilinear);
			win.DrawPixbuf (this.Style.BlackGC, frame, 0, 0,
			                logoX, logoY, width, height,
			                RgbDither.Normal, 0, 0);
			frame.Dispose();
			return;
		}
	}
}
