using CrashEdit.CE.Properties;

namespace CrashEdit.CE
{
    public partial class HelpWindow : AltUI.Forms.DarkForm
    {
        public HelpWindow()
        {
            Icon = Embeds.GetIcon("HelpSymbol");
            InitializeComponent();

            lbEntityListBox.Text = Properties.EventHandler.EntityBox_tipLists;
            lbProperties.Text = Properties.EventHandler.EntityPropertyBox_tipProperties;
            lbSavedProperties.Text = Properties.EventHandler.EntityPropertyBox_tipSavedProperties;
            lbHexViewer.Text = Properties.EventHandler.HexView_tip;
            lbTextureChunk.Text = Properties.EventHandler.TextureChunkBox_TipText;
            lbTextureViewer.Text = Properties.EventHandler.TextureViewer_tipViewer;
            lbNSDBox.Text = Properties.EventHandler.NSDBox_tipSpawnPoint;
        }
    }
}
