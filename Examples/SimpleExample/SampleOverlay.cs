namespace SimpleExample
{
    using ClickableTransparentOverlay;
    using System.Threading.Tasks;
    using ImGuiNET;

    internal class SampleOverlay : Overlay
    {
        private int FPSHelper;

        public SampleOverlay() : base(3840, 2160) // Constructor
        {
        }



        protected override void Render()
        {

            if (ImGui.Begin("FPS Changer"))
            {

            }
            ImGui.End();

        }
    }
}
