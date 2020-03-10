using UnityEditor.Graphing;
using UnityEngine;
using Edge = UnityEditor.Experimental.GraphView.Edge;

namespace UnityEditor.ShaderGraph
{
    class RedirectNodeData : AbstractMaterialNode
    {
        public Edge m_Edge;

        SlotReference m_slotReferenceInput;
        public SlotReference slotReferenceInput
        {
            get => m_slotReferenceInput;
            set => m_slotReferenceInput = value;
        }

        public RedirectNodeData()
        {
            name = "Redirect Node";
        }

        RedirectNodeView m_nodeView;
        public RedirectNodeView nodeView
        {
            get { return m_nodeView; }
            set
            {
                if (value != m_nodeView)
                    m_nodeView = value;
            }
        }

        // Center the node's position?
        public void SetPosition(Vector2 pos)
        {
            var temp = drawState;
            temp.position = new Rect(pos, Vector2.zero);
            drawState = temp;
        }
    }
}
