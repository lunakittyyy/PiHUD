
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v2.0.0.0
//      You can make changes to this file and they will not be overwritten when saving.
//  </auto-generated>
// -----------------------------------------------------------------------------

using Newtonsoft.Json;
using PiHUD_client;
using PiHUD.Client;
using WebSocketSharp;
using PiHUD.Core;
using Timer = System.Timers.Timer;

namespace PiHud.Client {
    using Terminal.Gui;
    
    
    public partial class StatDisplay {
        public ProgressBar CpuBar => this.cpuBar;
        public ProgressBar RamBar => this.memBar;
        public ProgressBar GpuBar => this.gpuBar;
        public ProgressBar RootBar => this.rootBar;
        public TextView StaticTextView => this.staticTextView;
        public TextView TextView => this.textView;
        public Label StatusLabel => this.label5;
        public StatDisplay()
        {
            InitializeComponent();
        }
    }
}
