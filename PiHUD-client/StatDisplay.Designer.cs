
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v2.0.0.0
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// -----------------------------------------------------------------------------
namespace PiHud.Client {
    using System;
    using Terminal.Gui;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;
    
    
    public partial class StatDisplay : Terminal.Gui.Window {
        
        private Terminal.Gui.Label label;
        
        private Terminal.Gui.ProgressBar cpuBar;
        
        private Terminal.Gui.Label label2;
        
        private Terminal.Gui.ProgressBar memBar;
        
        private Terminal.Gui.Label label4;
        
        private Terminal.Gui.ProgressBar gpuBar;
        
        private Terminal.Gui.Label label3;
        
        private Terminal.Gui.ProgressBar rootBar;
        
        private Terminal.Gui.Line line2;
        
        private Terminal.Gui.TextView staticTextView;
        
        private Terminal.Gui.Line line;
        
        private Terminal.Gui.TextView textView;
        
        private Terminal.Gui.Line line3;
        
        private Terminal.Gui.Label label5;
        
        private void InitializeComponent() {
            this.label5 = new Terminal.Gui.Label();
            this.line3 = new Terminal.Gui.Line();
            this.textView = new Terminal.Gui.TextView();
            this.line = new Terminal.Gui.Line();
            this.staticTextView = new Terminal.Gui.TextView();
            this.line2 = new Terminal.Gui.Line();
            this.rootBar = new Terminal.Gui.ProgressBar();
            this.label3 = new Terminal.Gui.Label();
            this.gpuBar = new Terminal.Gui.ProgressBar();
            this.label4 = new Terminal.Gui.Label();
            this.memBar = new Terminal.Gui.ProgressBar();
            this.label2 = new Terminal.Gui.Label();
            this.cpuBar = new Terminal.Gui.ProgressBar();
            this.label = new Terminal.Gui.Label();
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Visible = true;
            this.Arrangement = Terminal.Gui.ViewArrangement.Overlapped;
            this.CanFocus = true;
            this.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.Modal = false;
            this.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Title = "";
            this.label.Width = Dim.Auto();
            this.label.Height = Dim.Auto();
            this.label.X = 0;
            this.label.Y = 0;
            this.label.Visible = true;
            this.label.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.label.CanFocus = false;
            this.label.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.label.Data = "label";
            this.label.Text = "CPU";
            this.label.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.label);
            this.cpuBar.Width = Dim.Fill(0);
            this.cpuBar.Height = 1;
            this.cpuBar.X = 4;
            this.cpuBar.Y = 0;
            this.cpuBar.Visible = true;
            this.cpuBar.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.cpuBar.CanFocus = false;
            this.cpuBar.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.cpuBar.Data = "cpuBar";
            this.cpuBar.Text = "0%";
            this.cpuBar.TextAlignment = Terminal.Gui.Alignment.Start;
            this.cpuBar.Fraction = 0F;
            this.cpuBar.BidirectionalMarquee = true;
            this.cpuBar.ProgressBarStyle = Terminal.Gui.ProgressBarStyle.Blocks;
            this.cpuBar.ProgressBarFormat = Terminal.Gui.ProgressBarFormat.SimplePlusPercentage;
            this.cpuBar.SegmentCharacter = new System.Text.Rune('▌');
            this.Add(this.cpuBar);
            this.label2.Width = Dim.Auto();
            this.label2.Height = Dim.Auto();
            this.label2.X = 0;
            this.label2.Y = 1;
            this.label2.Visible = true;
            this.label2.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.label2.CanFocus = false;
            this.label2.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.label2.Data = "label2";
            this.label2.Text = "RAM";
            this.label2.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.label2);
            this.memBar.Width = Dim.Fill(0);
            this.memBar.Height = 1;
            this.memBar.X = 4;
            this.memBar.Y = 1;
            this.memBar.Visible = true;
            this.memBar.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.memBar.CanFocus = false;
            this.memBar.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.memBar.Data = "memBar";
            this.memBar.Text = "0%";
            this.memBar.TextAlignment = Terminal.Gui.Alignment.Start;
            this.memBar.Fraction = 0F;
            this.memBar.BidirectionalMarquee = true;
            this.memBar.ProgressBarStyle = Terminal.Gui.ProgressBarStyle.Blocks;
            this.memBar.ProgressBarFormat = Terminal.Gui.ProgressBarFormat.SimplePlusPercentage;
            this.memBar.SegmentCharacter = new System.Text.Rune('▌');
            this.Add(this.memBar);
            this.label4.Width = Dim.Auto();
            this.label4.Height = Dim.Auto();
            this.label4.X = 0;
            this.label4.Y = 2;
            this.label4.Visible = true;
            this.label4.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.label4.CanFocus = false;
            this.label4.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.label4.Data = "label4";
            this.label4.Text = "GPU";
            this.label4.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.label4);
            this.gpuBar.Width = Dim.Fill(0);
            this.gpuBar.Height = 1;
            this.gpuBar.X = 4;
            this.gpuBar.Y = 2;
            this.gpuBar.Visible = true;
            this.gpuBar.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.gpuBar.CanFocus = false;
            this.gpuBar.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.gpuBar.Data = "gpuBar";
            this.gpuBar.Text = "0%";
            this.gpuBar.TextAlignment = Terminal.Gui.Alignment.Start;
            this.gpuBar.Fraction = 0F;
            this.gpuBar.BidirectionalMarquee = true;
            this.gpuBar.ProgressBarStyle = Terminal.Gui.ProgressBarStyle.Blocks;
            this.gpuBar.ProgressBarFormat = Terminal.Gui.ProgressBarFormat.SimplePlusPercentage;
            this.gpuBar.SegmentCharacter = new System.Text.Rune('▌');
            this.Add(this.gpuBar);
            this.label3.Width = Dim.Auto();
            this.label3.Height = Dim.Auto();
            this.label3.X = 0;
            this.label3.Y = 3;
            this.label3.Visible = true;
            this.label3.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.label3.CanFocus = false;
            this.label3.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.label3.Data = "label3";
            this.label3.Text = "/";
            this.label3.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.label3);
            this.rootBar.Width = Dim.Fill(0);
            this.rootBar.Height = 1;
            this.rootBar.X = 4;
            this.rootBar.Y = 3;
            this.rootBar.Visible = true;
            this.rootBar.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.rootBar.CanFocus = false;
            this.rootBar.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.rootBar.Data = "rootBar";
            this.rootBar.Text = "0%";
            this.rootBar.TextAlignment = Terminal.Gui.Alignment.Start;
            this.rootBar.Fraction = 0F;
            this.rootBar.BidirectionalMarquee = true;
            this.rootBar.ProgressBarStyle = Terminal.Gui.ProgressBarStyle.Blocks;
            this.rootBar.ProgressBarFormat = Terminal.Gui.ProgressBarFormat.SimplePlusPercentage;
            this.rootBar.SegmentCharacter = new System.Text.Rune('▌');
            this.Add(this.rootBar);
            this.line2.Width = Dim.Fill(0);
            this.line2.Height = 1;
            this.line2.X = -1;
            this.line2.Y = 4;
            this.line2.Visible = true;
            this.line2.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.line2.CanFocus = false;
            this.line2.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.line2.Data = "line2";
            this.line2.Text = "";
            this.line2.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.line2);
            this.staticTextView.Width = Dim.Fill(0);
            this.staticTextView.Height = 4;
            this.staticTextView.X = 0;
            this.staticTextView.Y = 5;
            this.staticTextView.Visible = true;
            this.staticTextView.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.staticTextView.CanFocus = false;
            this.staticTextView.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.staticTextView.AllowsTab = true;
            this.staticTextView.AllowsReturn = true;
            this.staticTextView.WordWrap = false;
            this.staticTextView.Data = "staticTextView";
            this.staticTextView.Text = "Waiting for a response from the server...";
            this.staticTextView.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.staticTextView);
            this.line.Width = Dim.Fill(0);
            this.line.Height = 1;
            this.line.X = -1;
            this.line.Y = 9;
            this.line.Visible = true;
            this.line.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.line.CanFocus = false;
            this.line.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.line.Data = "line";
            this.line.Text = "";
            this.line.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.line);
            this.textView.Width = Dim.Fill(0);
            this.textView.Height = 4;
            this.textView.X = 0;
            this.textView.Y = 10;
            this.textView.Visible = true;
            this.textView.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.textView.CanFocus = false;
            this.textView.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.textView.AllowsTab = true;
            this.textView.AllowsReturn = true;
            this.textView.WordWrap = false;
            this.textView.Data = "textView";
            this.textView.Text = "";
            this.textView.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.textView);
            this.line3.Width = Dim.Fill(0);
            this.line3.Height = 1;
            this.line3.X = -1;
            this.line3.Y = 14;
            this.line3.Visible = true;
            this.line3.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.line3.CanFocus = false;
            this.line3.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.line3.Data = "line3";
            this.line3.Text = "";
            this.line3.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.line3);
            this.label5.Width = Dim.Auto();
            this.label5.Height = Dim.Auto();
            this.label5.X = 0;
            this.label5.Y = 15;
            this.label5.Visible = true;
            this.label5.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.label5.CanFocus = false;
            this.label5.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.label5.Data = "label5";
            this.label5.Text = "Disconnected";
            this.label5.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.label5);
        }
    }
}
