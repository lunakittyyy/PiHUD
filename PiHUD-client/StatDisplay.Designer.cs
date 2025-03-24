
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
        
        private Terminal.Gui.Label label3;
        
        private Terminal.Gui.ProgressBar rootBar;
        
        private Terminal.Gui.TextView textView;
        
        private void InitializeComponent() {
            this.textView = new Terminal.Gui.TextView();
            this.rootBar = new Terminal.Gui.ProgressBar();
            this.label3 = new Terminal.Gui.Label();
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
            this.cpuBar.Text = "50%";
            this.cpuBar.TextAlignment = Terminal.Gui.Alignment.Start;
            this.cpuBar.Fraction = 0.5F;
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
            this.memBar.Text = "100%";
            this.memBar.TextAlignment = Terminal.Gui.Alignment.Start;
            this.memBar.Fraction = 1F;
            this.memBar.BidirectionalMarquee = true;
            this.memBar.ProgressBarStyle = Terminal.Gui.ProgressBarStyle.Blocks;
            this.memBar.ProgressBarFormat = Terminal.Gui.ProgressBarFormat.SimplePlusPercentage;
            this.memBar.SegmentCharacter = new System.Text.Rune('▌');
            this.Add(this.memBar);
            this.label3.Width = Dim.Auto();
            this.label3.Height = Dim.Auto();
            this.label3.X = 0;
            this.label3.Y = 2;
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
            this.rootBar.Y = 2;
            this.rootBar.Visible = true;
            this.rootBar.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.rootBar.CanFocus = false;
            this.rootBar.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.rootBar.Data = "rootBar";
            this.rootBar.Text = "100%";
            this.rootBar.TextAlignment = Terminal.Gui.Alignment.Start;
            this.rootBar.Fraction = 1F;
            this.rootBar.BidirectionalMarquee = true;
            this.rootBar.ProgressBarStyle = Terminal.Gui.ProgressBarStyle.Blocks;
            this.rootBar.ProgressBarFormat = Terminal.Gui.ProgressBarFormat.SimplePlusPercentage;
            this.rootBar.SegmentCharacter = new System.Text.Rune('▌');
            this.Add(this.rootBar);
            this.textView.Width = Dim.Fill(0);
            this.textView.Height = 12;
            this.textView.X = 0;
            this.textView.Y = 3;
            this.textView.Visible = true;
            this.textView.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.textView.CanFocus = false;
            this.textView.ShadowStyle = Terminal.Gui.ShadowStyle.None;
            this.textView.AllowsTab = true;
            this.textView.AllowsReturn = true;
            this.textView.WordWrap = false;
            this.textView.Data = "textView";
            this.textView.Text = "wawa";
            this.textView.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.textView);
        }
    }
}
