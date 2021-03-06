﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MechatronicDesignSuite_DLL.BaseNodes
{
    public class imsAPISysModule:imsSysModuleNode
    {
        
        protected PCExeSys PCExeSysLink;



        public imsAPISysModule(List<imsBaseNode> globalNodeListIn) : base(globalNodeListIn)
        {
            NodeType = typeof(imsAPISysModule);
            NodeName = "API Module Node";
        }
        public imsAPISysModule(PCExeSys PCExeSysIn, List<imsBaseNode> globalNodeListIn) : base(globalNodeListIn)
        {
            NodeType = typeof(imsAPISysModule);
            NodeName = "API Module Node";
            if (PCExeSysIn != null)
                PCExeSysLink = PCExeSysIn;
        }
        public imsAPISysModule(BinaryFormatter DeSerializeFormatter, FileStream deSerializeFs) : base(DeSerializeFormatter, deSerializeFs)
        {

        }
        public virtual void deSerializeSetAPILinks(PCExeSys PCExeSysIn)
        {
            if (PCExeSysIn == null)
                return;

            PCExeSysLink = PCExeSysIn;
            PCExeSysLink.APISysModules.Add(this);
        }
    }
}
