using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebNinja.selenium;

namespace WebNinja.workflow
{
    public class ProjectWorkflow
    {
        private CodeTrack _codeTrack;
        public ProjectWorkflow(CodeTrack codeTrack)
        {
            _codeTrack = codeTrack;
        }

        public string CurrentProject
        {
            set { throw new NotImplementedException(); }
        }
    }
}
