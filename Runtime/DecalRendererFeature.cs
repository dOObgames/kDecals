using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace kTools.Decals
{
    sealed class DecalRendererFeature : ScriptableRendererFeature
    {
#pragma warning disable CS0649
        public RenderPassEvent RenderPassEvent;
#pragma warning restore CS0649
        private DecalRenderPass m_RenderPass;

        public override void Create()
        {
            if(m_RenderPass != null)
            {
                return;
            }

            this.name = "Decals";
            m_RenderPass = new DecalRenderPass(this.RenderPassEvent);            
        } 

        /// <inhertidoc />
        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            // Enqueue passes
            renderer.EnqueuePass(m_RenderPass);
        }
    }
}
