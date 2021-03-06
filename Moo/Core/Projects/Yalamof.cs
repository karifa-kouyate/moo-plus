﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    [Serializable]
    class Yalamof: Project
    {
        public Yalamof(): base()
        {
            this.type = PType.Yalamof;
        }
        public Yalamof(string filepath) : base(filepath)
        {
            this.type = PType.Yalamof;
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("yalamof");
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles("Yalamof");
        }
        public override string[] GetKeywords()
        {
            return base.GetKeywords("yalamof");
        }

        public override void Build(BuildOutput console)
        {

        }
        public override void Run()
        {

        }
        public override void GetBuildTool()
        {

        }
        public override void GetCmdArgs()
        {

        }

        #endregion

    }
}
